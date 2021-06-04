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
    public partial class frmClienteModificar : Form
    {
        public frmClienteModificar()
        {
            InitializeComponent();
        }

        private void btnCerrarAltProv_Click(object sender, EventArgs e)
        {
            this.Close();

            var menu = new frmCliente();
            this.Hide();
            menu.Show();
        }

       

        private void dgvClienteMod_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtdniCmodif.Text = dgvClienteMod.CurrentRow.Cells[0].Value.ToString();
            txtNombreCmodif.Text = dgvClienteMod.CurrentRow.Cells[1].Value.ToString();
            txtApellidoCmodif.Text = dgvClienteMod.CurrentRow.Cells[2].Value.ToString();
            dtpFechaDeNacCmodif.Text = dgvClienteMod.CurrentRow.Cells[3].Value.ToString();
            txtCelularCmodif.Text = dgvClienteMod.CurrentRow.Cells[4].Value.ToString();
            txtTelefonoCmodif.Text = dgvClienteMod.CurrentRow.Cells[5].Value.ToString();
            txtCalleCmodif.Text = dgvClienteMod.CurrentRow.Cells[6].Value.ToString();
            txtNumeroCmodif.Text = dgvClienteMod.CurrentRow.Cells[7].Value.ToString();
            txtBarrioCmodif.Text = dgvClienteMod.CurrentRow.Cells[8].Value.ToString();
            txtCpCmodif.Text = dgvClienteMod.CurrentRow.Cells[9].Value.ToString();
            txtEmailmodif.Text = dgvClienteMod.CurrentRow.Cells[10].Value.ToString();
            txtDerivacionMedicaCmodif.Text = dgvClienteMod.CurrentRow.Cells[11].Value.ToString();
            txtDiagnosticoCmodif.Text = dgvClienteMod.CurrentRow.Cells[12].Value.ToString();
            txtMedicacionCmodif.Text = dgvClienteMod.CurrentRow.Cells[13].Value.ToString();
            txtLesionCmodif.Text = dgvClienteMod.CurrentRow.Cells[14].Value.ToString();
            dtpFechaAltaCmodif.Text = dgvClienteMod.CurrentRow.Cells[15].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmClienteModificar_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var cl = new ClientesMetodo();

            dt =cl.consultar();

            dgvClienteMod.DataSource = dt;

        }

        private void btnModifC_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Grabación...", "Modificar", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
            var cl = new Cliente();

            if (resp == DialogResult.Yes)
            {
                cl.dni = Convert.ToInt64(txtdniCmodif.Text);
                cl.nombre = txtNombreCmodif.Text;
                cl.apellido = txtApellidoCmodif.Text;
                cl.fechaNacimiento = Convert.ToDateTime(dtpFechaDeNacCmodif.Text);
                cl.celular = Convert.ToInt64(txtCelularCmodif.Text);
                cl.telefono = Convert.ToInt64(txtTelefonoCmodif.Text);
                cl.calle = txtCalleCmodif.Text;
                cl.numero = Convert.ToInt32(txtNumeroCmodif.Text);
                cl.barrio = txtBarrioCmodif.Text;
                cl.cp = Convert.ToInt32(txtCpCmodif.Text);
                cl.email = txtEmailmodif.Text;
                cl.derivacionMedica = txtDerivacionMedicaCmodif.Text;
                cl.diagnostico = txtDiagnosticoCmodif.Text;
                cl.medicacion = txtMedicacionCmodif.Text;
                cl.lesion = txtLesionCmodif.Text;
                cl.fechaAlta = Convert.ToDateTime(dtpFechaAltaCmodif.Text);

                var clMetodo = new ClientesMetodo();
                clMetodo.ModificarCliente(cl);

                var ds = new DataSet();
                var dt = new DataTable();
                var clc = new ClientesMetodo();

                dt = clc.consultar();

                dgvClienteMod.DataSource = dt;
            }
        }
    }
}
