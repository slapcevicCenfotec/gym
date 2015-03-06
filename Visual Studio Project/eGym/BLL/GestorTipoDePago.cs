using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DAL;
using EL;


namespace BLL
{
    public class GestorTipoPago
    {
        private UnitOfWork UoW = new UnitOfWork();
        public IEnumerable<TipoDePago> listarPagos()
        {
            return UoW.TipoDePagoRepository.GetAll();
        }
        public void insertarTipoDeMaquina(String pNombre, float pMonto, int pDuracion)
        {
            TipoDePago tipoDePago = new TipoDePago(pNombre, pMonto, pDuracion);
            UoW.TipoDePagoRepository.Insert(tipoDePago);
            UoW.TipoDePagoRepository.Save();
        }

       
    }
}
