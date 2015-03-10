using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using EL;

namespace DAL.Repositories
{
    public class PermisoRepository : IRepository<Permiso>
    {

        private List<IEntity> _insertItems;


        public PermisoRepository()
        {
            _insertItems = new List<IEntity>();
        }

        public void Insert(Permiso entity)
        {
            //_insertItems.Add(entity);
        }

        public void Update(Permiso entity)
        {
            //_insertItems.Add(entity);
        }

        public void Delete(Permiso entity)
        {
            //_deleteItems.Add(entity);
        }

        public IEnumerable<Permiso> GetAll()
        {

            List<Permiso> listaPermisos = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarPermisos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                listaPermisos = new List<Permiso>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaPermisos.Add(new Permiso
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["NOMBRE"].ToString(),
                    });
                }
            }
            return listaPermisos;
        }


        public void Clear()
        {
            _insertItems.Clear();
        }


        private void InsertPermiso(Permiso objPermiso)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@PNOMBRE", objPermiso.Nombre));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarRol");

            }
            catch (Exception ex)
            {

            }

        }



        public void Save()
        {


        }

        public Permiso GetById(int id) {
            Permiso objPermiso = null;
            return objPermiso;
        }

    }
}
