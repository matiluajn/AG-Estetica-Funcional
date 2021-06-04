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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {

            var ds = new DataSet();
            var dt = new DataTable();
            var pr = new ProveedoresMetodo();

            dt = pr.consultar();

            dgvModificacion.DataSource = dt;




        }

        private void dgvModificacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCuitModif.Text = dgvModificacion.CurrentRow.Cells[0].Value.ToString();
            txtRazonsocialModif.Text = dgvModificacion.CurrentRow.Cells[1].Value.ToString();
            txtNomcontactoModif.Text = dgvModificacion.CurrentRow.Cells[2].Value.ToString();
            txtApellidocontactoModif.Text = dgvModificacion.CurrentRow.Cells[3].Value.ToString();
            txtCelularModif.Text = dgvModificacion.CurrentRow.Cells[4].Value.ToString();
            txtTelefonoModif.Text = dgvModificacion.CurrentRow.Cells[5].Value.ToString();
            txtCalleModif.Text = dgvModificacion.CurrentRow.Cells[6].Value.ToString();
            txtNumeroModif.Text = dgvModificacion.CurrentRow.Cells[7].Value.ToString();
            txtBarrioModif.Text = dgvModificacion.CurrentRow.Cells[8].Value.ToString();
            txtCpModif.Text = dgvModificacion.CurrentRow.Cells[9].Value.ToString();
            txtMailModif.Text = dgvModificacion.CurrentRow.Cells[10].Value.ToString();
            dtpFechaAltaModif.Text = dgvModificacion.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnCerrarModif_Click(object sender, EventArgs e)
        {
            var menu = new frmProveedores();
            this.Hide();
            menu.Show();
        }

        private void btnGrabarModif_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Grabación...", "Modificar", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);
            var pr = new Proveedores();

            if (resp == DialogResult.Yes)
            {
                pr.CUIT = Convert.ToInt64(txtCuitModif.Text);
                pr.razonSocial = txtRazonsocialModif.Text;
                pr.nombrePersonaContacto = txtNomcontactoModif.Text;
                pr.apellidoPersonaContacto = txtApellidocontactoModif.Text;
                pr.celular = Convert.ToInt64(txtCelularModif.Text);
                pr.telefono = Convert.ToInt64(txtTelefonoModif.Text);
                pr.calle = txtCalleModif.Text;
                pr.numero = Convert.ToInt32(txtNumeroModif.Text);
                pr.barrio = txtBarrioModif.Text;
                pr.cp = Convert.ToInt32(txtCpModif.Text);
                pr.email = txtMailModif.Text;
                pr.fechaAlta = Convert.ToDateTime(dtpFechaAltaModif.Text);

                var prMetodo = new ProveedoresMetodo();
                prMetodo.ModificarProveedor(pr);

                var ds = new DataSet();
                var dt = new DataTable();
                var prc = new ProveedoresMetodo();

                dt = prc.consultar();

                dgvModificacion.DataSource = dt;


            }



        }
    }
}
