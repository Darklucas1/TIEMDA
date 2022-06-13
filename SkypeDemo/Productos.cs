using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeDemo
{
    public partial class Productos : UserControl
    {
        int codigo = 1;
        public Productos()
        {
            InitializeComponent();
        }
        //funcion para limpiar y crear codigo nuevo
        void limpiar()
        {
            txtcod.Text = codigo.ToString();
            txtnom.Text = "";
            txtMarca.Text = "";
            txtCategoria.Text = "";
            txtContenido.Text = "";
        }
        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Btnregistrar_Click(object sender, EventArgs e)
        {
            object[] agregardato =
                    {
                    codigo.ToString(),
                    txtnom.Text,
                    txtMarca.Text,
                    txtCategoria.Text,
                    txtfecha.Text,
                    txtContenido.Text
                    };
            dataGridView1.Rows.Add(agregardato);
            MessageBox.Show("Producto registrado.", "Mensaje");
            codigo++;
            txtcod.Text = codigo.ToString();
            limpiar();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int indice = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[indice].Cells[0].Value = txtcod.Text;
                dataGridView1.Rows[indice].Cells[1].Value = txtnom.Text;
                dataGridView1.Rows[indice].Cells[2].Value = txtMarca.Text;
                dataGridView1.Rows[indice].Cells[3].Value = txtCategoria.Text;
                dataGridView1.Rows[indice].Cells[4].Value = txtfecha.Text;
                dataGridView1.Rows[indice].Cells[5].Value = txtContenido.Text;
                MessageBox.Show("Producto modificado.", "Mensaje");
                limpiar();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fila = dataGridView1.CurrentCell.RowIndex;
                txtcod.Text = dataGridView1[0, fila].Value.ToString();
                txtnom.Text = dataGridView1[1, fila].Value.ToString();
                txtMarca.Text = dataGridView1[2, fila].Value.ToString();
                txtCategoria.Text = dataGridView1[3, fila].Value.ToString();
                txtfecha.Text = dataGridView1[4, fila].Value.ToString();
                txtContenido.Text = dataGridView1[5, fila].Value.ToString();
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fil = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(fil);
                MessageBox.Show("Producto eliminado.", "Mensaje");
            }
            limpiar();
        }
    }
}
