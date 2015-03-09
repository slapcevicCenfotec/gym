using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class AccesoSesion
    {
        public Usuario iniciarSesion(String correo, String contrasena)
        {
            Usuario usuario = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@nombre_usuario", correo));
            cmd.Parameters.Add(new SqlParameter("@contrasenna", contrasena));

            DataSet dataSet = DAL.DBAccess.ExecuteSPWithDS(ref cmd, "SP_IniciarSesion");

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    String nombre = dataRow["NOMBRE"].ToString();
                    if (nombre == "0")
                    {
                        usuario = null;
                    }
                    else
                    {
                        String apellido = dataRow["APELLIDO"].ToString();
                        String idRol = dataRow["ROL_ID"].ToString();
                        String nombreRol = dataRow["ROL"].ToString();
                        usuario = new Usuario(nombre, apellido);
                    }
                }

            }
            return usuario;
        }
    }
}
