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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var cl = new productosMetodo();

            dt = cl.consultar();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodProdmodif.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCodTipomodif.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCodMarcamodif.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCodDetallePedidomodif.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCodDetalleVentamodif.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTipomodif.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMarcamodif.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtDescripcionmodif.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtMlmodif.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtCcmodif.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtGrmodif.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtCantidadmodif.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtPreciomodif.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Grabacion...", "modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var pr = new Productos();

            if (resp == DialogResult.Yes)
            {
                pr.codProducto =Convert.ToInt64( txtCodProdmodif.Text);
                pr.codTipo = Convert.ToInt64(txtCodTipomodif.Text);
                pr.codMarca = Convert.ToInt64(txtCodMarcamodif.Text);
                pr.codDetallePedido = Convert.ToInt64(txtCodDetallePedidomodif.Text);
                pr.codDetalleVenta = Convert.ToInt64(txtCodDetalleVentamodif.Text);
                pr.tipo = txtTipomodif.Text;
                pr.marca = txtMarcamodif.Text;
                pr.descripcion = txtDescripcionmodif.Text;
                pr.ML = Convert.ToInt32( txtMlmodif.Text);
                pr.CC = Convert.ToInt32(txtCcmodif.Text);
                pr.GR = Convert.ToInt32(txtGrmodif.Text);
                pr.cantidad =Convert.ToInt32( txtCantidadmodif.Text);
                pr.precio = Convert.ToInt32(txtPreciomodif.Text);

                var srMetodo = new productosMetodo();
                srMetodo.ModificarProducto(pr);

                var ds = new DataSet();
                var dt = new DataTable();
                var src = new productosMetodo();

                dt = src.consultar();
                dataGridView1.DataSource = dt;
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
