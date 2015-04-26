using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EL;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Transactions;

namespace DAL.Repositories
{
    public class ProgramaRepository : IRepository<Programa>
    {
        /// <summary>
        /// Lista de entidades para registrar.
        /// </summary>
        private List<IEntity> _insertItems;

        /// <summary>
        /// Lista de entidades para eliminar.
        /// </summary>
        private List<IEntity> _deleteItems;

        /// <summary>
        /// Lista de entidades para modificar.
        /// </summary>
        private List<IEntity> _updateItems;

        /// <summary>
        /// Inicializa una nueva instancia de clase <ver cref="ProgramaRepository"/>.
        /// </summary>
        public ProgramaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Programa entity)
        {
            _insertItems.Add(entity);
        }
        public void Delete(Programa entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Programa entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<Programa> GetAll()
        {
            List<Programa> listaProgramas = null;

            SqlCommand cmd = new SqlCommand();

            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarProgramas");

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaProgramas = new List<Programa>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaProgramas.Add(new Programa
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        IdUsuario = Convert.ToInt32(dr["USUARIO"]),
                        TipoAcondicionamiento = new TipoAcondicionamiento
                        {
                            Id = Convert.ToInt32(dr["ID_TIPO_ACONDICIONAMIENTO"]),
                            Nombre = Convert.ToString(dr["NOMBRE_TIPO_ACONDICIONAMIENTO"])
                        },
                        Estado = Convert.ToInt32(dr["ESTADO"]),
                    });
                }
            }

            return listaProgramas;
        }

        public Programa GetById(int pId)
        {

            Programa programa = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@pId", pId);

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ObtenerProgramaPorId");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        programa = new Programa
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            IdUsuario = Convert.ToInt32(dr["USUARIO"]),
                            TipoAcondicionamiento = new TipoAcondicionamiento{
                                Id = Convert.ToInt32(dr["ID_TIPO_ACONDICIONAMIENTO"]),
                                Nombre = Convert.ToString(dr["NOMBRE_TIPO_ACONDICIONAMIENTO"])
                            },
                            Estado = Convert.ToInt32(dr["ESTADO"]),
                        };
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return programa;
        }

        /// <summary>
        /// Guarda los cambios.
        /// </summary>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Programa objPrograma in _insertItems)
                        {
                            InsertPrograma(objPrograma);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Programa p in _updateItems)
                        {
                            UpdatePrograma(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Programa p in _deleteItems)
                        {
                            DeletePrograma(p);
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

        /// <summary>
        /// Limpia las listas de insert, delete y update.
        /// </summary>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        public Programa GetLast()
        {

            Programa programa = null;

            SqlCommand cmd = new SqlCommand();

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ObtenerUltimoPrograma");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        programa = new Programa
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            IdUsuario = Convert.ToInt32(dr["USUARIO"]),
                            TipoAcondicionamiento = new TipoAcondicionamiento
                            {
                                Id = Convert.ToInt32(dr["ID_TIPO_ACONDICIONAMIENTO"]),
                                Nombre = Convert.ToString(dr["NOMBRE_TIPO_ACONDICIONAMIENTO"])
                            },
                            Estado = Convert.ToInt32(dr["ESTADO"]),
                        };
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return programa;
        }

        private void InsertPrograma(Programa objPrograma)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@idUsuario", objPrograma.IdUsuario));
                cmd.Parameters.Add(new SqlParameter("@idTipoAcondicionamiento", objPrograma.TipoAcondicionamiento));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_GenerarProgramaEjercicios");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdatePrograma(Programa objPrograma)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objPrograma.Id));
                cmd.Parameters.Add(new SqlParameter("@pIdUsuario", objPrograma.IdUsuario));
                cmd.Parameters.Add(new SqlParameter("@pTipoAcondicionamiento", objPrograma.TipoAcondicionamiento));
                cmd.Parameters.Add(new SqlParameter("@pEstado", objPrograma.Estado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarPrograma");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeletePrograma(Programa objPrograma)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objPrograma.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarPrograma");

            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }

    }
}
