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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var usu = new metodoLogin();
            var usuario = txtBoxUsuario.Text;
            var contra = txtBoxContraseña.Text;
            dt = usu.ConsultarLogin(usuario, contra);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Ingreso Correcto");
                var menu = new menuPrincipal();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Error en Usuario o Contraseña");
            }
        }
    }
}
