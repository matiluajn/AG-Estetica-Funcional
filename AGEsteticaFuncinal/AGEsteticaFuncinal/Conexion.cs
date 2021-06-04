using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AGEsteticaFuncinal
{
    class Conexion
    {
        private SqlConnection sCon = new SqlConnection();
        private string con = @"Data Source=LPINC;Integrated Security=SSPI;Initial Catalog=AGEsteticaFuncional";

        //Data Source = Server Name SQL
        //Catalog = Nombre Base de datos SQL

        public SqlConnection conectar()
        {
            try
            {
                sCon = new SqlConnection(con);
                if (sCon.State.Equals(ConnectionState.Open))
                {
                    sCon.Close();
                }
                else
                {
                    sCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return sCon;
        }
    }
}

