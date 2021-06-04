using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace AGEsteticaFuncinal
{
    class metodoLogin : Conexion
    {

        public DataTable ConsultarLogin(string usu, string contra)
        {
            string sqlStr = "select usuario, contraseña from login where usuario = '" + usu + "' and contraseña = '" +
                            contra + "'";

            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;

        }
    }
}
