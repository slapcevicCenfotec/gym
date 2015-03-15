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

        public IEnumerable<TipoDeMaquina> listarTiposDeMaquinas()
        {
            return UoW.TipoDeMaquinaRepository.GetAll();
        }

        public TipoDeMaquina GetTipoDeMaquinaById(int pid)
        {
            return UoW.TipoDeMaquinaRepository.GetById(pid);
        }

        public void insertarTipoDeMaquina(byte[] pfoto, string pnombre, string pdescripcion)
        {
            TipoDeMaquina tipoDeMaquina = new TipoDeMaquina(pfoto, pnombre, pdescripcion);
            UoW.TipoDeMaquinaRepository.Insert(tipoDeMaquina);
            UoW.TipoDeMaquinaRepository.Save();
        }

        public void modificarTipoDeMaquina(int pid, byte[] pfoto, string pnombre, string pdescripcion, Boolean phabilitado)
        {
            TipoDeMaquina tipoDeMaquina = new TipoDeMaquina(pid, pfoto, pnombre, pdescripcion, phabilitado);
            UoW.TipoDeMaquinaRepository.Update(tipoDeMaquina);
            UoW.TipoDeMaquinaRepository.Save();
        }

        public void eliminarTipoDeMaquina(TipoDeMaquina ptipoMaquina)
        {
            UoW.TipoDeMaquinaRepository.Delete(ptipoMaquina);
            UoW.TipoDeMaquinaRepository.Save();
        }

    }
}
