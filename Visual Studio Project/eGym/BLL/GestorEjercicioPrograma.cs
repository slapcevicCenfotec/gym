using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;

namespace BLL
{
    public class GestorEjercicioPrograma
    {
        // VARIABLES
        private UnitOfWork unitOfWork;

        // CONSTRUCTOR
        public GestorEjercicioPrograma()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<EjercicioPrograma> ListarEjercicioPrograma()
        {
            return unitOfWork.EjercicioProgramaRepository.GetAll();
        }

        public EjercicioPrograma ObtenerEjercicioPrograma(int pId)
        {
            var ejercicioPrograma = unitOfWork.EjercicioProgramaRepository.GetById(pId);
            return ejercicioPrograma;
        }

        public void AgregarEjercicioPrograma(int pseries, int prepeticiones, float ppeso, int psemana, Ejercicio pejercicio, int ptipoMedida)
        {
            EjercicioPrograma ejercicioPrograma = new EjercicioPrograma();
            ejercicioPrograma.Series = pseries;
            ejercicioPrograma.Repeticiones = prepeticiones;
            ejercicioPrograma.Peso = ppeso;
            ejercicioPrograma.Semana = psemana;
            ejercicioPrograma.Ejercicio = pejercicio;
            ejercicioPrograma.TipoMedida = new TipoMedida { Id = ptipoMedida };

            unitOfWork.EjercicioProgramaRepository.Insert(ejercicioPrograma);
            unitOfWork.EjercicioProgramaRepository.Save();
        }

        public void EliminarEjercicioPrograma(EjercicioPrograma ejercicioPrograma)
        {
            unitOfWork.EjercicioProgramaRepository.Delete(ejercicioPrograma);
            unitOfWork.EjercicioProgramaRepository.Save();
        }

        public void ModificarEjercicioPrograma(int pid, int pseries, int prepeticiones, float ppeso, int psemana, Ejercicio pejercicio, int ptipoMedida)
        {
            EjercicioPrograma ejercicioPrograma = new EjercicioPrograma();
            ejercicioPrograma.Id = pid;
            ejercicioPrograma.Series = pseries;
            ejercicioPrograma.Repeticiones = prepeticiones;
            ejercicioPrograma.Peso = ppeso;
            ejercicioPrograma.Semana = psemana;
            ejercicioPrograma.Ejercicio = pejercicio;
            ejercicioPrograma.TipoMedida = new TipoMedida { Id = ptipoMedida };

            unitOfWork.EjercicioProgramaRepository.Update(ejercicioPrograma);
            unitOfWork.EjercicioProgramaRepository.Save();
        }

    }
}