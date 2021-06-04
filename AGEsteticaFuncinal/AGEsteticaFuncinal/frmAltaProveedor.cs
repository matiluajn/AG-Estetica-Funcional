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
    public partial class frmAltaProveedor : Form
    {
        public frmAltaProveedor()
        {
            InitializeComponent();
        }

        private void btnCerrarAltProv_Click(object sender, EventArgs e)
        {
            this.Close();

            var menu = new frmProveedores();
            this.Hide();
            menu.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma el alta...", "Alta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            var pr = new Proveedores();

            if (resp == DialogResult.Yes)
            {
                pr.CUIT = Convert.ToInt64 (txtCuit.Text);
                pr.razonSocial = txtRazonsocial.Text;
                pr.nombrePersonaContacto = txtNomcontacto.Text;
                pr.apellidoPersonaContacto = txtApellidocontacto.Text;
                pr.celular =Convert.ToInt64( txtCelular.Text);
                pr.telefono =Convert.ToInt64( txtTelefono.Text);
                pr.calle = txtCalle.Text;
                pr.numero =Convert.ToInt32( txtNumero.Text);
                pr.barrio = txtBarrio.Text;
                pr.cp =Convert.ToInt32( txtCp.Text);
                pr.email = txtMail.Text;
                pr.fechaAlta = Convert.ToDateTime( dtpFechaAlta.Text);

                var prmetodo = new ProveedoresMetodo();

                prmetodo.AgregarProveedor(pr);

                this.Close();

                var menu = new frmProveedores();
                this.Hide();
                menu.Show();
            }
        }

        private void frmAltaProveedor_Load(object sender, EventArgs e)
        {
            var menu = new menuPrincipal();
            this.Hide();
            menu.Show();
        }
    }
}
