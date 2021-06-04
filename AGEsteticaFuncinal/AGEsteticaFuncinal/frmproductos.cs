using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGEsteticaFuncinal
{
    public partial class frmproductos : Form
    {
        string c;

        public frmproductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var pr = new productosMetodo();

            dt = pr.consultar();

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var menu = new frmAltaProducto();
            this.Hide();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var menu = new frmModificarProducto();
            this.Hide();
            menu.Show();
        }

        private void frmproductos_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            c = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Eliminacion...", "Eliminar", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);


            if ((resp == DialogResult.Yes))
            {
                var prMetodo = new productosMetodo();
                bool borro = prMetodo.borrarProductos(c);
                if (borro == false)
                {
                    MessageBox.Show("Error en eliminacion", "Verifique");
                }
            }
        }

       
    }
}

