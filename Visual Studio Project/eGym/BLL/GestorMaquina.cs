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
    public class GestorMaquina
    {

        private UnitOfWork UoW = new UnitOfWork();

        public IEnumerable<Maquina> listarMaquinas()
        {
            return UoW.MaquinaRepository.GetAll();
        }

        public Maquina GetMaquinaById(int pid)
        {
            return UoW.MaquinaRepository.GetById(pid);
        }

        public void insertarMaquina(string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
        {
            Maquina Maquina = new Maquina(pnumeroActivo, pnumeroMaquina, phabilitado, ptipoDeMaquina);
            UoW.MaquinaRepository.Insert(Maquina);
            UoW.MaquinaRepository.Save();
        }

        public void modificarMaquina(int pid, string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
        {
            Maquina Maquina = new Maquina(pid, pnumeroActivo, pnumeroMaquina, phabilitado, ptipoDeMaquina);
            UoW.MaquinaRepository.Update(Maquina);
            UoW.MaquinaRepository.Save();
        }

        public void eliminarMaquina(Maquina ptipoMaquina)
        {
            UoW.MaquinaRepository.Delete(ptipoMaquina);
            UoW.MaquinaRepository.Save();
        }

    }
}
