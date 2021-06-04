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
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            DialogResult resp = MessageBox.Show("Confirma el alta...", "Alta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            var al = new Cliente();

            if (resp == DialogResult.Yes)
            {
                al.dni =Convert.ToInt64( txtdniC.Text);
                al.nombre = txtNombreC.Text;
                al.apellido = txtApellidoC.Text;
                al.fechaNacimiento = Convert.ToDateTime( dtpFechaDeNacC.Text);
                al.celular =Convert.ToInt64( txtCelularC.Text);
                al.telefono =Convert.ToInt64( txtTelefonoC.Text);
                al.calle = txtCalleC.Text;
                al.numero =Convert.ToInt32( txtNumeroC.Text);
                al.barrio = txtBarrioC.Text;
                al.cp =Convert.ToInt32( txtCpC.Text);
                al.email = txtEmail.Text;
                al.derivacionMedica = txtDerivacionMedicaC.Text;
                al.diagnostico = txtDiagnosticoC.Text;
                al.medicacion = txtMedicacionC.Text;
                al.lesion = txtLesionC.Text;
                al.fechaAlta =Convert.ToDateTime( dtpFechaAltaC.Text);

                var alMetodo = new ClientesMetodo();
                alMetodo.AltaCliente(al);

                this.Close();

                var menu = new frmCliente();
                this.Hide();
                menu.Show();


            }


        }

        private void btnCerrarAltProv_Click(object sender, EventArgs e)
        {
            this.Close();

            var menu = new frmCliente();
            this.Hide();
            menu.Show();
        }
    }
}
