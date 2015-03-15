using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Repositories
{
    public class EjercicioRepository:IRepository<Ejercicio>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public EjercicioRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Ejercicio entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Ejercicio entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Ejercicio entity)
        {
            _updateItems.Add(entity);
        }
        public IEnumerable<Ejercicio> GetAll()
        {

            List<Ejercicio> listaEjercicios= null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarEjercicio");

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaEjercicios = new List<Ejercicio>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaEjercicios.Add(new Ejercicio
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["NOMBRE"].ToString(),
                        Alias = dr["ALIAS"].ToString(),
                        PosicionInicial = dr["POSICION_INICIAL"].ToString(),
                        PosicionFinal = dr["POSICION_FINAL"].ToString(),
                        ErroresComunes = dr["ERRORES_COMUNES"].ToString(),
                        Descripcion = dr["DESCRIPCION"].ToString(),
                    });
                }
            }

            return listaEjercicios;
        }

      
        public Ejercicio GetById(int id)
        {
            Ejercicio objEjercicio = null;
            var sqlQuery = "SELECT [POSICION_INICIAL_IMG] , [POSICION_FINAL_iMG] FROM [dbo].[T_EJERCICIO] WHERE [ID] = @idEjercicio POSICION_INICIAL_IMG is not null and POSICION_INICIAL_IMG is not null ";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idEjercicio", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objEjercicio = new Ejercicio
                {
                    PosicionInicialImg = (byte[])dr["POSICION_INICIAL_IMG"],
                    PosicionFinalImg = (byte[])dr["POSICION_INICIAL_IMG"] ,

                };
            }

            return objEjercicio;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Ejercicio objEjercicio in _insertItems)
                        {
                            InsertEjercicio(objEjercicio);
                        }
                    }

                    //if (_updateItems.Count > 0)
                    //{
                    //    foreach (Musculo objEstrella in _updateItems)
                    //    {
                    //        UpdateMusculo(objEstrella);
                    //    }
                    //}

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Ejercicio p in _deleteItems)
                        {
                            DeleteEjercicio(p);
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
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        private void InsertEjercicio(Ejercicio objEjercicio)
        {
   

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@NOMBRE", objEjercicio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ALIAS", objEjercicio.Alias));
                cmd.Parameters.Add(new SqlParameter("@POSICION_INICIAL", objEjercicio.PosicionInicial));
                cmd.Parameters.Add(new SqlParameter("@POSICION_INICIAL_IMG", objEjercicio.PosicionInicialImg));
                cmd.Parameters.Add(new SqlParameter("@POSICION_FINAL", objEjercicio.PosicionFinal));
                cmd.Parameters.Add(new SqlParameter("@POSICION_FINAL_IMG", objEjercicio.PosicionFinalImg));
                cmd.Parameters.Add(new SqlParameter("@ERRORES_COMUNES", objEjercicio.ErroresComunes));
                cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", objEjercicio.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@ID_MUSCULO_PRINCIPAL", objEjercicio.IdMusculoPrincipal));
                cmd.Parameters.Add(new SqlParameter("@LISTA_MUSCULOS_SECUNDARIOS", objEjercicio.MusculosSecundarios));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarEjercicio");

            }
            catch (Exception ex)
            {

            }

        }

        private void DeleteEjercicio(Ejercicio objEjercicio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Id", objEjercicio.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarEjercicio");

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
    }
}
