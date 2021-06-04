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
    public partial class frmCargarServicio : Form
    {
        public frmCargarServicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Carga...", "Carga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var sr = new Servicios();

            if(resp == DialogResult.Yes)
            {
                sr.codigoServicio =Convert.ToInt64( txtCodigoServicio.Text);
                sr.dni = Convert.ToInt64(txtDniCliente.Text);
                sr.descripcion = txtDescripcion.Text;
                sr.tiempo = Convert.ToInt16(txtTiempo.Text);
                sr.costo =Convert.ToDouble( txtCosto.Text);

                var srMetodo = new ServiciosMetodo();
                srMetodo.cargarServicio(sr);

                this.Close();

                var menu = new frmServicios();
                this.Hide();
                menu.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var menu = new frmServicios();
            this.Hide();
            menu.Show();
        }
    }
}
