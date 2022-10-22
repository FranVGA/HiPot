using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiPot
{
    public partial class Form1 : Form
    {
        int m, mX, mY;
        int x;
        int porcentaje;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }

        private void TiPB_Tick(object sender, EventArgs e)
        {
            ProB.Width = x;
            x += 10;
            porcentaje = (x * 100) / borde.Width;
            if (porcentaje >= 100)
                {
                    Form HiPot = new HiPot();
                    HiPot.Show();
                    this.Hide();
                    TiPB.Stop();
                }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TiPB.Start();
            TiPB.Interval = 50;
        }
    }
}
