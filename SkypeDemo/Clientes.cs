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
    public partial class Clientes : UserControl
    {
        int codigo = 1;
        public Clientes()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            txtcod.Text = codigo.ToString();
            txtnom.Text = "";
            txttel.Text = "";
            txtdirec.Text = "";
        }

        private void Txttel_TextChanged(object sender, EventArgs e)
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
                    txttel.Text,
                    txtdirec.Text,
                    };
            dataGridView1.Rows.Add(agregardato);
            MessageBox.Show("Producto registrado.", "Mensaje");
            codigo++;
            txtcod.Text = codigo.ToString();
            limpiar();
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

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int indice = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[indice].Cells[0].Value = txtcod.Text;
                dataGridView1.Rows[indice].Cells[1].Value = txtnom.Text;
                dataGridView1.Rows[indice].Cells[2].Value = txttel.Text;
                dataGridView1.Rows[indice].Cells[3].Value = txtdirec.Text;
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
                txttel.Text = dataGridView1[2, fila].Value.ToString();
                txtdirec.Text = dataGridView1[3, fila].Value.ToString();
            }
        }
    }
}
