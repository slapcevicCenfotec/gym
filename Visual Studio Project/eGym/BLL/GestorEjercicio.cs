using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

namespace BLL
{
    public class GestorEjercicio
    {
        private UnitOfWork Uow = new UnitOfWork();

        public IEnumerable<Ejercicio> listarEjercicios()
        {

            return Uow.EjercicioRepository.GetAll();
        }

        public void insertarEjercicio(byte[] pfoto)
        {
            Ejercicio ejercicio = new Ejercicio(pfoto);
            Uow.EjercicioRepository.Insert(ejercicio);
            Uow.EjercicioRepository.Save();

            //UoW.TipoDeMaquinaRepository.Insert(tipoDeMaquina);
            //UoW.TipoDeMaquinaRepository.Save();
        }

    }
}
