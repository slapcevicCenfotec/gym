using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    class UsuarioRepository : IRepository<Usuario>
    {
        public void Insert(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            List<Usuario> lista = null;
            SqlCommand cmd = new SqlCommand();
            DataSet dataSet = DAL.DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarUsuarios");

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                lista = new List<Usuario>();
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    lista.Add(new Usuario()
                    {
                        Id = Convert.ToInt32(dataRow["ID"]),
                        Identificacion = dataRow["IDENTIFICACION"].ToString(),
                        Nombre = dataRow["NOMBRE"].ToString(),
                        Alias = dataRow["ALIAS"].ToString(),
                        FechaIngreso = Convert.ToDateTime(dataRow["FECHA_INGRESO"])
                    });
                }
            }
            return lista;
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
