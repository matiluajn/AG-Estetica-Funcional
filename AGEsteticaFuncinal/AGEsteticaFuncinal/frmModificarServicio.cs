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
    public partial class frmModificarServicio : Form
    {
        public frmModificarServicio()
        {
            InitializeComponent();
        }

        private void frmModificarServicio_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var sr = new ServiciosMetodo();

            dt = sr.consultar();

            dgvServicioModif.DataSource = dt;

        }

        private void dgvServicioModif_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoServicioModif.Text = dgvServicioModif.CurrentRow.Cells[0].Value.ToString();
            txtDniClienteModif.Text= dgvServicioModif.CurrentRow.Cells[1].Value.ToString();
            txtDescripcionModif.Text = dgvServicioModif.CurrentRow.Cells[2].Value.ToString();
            txtTiempoModif.Text = dgvServicioModif.CurrentRow.Cells[3].Value.ToString();
            txtCostoModif.Text= dgvServicioModif.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Grabacion...", "modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var sr = new Servicios();

            if (resp == DialogResult.Yes)
            {
                sr.codigoServicio =Convert.ToInt64( txtCodigoServicioModif.Text);
                sr.dni = Convert.ToInt64( txtDniClienteModif.Text);
                sr.descripcion = txtDescripcionModif.Text;
                sr.tiempo =Convert.ToInt32( txtTiempoModif.Text);
                sr.costo = Convert.ToInt32(txtCostoModif.Text);

                var srMetodo = new ServiciosMetodo();
                srMetodo.ModificarServicio(sr);

                var ds = new DataSet();
                var dt = new DataTable();
                var src = new ServiciosMetodo();

                dt = src.consultar();
                dgvServicioModif.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            var menu = new frmServicios();
            this.Hide();
            menu.Show();
        }
    }
}
