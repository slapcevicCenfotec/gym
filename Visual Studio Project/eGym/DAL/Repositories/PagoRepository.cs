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
    // Autor: Alberto Arias S
    /// Fecha: 03/15/2015
    /// Descricpcion: Este Clase se encarga del acceso a datos de los pagos. 
    /// Contiene los metodos de listar, modificar e relimina 
    /// </summary>
    public class PagoRepository : IRepository<Pago>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion:Inicializa una nueva instancia de <see cref="PagoRepository"/> class.
        /// </summary>
        public PagoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion:Inserta una entidad Especifica.
        /// <param name="entity">Entidad Pago.</param>
        public void Insert(Pago entity)
        {
            _insertItems.Add(entity);
        }
        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion:Elimina una entidad especifica
        /// </summary>
        /// <param name="entity">Entidad Pago.</param>
        public void Delete(Pago entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion:Actualiza una entidad especifica
        /// </summary>
        /// <param name="entity">Entidad Pago.</param>
        public void Update(Pago entity)
        {
            _updateItems.Add(entity);
        }
        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion:Este Devuelve una lista de Pago de la base de datos
        /// </summary>
        /// <returns>IEnumerable<Pago></returns>
        public IEnumerable<Pago> GetAll()
        {
            List<Pago> pagos = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarPago");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pagos = new List<Pago>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pago auxPago = new Pago();

                    auxPago.Id = Convert.ToInt32(dr["ID"]);
                    auxPago.Factura = dr["Factura"].ToString();
                    auxPago.Monto = float.Parse(Convert.ToString(dr["Monto"]));
                    auxPago.Tipo = Convert.ToInt32(dr["TIPO"]);
                    auxPago.Desde = Convert.ToDateTime(dr["DESDE"]);
                    auxPago.Hasta = Convert.ToDateTime(dr["HASTA"]);
                    auxPago.Fecha = Convert.ToDateTime(dr["FECHA"]);
                    auxPago.User = Convert.ToInt32(dr["USUARIO"]);
                    auxPago.Habilitado = Convert.ToBoolean(dr["HABILITADO"]);
                    auxPago.Nombre  = dr["NOMBRE"].ToString();
                    pagos.Add(auxPago);
                }
            }
            return pagos;
        }

        public Pago GetById(int id)
        {

            return new Pago();
        }

        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion: Guarda el conjunto de instancias Pago.
        /// </summary>
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
        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion:Clears Limpia la lista de instacias TipoDePago.
        /// </summary>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }
        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion:Este metodo inserta una instancia Pago en la base de datos
        /// </summary>
        /// <param name="objPago">Pago.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Autor: Alberto Arias S
        /// Fecha: 03/15/2015
        /// Descripcion:Este metodo modifica una instancia tipoDePago en la base de datos
        /// </summary>
        /// <param name="objPago">The p identifier Pago.</param>
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


        public IEnumerable<Pago> GetAllPorUsuario(Pago objPago)
        {
            List<Pago> listaPagos = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@pUserId", objPago.Id));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarMisPagos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                listaPagos = new List<Pago>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pago auxPago = new Pago();
                    auxPago.Id = Convert.ToInt32(dr["ID"]);
                    auxPago.Factura = dr["Factura"].ToString();
                    auxPago.Monto = float.Parse(Convert.ToString(dr["Monto"]));
                    auxPago.Tipo = Convert.ToInt32(dr["TIPO"]);
                    auxPago.Desde = Convert.ToDateTime(dr["DESDE"]);
                    auxPago.Hasta = Convert.ToDateTime(dr["HASTA"]);
                    auxPago.Fecha = Convert.ToDateTime(dr["FECHA"]);
                    auxPago.User = Convert.ToInt32(dr["USUARIO"]);
                    auxPago.Habilitado = Convert.ToBoolean(dr["HABILITADO"]);
                    listaPagos.Add(auxPago);
                }
            }
            return listaPagos;
        }
    }
}