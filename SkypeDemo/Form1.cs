using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeDemo
{
    public partial class Form1 : Form
    {
        int panelWidth;
        bool Hidden;
        public Form1()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 10;
                if (PanelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 10;
                if (PanelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Productos u = new Productos();
            panelContenedor.Controls.Add(u);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Proveedor u = new Proveedor();
            panelContenedor.Controls.Add(u);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Clientes u = new Clientes();
            panelContenedor.Controls.Add(u);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Empleados u = new Empleados();
            panelContenedor.Controls.Add(u);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrarCesion_Click(object sender, EventArgs e)
        {
            login ss = new login();
            ss.Show();
            this.Hide();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Users u = new Users();
            panelContenedor.Controls.Add(u);
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            VENTAS u = new VENTAS();
            panelContenedor.Controls.Add(u);

        }
    }
}
