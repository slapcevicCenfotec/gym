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
    public class MaquinaRepository : IRepository<Maquina>
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
        public MaquinaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        /// <summary>
        /// Inserta la entidad a la lista de _insertItems.
        /// </summary>
        /// <param name="entity">Instancia de máquina.</param>
        public void Insert(Maquina entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        /// Inserta la entidad a la lista de _deleteItems.
        /// </summary>
        /// <param name="entity">Instancia de máquina.</param>
        public void Delete(Maquina entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Inserta la entidad a la lista de _updateItems.
        /// </summary>
        /// <param name="entity">Instancia de máquina.</param>
        public void Update(Maquina entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// Lista cada una de las instancias de máquina.
        /// </summary>
        /// <returns>
        /// Devuelve una lista de tipo IEnumerable<Maquina>.
        /// </returns>
        public IEnumerable<Maquina> GetAll()
        {
            List<Maquina> listaMaquinas = null;

            SqlCommand cmd = new SqlCommand();

              DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarMaquinas");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaMaquinas = new List<Maquina>();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        listaMaquinas.Add(new Maquina
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            NumeroActivo = dr["NUMERO_ACTIVO"].ToString(),
                            NumeroMaquina = dr["NUMERO_MAQUINA"].ToString(),
                            Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                            NombreTipoMaquina = dr["NOMBRE"].ToString(),
                            TipoDeMaquina = Convert.ToInt32(dr["TIPO_MAQUINA"]),
                        });
                    }
                }
            

            return listaMaquinas;
        }

        /// <summary>
        /// Obtiene una instancia de máquina por su Id.
        /// </summary>
        /// <param name="pId">Id de la máquina.</param>
        /// <returns>
        /// Devuelve la instancia de la máquina.
        /// </returns>
        public Maquina GetById(int pId)
        {

            Maquina maquina = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@pId", pId);

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_MaquinaPorId");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        maquina = new Maquina
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            NumeroActivo = dr["NUMERO_ACTIVO"].ToString(),
                            NumeroMaquina = dr["NUMERO_MAQUINA"].ToString(),
                            Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                        };
                    }
                }
            }
                catch(Exception ex)
                {

                }

            return maquina;
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
                        foreach (Maquina objMaquina in _insertItems)
                        {
                            InsertMaquina(objMaquina);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Maquina p in _updateItems)
                        {
                            UpdateMaquina(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Maquina p in _deleteItems)
                        {
                            DeleteMaquina(p);
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
        /// Registra una instancia de máquina.
        /// </summary>
        /// <param name="objMaquina">Objeto maquina.</param>
        private void InsertMaquina(Maquina objMaquina)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@pNumeroActivo", objMaquina.NumeroActivo));
                cmd.Parameters.Add(new SqlParameter("@pNumeroMaquina", objMaquina.NumeroMaquina));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objMaquina.Habilitado));
                cmd.Parameters.Add(new SqlParameter("@pIdTipoDeMaquina", objMaquina.TipoDeMaquina));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarMaquina");

            }
            catch (Exception ex)
            {

            }

        }

        /// <summary>
        /// Modifica una instancia de máquina.
        /// </summary>
        /// <param name="objMaquina">Objecto maquina.</param>
        private void UpdateMaquina(Maquina objMaquina)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objMaquina.Id));
                cmd.Parameters.Add(new SqlParameter("@pNumeroActivo", objMaquina.NumeroActivo));
                cmd.Parameters.Add(new SqlParameter("@pNumeroMaquina", objMaquina.NumeroMaquina));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objMaquina.Habilitado));
                cmd.Parameters.Add(new SqlParameter("@pIdTipoDeMaquina", objMaquina.TipoDeMaquina));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarMaquina");

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Elimina una instancia de máquina.
        /// </summary>
        /// <param name="objMaquina">Objecto maquina.</param>
        private void DeleteMaquina(Maquina objMaquina)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objMaquina.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarMaquina");

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
