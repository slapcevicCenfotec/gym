using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using System.Data.SqlClient;
using System.Transactions;
using System.Data;

namespace DAL.Repositories
{
    public class MusculoRepository : IRepository<Musculo>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public MusculoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Musculo entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Musculo entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Musculo entity)
        {
            _updateItems.Add(entity);
        }


        public IEnumerable<Musculo> GetAll()
        {
            List<Musculo> listaMusculos = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarMusculo");

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaMusculos = new List<Musculo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaMusculos.Add(new Musculo
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["NOMBRE"].ToString(),
                        Ubicacion = dr["UBICACION"].ToString(),
                        Origen = dr["ORIGEN"].ToString(),
                        Inserccion = dr["INSERCCION"].ToString(),
                        Inervacion = dr["INERVACION"].ToString(),
                        Irrigacion = dr["IRRIGACION"].ToString()
                    });
                }
            }

            return listaMusculos;
        }


        public Musculo GetById(int id)
        {
            Musculo objMusculo = null;
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
                        foreach (Musculo objMusculo in _insertItems)
                        {
                            InsertMusculo(objMusculo);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Musculo objMusculo in _updateItems)
                        {
                            UpdateMusculo(objMusculo);
                        }
                    }

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

        private void InsertMusculo(Musculo objMusculo)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@NOMBRE", objMusculo.Nombre));
                cmd.Parameters.Add(new SqlParameter("@UBICACION", objMusculo.Ubicacion));
                cmd.Parameters.Add(new SqlParameter("@ORIGEN", objMusculo.Origen));
                cmd.Parameters.Add(new SqlParameter("@INSERCCION", objMusculo.Inserccion));
                cmd.Parameters.Add(new SqlParameter("@INERVACION", objMusculo.Inervacion));
                cmd.Parameters.Add(new SqlParameter("@IRRIGACION", objMusculo.Irrigacion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarMusculo");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateMusculo(Musculo objMusculo)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@ID", objMusculo.Id));
                cmd.Parameters.Add(new SqlParameter("@NOMBRE", objMusculo.Nombre));
                cmd.Parameters.Add(new SqlParameter("@UBICACION", objMusculo.Ubicacion));
                cmd.Parameters.Add(new SqlParameter("@ORIGEN", objMusculo.Origen));
                cmd.Parameters.Add(new SqlParameter("@INSERCCION", objMusculo.Inserccion));
                cmd.Parameters.Add(new SqlParameter("@INERVACION", objMusculo.Inervacion));
                cmd.Parameters.Add(new SqlParameter("@IRRIGACION", objMusculo.Irrigacion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarMusculo");

            }
            catch (Exception ex)
            {

            }

        }
    }
}
