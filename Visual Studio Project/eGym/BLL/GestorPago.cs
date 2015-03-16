using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class GestorPago
    {
        private UnitOfWork UoW = new UnitOfWork();

        public IEnumerable<Pago> listarPagos()
        {
            return UoW.PagoRepository.GetAll();
        }

        public void insertarPago(string pFactura, double pMonto, int pTipo, DateTime pHasta, DateTime pDesde, int pUsuario) 
        {
            Pago pago = new Pago(pFactura, pMonto, pTipo, pHasta, pDesde, pUsuario);
            UoW.PagoRepository.Insert(pago);
            UoW.PagoRepository.Save();
        }
        
    }
}
