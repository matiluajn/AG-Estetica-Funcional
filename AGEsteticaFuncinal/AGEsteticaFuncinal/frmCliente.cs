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
    public partial class frmCliente : Form
    {
        string c;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var pr = new ClientesMetodo();

            dt = pr.consultar();

            dgvCliente.DataSource = dt;
        }

        private void btnAltaC_Click(object sender, EventArgs e)
        {
            var menu = new frmAltaCliente();
            this.Hide();
            menu.Show();
        }

        private void btnModificarC_Click(object sender, EventArgs e)
        {
            var menu = new frmClienteModificar();
            this.Hide();
            menu.Show();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            c = dgvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            var menu = new menuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Eliminacion...", "Eliminar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);


            if ((resp == DialogResult.Yes))
            {
                var clMetodo = new ClientesMetodo();
                bool borro = clMetodo.borrarCliente(c);
                if (borro == false)
                {
                    MessageBox.Show("Error en eliminacion", "Verifique");
                }
            }
        }
    }
}
