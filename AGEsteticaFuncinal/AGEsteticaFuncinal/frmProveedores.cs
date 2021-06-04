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

    public partial class frmProveedores : Form
    {
        String C ;
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var pr = new ProveedoresMetodo();

            dt = pr.consultar();

            dgvProveedores.DataSource = dt;

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var menu = new frmAltaProveedor();
            this.Hide();
            menu.Show();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            var menu = new menuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var menu = new frmModificar();
            this.Hide();
            menu.Show();




        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            C = dgvProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
           // C = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Eliminacion...", "Eliminar", MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

          
            if ((resp == DialogResult.Yes))
            {
                var prMetodo = new ProveedoresMetodo();
                bool borro = prMetodo.borrarProveedor ( C);
                if (borro == false)
                {
                    MessageBox.Show("Error en eliminacion", "Verifique");
                }

            }
        }
    }
}
