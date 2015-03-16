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
            List<TipoDePago> listaTiposDePagos = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarTipoDePago");

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaTiposDePagos = new List<TipoDePago>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoDePago auxPago = new TipoDePago();
                    auxPago.Id = Convert.ToInt32(dr["ID"]);
                    auxPago.Nombre =Convert.ToString(dr["NOMBRE"]);
                    auxPago.Monto = float.Parse(Convert.ToString(dr["Monto"]));
                    auxPago.Duracion = Convert.ToInt32(dr["DURACION"]);
                    auxPago.Habilitado = Convert.ToBoolean(dr["HABILITADO"]);
                    listaTiposDePagos.Add(auxPago);
                }
            }
            return listaTiposDePagos;
        }

        public TipoDePago GetById(int pId)
        {
            TipoDePago tipo = new TipoDePago();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@pId", pId));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarTipoDePagoPorId");

            if (ds.Tables[0].Rows.Count > 0)
            {
               tipo.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
               tipo.Nombre = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
               tipo.Monto = double.Parse(ds.Tables[0].Rows[0]["MONTO"].ToString());
               tipo.Duracion = Convert.ToInt32(ds.Tables[0].Rows[0]["DURACION"]);
               tipo.Habilitado = Convert.ToBoolean(ds.Tables[0].Rows[0]["HABILITADO"]);
            }
            return tipo;
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

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@pNombre", objTipoDePago.Nombre));
                cmd.Parameters.Add(new SqlParameter("@pMonto", objTipoDePago.Monto));
                cmd.Parameters.Add(new SqlParameter("@pDuracion", objTipoDePago.Duracion));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarTipoDePago");

            }
            catch (Exception ex)
            {

            }
        }

        private void UpdateTipoDePago(TipoDePago objTipoDePago)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objTipoDePago.Id));
                cmd.Parameters.Add(new SqlParameter("@pNombre", objTipoDePago.Nombre));
                cmd.Parameters.Add(new SqlParameter("@pMonto", objTipoDePago.Monto));
                cmd.Parameters.Add(new SqlParameter("@pDuracion", objTipoDePago.Duracion));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objTipoDePago.Habilitado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarTipoDePago");

            }
            catch (Exception ex)
            {
                
            }
           
        }

        private void DeleteTipoDePago(TipoDePago objTipoDePago)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objTipoDePago.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarTipoDePago");
            }
            catch (Exception ex)
            {

            }
        }

    }
}
