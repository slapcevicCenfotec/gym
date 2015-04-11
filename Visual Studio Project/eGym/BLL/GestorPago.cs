using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    /// <summary>
    /// Autor:Alberto Arias
    /// Fecha:03/15/2015
    /// Descripcion: Esta clase se encarga de manejar los metodos de de insercion y modificacion  de pagos
    /// </summary>
    public class GestorPago
    {
        private UnitOfWork UoW = new UnitOfWork();
        /// <summary>
        /// Autor:Alberto Arias
        /// Fecha:03/15/2015
        /// Descripcion: Devuelve una lista de todo los pago habilitados.
        /// </summary>
        /// <returns>IEnumerable<Pago></returns>
        public List<Pago> listarPagos()
        {
            return UoW.PagoRepository.GetAll().ToList<Pago>();
        }
        /// <summary>
        /// Autor:Alberto Arias
        /// Fecha:03/15/2015
        /// Descripcion: Inserta un nuevo pago
        /// </summary>
        /// <param name="pFactura">Nombre.</param>
        /// <param name="pMonto">Monto.</param>
        /// <param name="pTipo">Tipo.</param>
        /// <param name="pHasta">Hasta.</param>
        /// <param name="pDesde">Desde.</param>
        /// <param name="pUsuario">Usuario.</param>
        public void insertarPago(string pFactura, double pMonto, int pTipo, DateTime pHasta, DateTime pDesde, int pUsuario) 
        {
            Pago pago = new Pago(pFactura, pMonto, pTipo, pHasta, pDesde, pUsuario);
            UoW.PagoRepository.Insert(pago);
            UoW.PagoRepository.Save();
        }
        
    }
}
