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
    public class EjercicioProgramaRepository : IRepository<EjercicioPrograma>
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
        /// Inicializa una nueva instancia de clase <ver cref="EjercicioProgramaRepository"/>.
        /// </summary>
        public EjercicioProgramaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(EjercicioPrograma entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(EjercicioPrograma entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(EjercicioPrograma entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<EjercicioPrograma> GetAll()
        {
            //No se necesita
            return null;
        }

        public IEnumerable<EjercicioPrograma> GetByPrograma(int idPrograma)
        {
            List<EjercicioPrograma> listaEjercicioProgramas = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idPrograma", idPrograma);
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarEjerciciosPorPrograma");

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaEjercicioProgramas = new List<EjercicioPrograma>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaEjercicioProgramas.Add(new EjercicioPrograma
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Series = Convert.ToInt32(dr["SERIES"]),
                        Repeticiones = Convert.ToInt32(dr["REPETICIONES"]),
                        Peso = float.Parse(Convert.ToString(dr["PESO"])),
                        Semana = Convert.ToInt32(dr["SEMANA"]),
                        Ejercicio = new Ejercicio { Id = Convert.ToInt32(dr["EJERCICIO"]), Nombre = Convert.ToString(dr["NOMBRE_EJERCICIO"]) },
                        TipoMedida = new TipoMedida { Id = Convert.ToInt32(dr["ID_TIPO_MEDIDA"]), Nombre = Convert.ToString(dr["NOMBRE_TIPO_MEDIDA"]) }
                    });
                }
            }


            return listaEjercicioProgramas;
        }

        public EjercicioPrograma GetById(int pId)
        {
            //No se necesita
            return null;
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
                        foreach (EjercicioPrograma objEjercicioPrograma in _insertItems)
                        {
                            InsertEjercicioPrograma(objEjercicioPrograma);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (EjercicioPrograma p in _updateItems)
                        {
                            UpdateEjercicioPrograma(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (EjercicioPrograma p in _deleteItems)
                        {
                            DeleteEjercicioPrograma(p);
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

        private void InsertEjercicioPrograma(EjercicioPrograma objEjercicioPrograma)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@series", objEjercicioPrograma.Series));
                cmd.Parameters.Add(new SqlParameter("@repeticiones", objEjercicioPrograma.Repeticiones));
                cmd.Parameters.Add(new SqlParameter("@peso", objEjercicioPrograma.Peso));
                cmd.Parameters.Add(new SqlParameter("@semana", objEjercicioPrograma.Semana));
                cmd.Parameters.Add(new SqlParameter("@ejercicio", objEjercicioPrograma.Ejercicio.Id));
                cmd.Parameters.Add(new SqlParameter("@tipoMedida", objEjercicioPrograma.TipoMedida.Id));
                cmd.Parameters.Add(new SqlParameter("@programa", objEjercicioPrograma.IdPrograma));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarEjercicioPrograma");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateEjercicioPrograma(EjercicioPrograma objEjercicioPrograma)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id", objEjercicioPrograma.Series));
                cmd.Parameters.Add(new SqlParameter("@series", objEjercicioPrograma.Series));
                cmd.Parameters.Add(new SqlParameter("@repeticiones", objEjercicioPrograma.Repeticiones));
                cmd.Parameters.Add(new SqlParameter("@peso", objEjercicioPrograma.Peso));
                cmd.Parameters.Add(new SqlParameter("@semana", objEjercicioPrograma.Semana));
                cmd.Parameters.Add(new SqlParameter("@ejercicio", objEjercicioPrograma.Ejercicio.Id));
                cmd.Parameters.Add(new SqlParameter("@tipoMedida", objEjercicioPrograma.TipoMedida.Id));
                cmd.Parameters.Add(new SqlParameter("@programa", objEjercicioPrograma.IdPrograma));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarEjercicioPrograma");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteEjercicioPrograma(EjercicioPrograma objEjercicioPrograma)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objEjercicioPrograma.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarEjercicioPrograma");

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
