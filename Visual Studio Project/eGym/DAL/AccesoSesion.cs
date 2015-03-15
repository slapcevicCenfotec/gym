using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class AccesoSesion
    {
        public Usuario iniciarSesion(String correo, String contrasena)
        {
            UnitOfWork uow = new UnitOfWork();
            Usuario usuario = null;
            SqlCommand cmd = new SqlCommand();
            byte[] foto = null;
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
                        int idRol = Convert.ToInt16(dataRow["ROL_ID"].ToString());
                        if (dataRow["FOTOGRAFIA"] != System.DBNull.Value)
                        {
                            foto = (byte[])dataRow["FOTOGRAFIA"];
                        }
                        Rol rol = uow.RolRepository.GetById(idRol);
                        usuario = new Usuario() { Nombre = nombre, Apellido = apellido, Rol = rol, Fotografia = foto };
                    }
                }
            }
            return usuario;
        }
    }
}
