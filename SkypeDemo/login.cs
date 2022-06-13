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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsers.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("ingresar usuario y constraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else if (txtUsers.Text == "")
            {
                MessageBox.Show("No ingreso un usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("No ingreso un contyraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtUsers.Text!="admin" || txtPassword.Text!="admin")
            {
                MessageBox.Show("usuario o contraseña invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Splash_Screen ss = new Splash_Screen();
                ss.Show();
                this.Hide();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form2 user = new Form2();
            user.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsers_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MostrarContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;

            }
            else 
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void MostrarContraseña_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
