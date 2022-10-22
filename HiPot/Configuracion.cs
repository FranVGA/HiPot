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
using System.Configuration;

namespace HiPot
{
    
    public partial class Configuracion : Form
    {
        int m, mX, mY;
        /*Variables de Puerto de comunicacion del Arduino*/
        int BaudRateArd;
        string ComArd;
        string RutaConfigArdui = @"E:\HiPot\Archivos de configuracion\Arduino.txt";
        public Configuracion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
        
            using (StreamReader readtext = new StreamReader(RutaConfigArdui))
            {
                string leerComAr = readtext.ReadLine();
                ComArd = leerComAr;
                string leerBaudAr = readtext.ReadLine();
                BaudRateArd = Convert.ToInt16(leerBaudAr);
            }
            CBBauArd.Text = Convert.ToString(BaudRateArd);
            CBPortArd.Text = ComArd;

        }

        private void CBPortArd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CBBauArd_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string[] puertosDisponibles = SerialPort.GetPortNames();
            CBPortArd.Items.Clear();
            foreach (string puerto_simple in puertosDisponibles)
            { 
                CBPortArd.Items.Add(puerto_simple);
            }
            if (CBPortArd.Items.Count > 0)
            {
                CBPortArd.SelectedIndex = 0;
                MessageBox.Show("Seleccionar el puerto de trabajo");
            }
            else 
            {
                MessageBox.Show("Ningun puerto disponible");
                CBPortArd.Items.Clear ();
                CBPortArd.Text = "                    ";
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }


        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }
    }
}
