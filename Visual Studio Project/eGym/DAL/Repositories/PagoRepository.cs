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
    public class PagoRepository : IRepository<Pago>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public PagoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Pago entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Pago entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Pago entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<Pago> GetAll()
        {
           List<Pago> listaAux = null;
           return listaAux;
        }

        public Pago GetById(int id)
        {
  
            return new Pago();
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Pago objPago in _insertItems)
                        {
                            InsertPago(objPago);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Pago p in _updateItems)
                        {
                            UpdatePago(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (TipoDePago p in _deleteItems)
                        {
                            DeletePago(p);
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

        private void InsertPago(Pago objPago)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pFactura", objPago.Factura));
                cmd.Parameters.Add(new SqlParameter("@pMonto", objPago.Monto));
                cmd.Parameters.Add(new SqlParameter("@pTipo", objPago.Tipo));
                cmd.Parameters.Add(new SqlParameter("@pDesde", objPago.Desde));
                cmd.Parameters.Add(new SqlParameter("@pHasta", objPago.Hasta));
                cmd.Parameters.Add(new SqlParameter("@pUsuario", objPago.User));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarPago");
            }
            catch (Exception ex)
            {

            }
        }

        private void UpdatePago(Pago objPago)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objPago.Id));
                cmd.Parameters.Add(new SqlParameter("@pMonto", objPago.Monto));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarPago");

            }
            catch (Exception ex)
            {
                
            }
        }

        private void DeletePago(TipoDePago objPago)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objPago.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_CambiarEstadoPago");
            }
            catch (Exception ex)
            {

            }
        }

    }
}
