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
    public partial class frmServicios : Form
    {
        string c;

        public frmServicios()
        {
            InitializeComponent();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            var menu = new menuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var menu = new frmCargarServicio();
            this.Hide();
            menu.Show();
        }

        private void btnModifServ_Click(object sender, EventArgs e)
        {
            var menu = new frmModificarServicio();
            this.Hide();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var cl = new ServiciosMetodo();

            dt = cl.consultar();

            dgvServicios.DataSource = dt;
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            c = dgvServicios.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnEliminarSeerv_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Eliminacion...", "Eliminar", MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);


            if ((resp == DialogResult.Yes))
            {
                var srMetodo = new ServiciosMetodo();
                bool borro = srMetodo.borrarServicio(c);
                if (borro == false)
                {
                    MessageBox.Show("Error en eliminacion", "Verifique");
                }

            }
        }
    }
}
