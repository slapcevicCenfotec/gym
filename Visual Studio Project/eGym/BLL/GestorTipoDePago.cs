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

       
    }
}
