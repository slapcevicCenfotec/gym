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
    public class GestorTiposDeMaquina
    {

        private UnitOfWork UoW = new UnitOfWork();

        public IEnumerable<TipoDeMaquina> listarMaquinas()
        {
            return UoW.TipoDeMaquinaRepository.GetAll();
        }

        //public void insertarTipoDeMaquina(string pnombre, string pdescripcion, Image pfoto)
        //{
        //    TipoDeMaquina tipoDeMaquina = new TipoDeMaquina(pnombre, pdescripcion, pfoto);
        //    UoW.TipoDeMaquinaRepository.Insert(tipoDeMaquina);
        //    UoW.TipoDeMaquinaRepository.Save();
        //}

    }
}
