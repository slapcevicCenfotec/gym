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
    public class TipoDePagoRepository : IRepository<TipoDePago>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public TipoDePagoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(TipoDePago entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(TipoDePago entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(TipoDePago entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<TipoDePago> GetAll()
        {


            return new List<TipoDePago>();
            //List<TipoDeMaquina> listaTiposDeMaquinas = null;

            //SqlCommand cmd = new SqlCommand();
            //DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarTiposDeMaquinas");



            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    listaTiposDeMaquinas = new List<TipoDeMaquina>();

            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //        listaTiposDeMaquinas.Add(new TipoDeMaquina
            //        {
            //            Id = Convert.ToInt32(dr["ID"]),
            //            //Foto = Convert.ToByte(["FOTO"]),
            //            Nombre = dr["NOMBRE"].ToString(),
            //            Descripcion = dr["DESCRIPCION"].ToString(),
            //            Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
            //        });
            //    }
            //}

            //return listaTiposDeMaquinas;
        }

        public TipoDePago GetById(int id)
        {
            return new TipoDePago();
            //TipoDeMaquina objTipoDeMaquina = null;
            //var sqlQuery = "SELECT Id, Nombre, Masa, TemperaturaMedia, DuracionDeUnDia FROM TipoDeMaquinas WHERE ID = @id ";
            //SqlCommand cmd = new SqlCommand(sqlQuery);
            //cmd.Parameters.AddWithValue("@id", id);

            //var ds = DBAccess.ExecuteQuery(cmd);

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    var dr = ds.Tables[0].Rows[0];

            //    objTipoDeMaquina = new TipoDeMaquina
            //    {
            //        Id = Convert.ToInt32(dr["ID"]),
            //        // Foto = Convert.ToByte(["FOTO"]),
            //        Nombre = dr["NOMBRE"].ToString(),
            //        Descripcion = dr["DESCRIPCION"].ToString(),
            //        Habilitado = Convert.ToBoolean(dr["HABILITADO"]),

            //    };
            //}

            //return objTipoDeMaquina;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (TipoDePago objTipoDePago in _insertItems)
                        {
                            InsertTipoDePago(objTipoDePago);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (TipoDePago p in _updateItems)
                        {
                            UpdateTipoDePago(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (TipoDePago p in _deleteItems)
                        {
                            DeleteTipoDePago(p);
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

        private void InsertTipoDePago(TipoDePago objTipoDePago)
        {

            //try
            //{
            //    SqlCommand cmd = new SqlCommand();

            //    //cmd.Parameters.Add(new SqlParameter("@foto", objTipoDeMaquina.Foto));
            //    cmd.Parameters.Add(new SqlParameter("@nombre", objTipoDeMaquina.Nombre));
            //    cmd.Parameters.Add(new SqlParameter("@descripcion", objTipoDeMaquina.Descripcion));
            //    cmd.Parameters.Add(new SqlParameter("@habilitado", objTipoDeMaquina.Habilitado));

            //    DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "paInsertarTipoDeMaquina");

            //}
            //catch (Exception ex)
            //{

            //}

        }

        private void UpdateTipoDePago(TipoDePago objTipoDePago)
        {
           
        }

        private void DeleteTipoDePago(TipoDePago objTipoDePago)
        {

        }

    }
}
