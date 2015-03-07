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
    public class GestorTipoDePago
    {
        private UnitOfWork UoW = new UnitOfWork();
        public IEnumerable<TipoDePago> listarTiposDePago()
        {
            return UoW.TipoDePagoRepository.GetAll();
        }
        public void insertarTipoDePago(String pNombre, float pMonto, int pDuracion)
        {
            TipoDePago tipoDePago = new TipoDePago(pNombre, pMonto, pDuracion);
            UoW.TipoDePagoRepository.Insert(tipoDePago);
            UoW.TipoDePagoRepository.Save();
        }
        public void modificarTipoDePago(int pId, String pNombre, float pMonto, int pDuracion, bool pHabilitado)
        {
            TipoDePago tipoDePago = new TipoDePago(pId, pNombre, pMonto, pDuracion, pHabilitado);
            UoW.TipoDePagoRepository.Update(tipoDePago);
            UoW.TipoDePagoRepository.Save();
        }

       
    }
}
