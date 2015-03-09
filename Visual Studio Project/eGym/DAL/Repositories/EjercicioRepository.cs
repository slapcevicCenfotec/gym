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
            Ejercicio objMusculo = null;
            var sqlQuery = "SELECT Id, Nombre, Precio FROM Producto WHERE id = @idProducto";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idProducto", id);

            //var ds = DBAccess.ExecuteQuery(cmd);

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    var dr = ds.Tables[0].Rows[0];

            //    objEstrella = new Estrella
            //    {
            //        Id = Convert.ToInt32(dr["Id"]),
            //        Nombre = dr["Nombre"].ToString(),
            //        TemperaturaPromedio = Convert.ToDouble(dr["Tipo"])

            //    };
            //}



            return objMusculo;
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

                    ////if (_deleteItems.Count > 0)
                    ////{
                    ////    foreach (Estrella p in _deleteItems)
                    ////    {
                    ////        DeleteEstrella(p);
                    ////    }
                    ////}

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

                cmd.Parameters.Add(new SqlParameter("@pFoto", objEjercicio.PosicionInicialImg));
                //cmd.Parameters.Add(new SqlParameter("@UBICACION", objMusculo.Ubicacion));
                //cmd.Parameters.Add(new SqlParameter("@ORIGEN", objMusculo.Origen));
                //cmd.Parameters.Add(new SqlParameter("@INSERCCION", objMusculo.Inserccion));
                //cmd.Parameters.Add(new SqlParameter("@INERVACION", objMusculo.Inervacion));
                //cmd.Parameters.Add(new SqlParameter("@IRRIGACION", objMusculo.Irrigacion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarEjercicio");

            }
            catch (Exception ex)
            {

            }

        }
    }
}
