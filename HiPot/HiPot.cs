using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection.Emit;

namespace HiPot
{
    public partial class HiPot : Form
    {
        /*BarraDeMovimiento*/
        int m, mX, mY;
        /*Variables de Puerto de comunicacion del Arduino*/
        int BaudRateArd;
        string ComArd;
        string RutaConfigArdui = @"E:\HiPot\Archivos de configuracion\Arduino.txt";
        bool ePort = false;
        /*Valores de prueba*/
        string CodigoPieza;
        int i = 0;
        /*Fecha, hora y registros*/
        string Fecha;
        String Hora;
        int contadorP;
        int contadorF;
        int TotalPrubado;
        string horadeinicio;

        public HiPot()
        {
            InitializeComponent();
        }
        private void HiPot_Load(object sender, EventArgs e)
        {
            horadeinicio = DateTime.Now.ToString("hh:mm:ss");
            contadorP = 0;
            contadorF = 0;
            pnconf.Visible = false;
            btnEmp.Enabled = false;
            /*Configuracion por arduino*/
            using (StreamReader readtext = new StreamReader(RutaConfigArdui))
            {
                string leerComAr = readtext.ReadLine();
                ComArd = leerComAr;
                string leerBaudAr = readtext.ReadLine();
                BaudRateArd = Convert.ToInt16(leerBaudAr);
            }
            ArduinCon.BaudRate = BaudRateArd;
            ArduinCon.DataBits = 8;
            ArduinCon.Parity = Parity.None;
            ArduinCon.StopBits = StopBits.One;
            ArduinCon.PortName = ComArd;
            ArduinCon.ReadTimeout = 500;
            fecha_Hora.Start();
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            pbconec.Image = Properties.Resources.declined;
        }

        /*BarraDeMovimiento*/
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
        private void canconf_Click(object sender, EventArgs e)
        {
            pnconf.Visible = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.Navy;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Navy;
        }

        private void minimized_MouseHover(object sender, EventArgs e)
        {
            minimized.BackColor = Color.Navy;
        }

        private void minimized_MouseLeave(object sender, EventArgs e)
        {
            minimized.BackColor = Color.Transparent;
        }

        private void minimized_MouseMove(object sender, MouseEventArgs e)
        {
            minimized.BackColor = Color.Navy;
        }

        /*Prueba*/

        private void btnEmp_Click(object sender, EventArgs e)
        {
            CodigoPieza = tbCiTab.Text;
            label4.Text = "NA";
            ArduinCon.WriteLine("B");
            progressBar1.Value = 0;
            timer2.Start();
        }
        string resultadoSubstring;
        private void timer2_Tick(object sender, EventArgs e)
        {
            ArduinCon.WriteLine("A");
            try
            {
                label4.Text = ArduinCon.ReadLine();
            }
            catch (Exception exc) 
            {
            }
            if (i == 68) 
            {
                resultadoSubstring = label4.Text.Substring(0, 1);
                label6.Text = resultadoSubstring;
                if (resultadoSubstring == "P")
                {
                    contadorP++;
                    label5.Text = "Pasa";
                    ResulListPass();
                }
                else if (resultadoSubstring == "F")
                {
                    contadorF++;
                    label5.Text = "Falla";
                    ResulListFail();
                }
                else
                {
                    contadorF++;
                    label5.Text = "Falla";
                    ResulListFail();
                }
                timer2.Stop();
                i = 0;
            }
            if (progressBar1.Value < 100)
            {
                progressBar1.PerformStep();
            }
            else if (progressBar1.Value==100)
            { 
                
            }   
            i++;
        }

        public void ResulListPass()
        {
            string rutaCompleta = @"E:\" + CodigoPieza + " " + Fecha + " " + Hora;
            string contadorps = Convert.ToString(contadorP);
            ListPz.Items.Add(contadorps + "   " + CodigoPieza + "            Pasa       " + Fecha + "      " + Hora);
            lblPass.Text = contadorps;
            piboxStatus.Image = Properties.Resources.okay;
            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(CodigoPieza);
                mylogs.WriteLine("Pass");
                mylogs.WriteLine("   ,  " + CodigoPieza + ",           ,                     ,                     ,      ,                ,                     ,                 ,   " + "Pass" + ",");
                mylogs.Close();
            }
        }

        public void ResulListFail()
        {
            string rutaCompleta = @"E:\" + CodigoPieza + " " + Fecha + " " + Hora;
            string contadorfs = Convert.ToString(contadorF);
            lblFall.Text = contadorfs;
            ListPz.Items.Add(contadorfs + "   " + CodigoPieza + "            Falla       " + Fecha + "      " + Hora);
            piboxStatus.Image = Properties.Resources.bad;
            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(CodigoPieza);
                mylogs.WriteLine("Fail");
                mylogs.WriteLine("   ,  " + CodigoPieza + ",           ,                     ,                     ,      ,                ,                     ,                 ,   " + "Fail" + ",");
                mylogs.Close();
            }
        }
        /*Configuracion*/

        private void configuracionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnconf.Visible = true;
        }

        private void fecha_Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            Hora = DateTime.Now.ToString("hhmmss");
            lblfecha.Text = DateTime.Now.ToShortDateString();
            Fecha = DateTime.Now.ToString("yyyyMMdd");
            TotalPrubado = contadorF + contadorP;
            label11.Text = Convert.ToString(TotalPrubado);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnconect_Click(object sender, EventArgs e)
        { 
            if (!ArduinCon.IsOpen)
            {
                try
                {
                    pbconec.Image = Properties.Resources.approved;
                    ArduinCon.Open();
                    btnEmp.Enabled = true;
                }
                catch (Exception error)
                {
                    pbconec.Image = Properties.Resources.declined;
                    btnEmp.Enabled = false;
                    MessageBox.Show("Puerto no encontrado");
                }
            }
            else if(ArduinCon.IsOpen)
            {
                pbconec.Image = Properties.Resources.approved;
                MessageBox.Show("Puerto conectado");
            }
        }
        /*grupconf*/
        private void UsuarioCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            { 
                ContraseCon.Focus();
            }
        }

        private void ContraseCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (UsuarioCon.Text == "Admin" && ContraseCon.Text == "Root")
                {
                    Form Configuracion = new Configuracion();
                    Configuracion.Show();
                    pnconf.Visible = false;
                }
            }
        }

        private void bntconf_Click_1(object sender, EventArgs e)
        {
            if (UsuarioCon.Text == "Admin" && ContraseCon.Text == "Root")
            {
                Form Configuracion = new Configuracion();
                Configuracion.Show();
                pnconf.Visible = false;
            }
        }

        private void HiPot_FormClosed(object sender, FormClosedEventArgs e)
        {
            ePort = true;
            if (ArduinCon.IsOpen)
            { 
                ArduinCon.Close(); 
            }
        }
    }
}
