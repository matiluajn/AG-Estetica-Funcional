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
    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp= MessageBox.Show("Confirma el alta...", "Alta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            var pr = new Productos();

            if (resp == DialogResult.Yes)
            {
                pr.codProducto =Convert.ToInt64( txtCodProd.Text);
                pr.codTipo = Convert.ToInt64(txtCodTipo.Text);
                pr.codMarca = Convert.ToInt64(txtCodMarca.Text);
                pr.codDetallePedido = Convert.ToInt64(txtCodDetallePedido.Text);
                pr.codDetalleVenta = Convert.ToInt64(txtCodDetalleVenta.Text);
                pr.tipo = txtTipo.Text;
                pr.marca = txtMarca.Text;
                pr.descripcion = txtDescripcion.Text;
                pr.ML =Convert.ToInt32( txtMl.Text);
                pr.CC = Convert.ToInt32(txtCc.Text);
                pr.GR = Convert.ToInt32(txtGr.Text);
                pr.cantidad =Convert.ToInt32( txtCantidad.Text);
                pr.precio = Convert.ToInt32(txtPrecio.Text);

                var prMetodo = new productosMetodo();
                prMetodo.AgregarProductos(pr);

                this.Close();

                var menu = new frmproductos();
                this.Hide();
                menu.Show();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var menu = new frmproductos();
            this.Hide();
            menu.Show();
        }
    }
}
