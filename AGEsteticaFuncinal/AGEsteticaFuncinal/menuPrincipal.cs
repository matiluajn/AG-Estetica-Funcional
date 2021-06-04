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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = new frmProveedores();
            this.Hide();
            menu.Show();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = new frmCliente();
            this.Hide();
            menu.Show();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = new frmServicios();
            this.Hide();
            menu.Show();
        }

        private void mercaderiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = new frmproductos();
            this.Hide();
            menu.Show();
        }
    }
}
