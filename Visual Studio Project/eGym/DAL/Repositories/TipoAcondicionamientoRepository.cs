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
    public class TipoAcondicionamientoRepository : IRepository<TipoAcondicionamiento>
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
        /// Inicializa una nueva instancia de clase <ver cref="TipoAcondicionamientoRepository"/>.
        /// </summary>
        public TipoAcondicionamientoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(TipoAcondicionamiento entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(TipoAcondicionamiento entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(TipoAcondicionamiento entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<TipoAcondicionamiento> GetAll()
        {
            List<TipoAcondicionamiento> listaTipoAcondicionamientos = null;

            SqlCommand cmd = new SqlCommand();

            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarTipoAcondicionamientos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaTipoAcondicionamientos = new List<TipoAcondicionamiento>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaTipoAcondicionamientos.Add(new TipoAcondicionamiento
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["NOMBRE"].ToString(),
                    });
                }
            }


            return listaTipoAcondicionamientos;
        }

        /// <summary>
        /// Obtiene una instancia de máquina por su Id.
        /// </summary>
        /// <param name="pId">Id de la máquina.</param>
        /// <returns>
        /// Devuelve la instancia de la máquina.
        /// </returns>
        public TipoAcondicionamiento GetById(int pId)
        {

            TipoAcondicionamiento tipoAcondicionamiento = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@pId", pId);

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ObtenerTipoAcondicionamientoPorId");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        tipoAcondicionamiento = new TipoAcondicionamiento
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["NOMBRE"].ToString(),
                        };
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return tipoAcondicionamiento;
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
                        foreach (TipoAcondicionamiento objTipoAcondicionamiento in _insertItems)
                        {
                            InsertTipoAcondicionamiento(objTipoAcondicionamiento);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (TipoAcondicionamiento p in _updateItems)
                        {
                            UpdateTipoAcondicionamiento(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (TipoAcondicionamiento p in _deleteItems)
                        {
                            DeleteTipoAcondicionamiento(p);
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

        private void InsertTipoAcondicionamiento(TipoAcondicionamiento objTipoAcondicionamiento)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@pNombre", objTipoAcondicionamiento.Nombre));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarTipoAcondicionamiento");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateTipoAcondicionamiento(TipoAcondicionamiento objTipoAcondicionamiento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objTipoAcondicionamiento.Id));
                cmd.Parameters.Add(new SqlParameter("@pNumeroActivo", objTipoAcondicionamiento.Nombre));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarTipoAcondicionamiento");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteTipoAcondicionamiento(TipoAcondicionamiento objTipoAcondicionamiento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objTipoAcondicionamiento.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarTipoAcondicionamiento");

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
