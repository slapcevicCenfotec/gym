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
    public class RolRepository : IRepository<Rol>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _updateItems;
        private List<IEntity> _deleteItems;

        public RolRepository()
        {
            _insertItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
        }

        public void Insert(Rol entity)
        {
            _insertItems.Add(entity);
        }

        public void Update(Rol entity)
        {
            _updateItems.Add(entity);
        }
        public void Delete(Rol entity)
        {
            _deleteItems.Add(entity);
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Rol objRol in _insertItems)
                        {
                            InsertarRolesPorPermiso(InsertRol(objRol),objRol.ListaPermisos);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Rol objRol in _updateItems)
                        {
                          ModificarRolesPorPermiso(UpdateRol(objRol),objRol.ListaPermisos);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Rol objRol in _deleteItems)
                        {
                            DeleteRol(objRol);
                        }
                    }

                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {

                }
                catch (ApplicationException ex)
                {

                }
                finally
                {
                    Clear();
                }

            }
        }

        public void Clear()
        {
            _insertItems.Clear();
        }

        private int InsertRol(Rol objRol)
        {
            DataSet ds;
            ds = null;
            int id;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@PNOMBRE", objRol.Nombre));
                cmd.Parameters.Add(new SqlParameter("@PDESCRIPCION", objRol.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@NEWIDENTITY", 1));


                 ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarRol");

            }
            catch (Exception ex)
            {

            }
            
            id = ds.Tables[0].Rows[0].Field<int>("Id");
            return id;

        }



        public void InsertarRolesPorPermiso(int pIdRol,List<Permiso> listaRolesXPermiso) {

            foreach (Permiso permiso in listaRolesXPermiso)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.Add(new SqlParameter("@ID_ROL", pIdRol));
                    cmd.Parameters.Add(new SqlParameter("@ID_PERMISO", permiso.Id));

                    DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarPermisoRol");

                }
                catch (Exception ex)
                {

                }
                
            }

        
        }

        public void ModificarRolesPorPermiso(int pIdRol, List<Permiso> listaRolesXPermiso)
        {
            SqlCommand cmd;
            DataSet ds;
            try
            {

                cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@ID_ROL", pIdRol));
                ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarPermisosRoles");

                foreach (Permiso permiso in listaRolesXPermiso)
                {

                cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@ID_ROL", pIdRol));
                cmd.Parameters.Add(new SqlParameter("@ID_PERMISO", permiso.Id));

                ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarPermisoRol");

                }
            }
            
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception
            }
            catch (Exception ex)
            {
                //logear la excepcion a la bd con un Exception

            }
        }



        

        private int UpdateRol(Rol objRol)
        {
            int id;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@PID", objRol.Id));
                cmd.Parameters.Add(new SqlParameter("@PNOMBRE", objRol.Nombre));
                cmd.Parameters.Add(new SqlParameter("@PDESCRIPCION", objRol.Descripcion));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarRol");

            }
            catch (Exception ex)
            {

            }
            id = objRol.Id;
            return id;
        }

        private void DeleteRol(Rol objRol)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@ID_ROL", objRol.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarRol");

            }
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception
            }
            catch (Exception ex)
            {
                //logear la excepcion a la bd con un Exception

            }
        }

        public IEnumerable<Rol> GetAll()
        {

            List<Rol> listaRoles = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarRoles");
            if (ds.Tables[0].Rows.Count > 0)
            {
                listaRoles = new List<Rol>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaRoles.Add(new Rol
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["NOMBRE"].ToString(),
                        Descripcion = dr["DESCRIPCION"].ToString(),
                        Habilitado = Convert.ToBoolean(dr["HABILITADO"])
                    });
                }
            }
            return listaRoles;
        }

        public Rol GetById(int id)
        {
            Rol objRol = null;
            Permiso objPermiso = null;
            List<Permiso> listaPermisos = new List<Permiso>();
            var sqlQuery = "SELECT ID,NOMBRE,DESCRIPCION,HABILITADO FROM T_ROL WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@ID", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objRol = new Rol
                {
                    Id = Convert.ToInt32(dr["ID"]),
                    Nombre = dr["NOMBRE"].ToString(),
                    Descripcion = dr["DESCRIPCION"].ToString(),
                    Habilitado = Convert.ToBoolean(dr["HABILITADO"])
                };


                 sqlQuery = "select A.ID_PERMISO AS ID,B.NOMBRE from [dbo].[T_PERMISO_ROL] A INNER JOIN T_PERMISO B ON A.ID_PERMISO = B.ID where A.ID_ROL = @ID_ROL";
                 cmd = new SqlCommand(sqlQuery);
                 cmd.Parameters.AddWithValue("@ID_ROL", objRol.Id);

                 ds = null;
                 ds = DBAccess.ExecuteQuery(cmd);

                 if (ds.Tables[0].Rows.Count > 0)
                 {
                     foreach (DataRow datarow in ds.Tables[0].Rows) {
                         objPermiso = new Permiso
                         {
                             Id = Convert.ToInt32(datarow["ID"]),
                             Nombre = datarow["NOMBRE"].ToString()
                         };
                         listaPermisos.Add(objPermiso);
                     }
                    
                 }
                 objRol.ListaPermisos = listaPermisos;
            }
            return objRol;
        }

    }
}
