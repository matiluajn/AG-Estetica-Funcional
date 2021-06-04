using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AGEsteticaFuncinal
{
    class ClientesMetodo : Conexion
    {
        public DataTable consultar()
        {
            string sqlstr = "select * from Cliente";

            var da = new SqlDataAdapter(sqlstr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }
        public void AltaCliente(Cliente al)
        {
            try
            {
                var set = "set dateformat dmy INSERT INTO Cliente(DNI,nombre,apellido,fechaNacimiento,celular,telefono,calle,numero,barrio,cp,email,derivacionMedica,diagnostico,medicacion,lesion,FechaAlta) VALUES ('"
                    + al.dni + "', '" + al.nombre + "','" + al.apellido+ "', '"
                    + al.fechaNacimiento + "', '" + al.celular + "', '" + al.telefono + "','" + al.calle + "', '"
                    + al.numero + "', '" + al.barrio + "', '" + al.cp + "', '" + al.email + "','" + al.derivacionMedica + "','" + al.diagnostico + "','" + al.medicacion +
                    "','" + al.lesion + "','" + al.fechaAlta + "') ";

                SqlCommand con = new SqlCommand(set, conectar());
                con.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public void ModificarCliente (Cliente cl)
        {
            try
            {
                var sel = "set dateformat dmy UPDATE cliente set DNI= '" +cl.dni  + "',  nombre= '" + cl.nombre
                    + "',apellido = '" + cl.apellido + "' ,fechaNacimiento = '" + cl.fechaNacimiento
                    + "',celular = '" + cl.celular + "', telefono = '" + cl.telefono + "', calle = '" + cl.calle + "', numero = '" + cl.numero
                    + "',barrio = '" + cl.barrio + "', cp= '" + cl.cp + "', email = '" + cl.email + "', derivacionMedica = '" + cl.derivacionMedica 
                    + "',diagnostico = '" + cl.diagnostico + "',medicacion = '" + cl.medicacion + "',lesion = '" + cl.lesion 
                    + "',FechaAlta = '" + cl.fechaAlta + "' where dni= '" + cl.dni + "'";
                SqlCommand con = new SqlCommand(sel, conectar());

                con.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }


        }

        public Boolean borrarCliente(string DNI)
        {
            try
            {

                var sel = "delete   from  cliente where dni = '" + DNI + "'";
                SqlCommand com = new SqlCommand(sel, conectar());

                //com.ExecuteNonQuery();
                var i = com.ExecuteNonQuery();
                if (i == 0) return false;

                return true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return false;

            }
        }
    }
}
