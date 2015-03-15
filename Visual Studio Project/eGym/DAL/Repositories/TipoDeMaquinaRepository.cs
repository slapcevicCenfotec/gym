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
/// <summary>
/// Fecha de creación: 07/03/2015
/// Autor: Mauricio Fernández Mora
/// Fecha de modificación:  14/03/2015
/// Modificado por: Mauricio Fernández Mora
/// </summary>

namespace DAL.Repositories
{
    public class TipoDeMaquinaRepository : IRepository<TipoDeMaquina>
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
        /// Inicializa una nueva instancia de clase <ver cref="TipoDeMaquinaRepository"/>.
        /// </summary>
        public TipoDeMaquinaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        /// <summary>
        /// Inserta la entidad a la lista de _insertItems.
        /// </summary>
        /// <param name="entity">Instancia de tipo de máquina.</param>
        public void Insert(TipoDeMaquina entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        /// Inserta la entidad a la lista de _deleteItems.
        /// </summary>
        /// <param name="entity">Instancia de tipo de máquina.</param>
        public void Delete(TipoDeMaquina entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Inserta la entidad a la lista de _updateItems.
        /// </summary>
        /// <param name="entity">Instancia de tipo de máquina.</param>
        public void Update(TipoDeMaquina entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// Lista cada una de las instancias de tipo de máquina.
        /// </summary>
        /// <returns>
        /// Devuelve una lista de tipo IEnumerable<TipoDeMaquina>.
        /// </returns>
        public IEnumerable<TipoDeMaquina> GetAll()
        {

            List<TipoDeMaquina> listaTiposDeMaquinas = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarTiposDeMaquinas");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaTiposDeMaquinas = new List<TipoDeMaquina>();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        listaTiposDeMaquinas.Add(new TipoDeMaquina
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            Foto = (byte[])dr["FOTO"],
                            Nombre = dr["NOMBRE"].ToString(),
                            Descripcion = dr["DESCRIPCION"].ToString(),
                            Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                            Cantidad = Convert.ToInt32(dr["CANTIDAD_MAQUINAS"]),

                        });
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return listaTiposDeMaquinas;
        }

        /// <summary>
        /// Obtiene una instancia de tipo de máquina por su Id.
        /// </summary>
        /// <param name="pId">Id del tipo de máquina.</param>
        /// <returns>
        /// Devuelve la instancia de tipo de máquina.
        /// </returns>
        public TipoDeMaquina GetById(int pId)
        {
            TipoDeMaquina tipoDeMaquina = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@pId", pId);

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ObtenerTipoMaquinaPorId");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        tipoDeMaquina = new TipoDeMaquina
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            Foto = (byte[])dr["FOTO"],
                            Nombre = dr["NOMBRE"].ToString(),
                            Descripcion = dr["DESCRIPCION"].ToString(),
                            Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                        };
                    }
                }

            }
            catch(Exception ex)
            {

            }

            return tipoDeMaquina;
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
                        foreach (TipoDeMaquina objTipoDeMaquina in _insertItems)
                        {
                            InsertTipoDeMaquina(objTipoDeMaquina);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (TipoDeMaquina p in _updateItems)
                        {
                            UpdateTipoDeMaquina(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (TipoDeMaquina p in _deleteItems)
                        {
                            DeleteTipoDeMaquina(p);
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

        /// <summary>
        /// Registra una instancia de tipo de máquina.
        /// </summary>
        /// <param name="objTipoDeMaquina">Objeto tipo de máquina.</param>
        private void InsertTipoDeMaquina(TipoDeMaquina objTipoDeMaquina)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@pFoto", objTipoDeMaquina.Foto));
                cmd.Parameters.Add(new SqlParameter("@pNombre", objTipoDeMaquina.Nombre));
                cmd.Parameters.Add(new SqlParameter("@pDescripcion", objTipoDeMaquina.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objTipoDeMaquina.Habilitado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarTipoDeMaquina");

            }
            catch (Exception ex)
            {

            }

        }

        /// <summary>
        /// Modifica una instancia de tipo de máquina.
        /// </summary>
        /// <param name="objTipoDeMaquina">Objeto tipo de máquina.</param>
        private void UpdateTipoDeMaquina(TipoDeMaquina objTipoDeMaquina)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objTipoDeMaquina.Id));
                cmd.Parameters.Add(new SqlParameter("@pFoto", objTipoDeMaquina.Foto));
                cmd.Parameters.Add(new SqlParameter("@pNombre", objTipoDeMaquina.Nombre));
                cmd.Parameters.Add(new SqlParameter("@pDescripcion", objTipoDeMaquina.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objTipoDeMaquina.Habilitado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarTipoDeMaquina");

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Elimina una instancia de tipo de máquina.
        /// </summary>
        /// <param name="objTipoDeMaquina">Objeto de tipo de máquina.</param>
        private void DeleteTipoDeMaquina(TipoDeMaquina objTipoDeMaquina)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objTipoDeMaquina.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarTipoDeMaquina");

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
