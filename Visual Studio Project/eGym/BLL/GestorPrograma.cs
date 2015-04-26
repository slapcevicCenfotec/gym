using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;

namespace BLL
{
    public class GestorProgramas
    {
        // VARIABLES
        private UnitOfWork unitOfWork;

        // CONSTRUCTOR
        public GestorProgramas()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<Programa> ListarProgramas()
        {
            return unitOfWork.ProgramaRepository.GetAll();
        }



        public Programa ObtenerPrograma(int pId)
        {
            var programa = unitOfWork.ProgramaRepository.GetById(pId);
            //foreach (var contacto in unitOfWork.RepositoryContacto.GetAll())
            //{
            //    if (contacto.Usuario.Id == usuario.Id)
            //    {
            //        usuario.Contactos.Add(contacto);
            //    }
            //}
            //foreach (var horario in unitOfWork.RepositoryHorario.GetAll())
            //{
            //    if (horario.Usuario.Id == usuario.Id)
            //    {
            //        usuario.Horarios.Add(horario);
            //    }
            //}
            return programa;
        }

        public void AgregarPrograma(int pidUsuario, TipoAcondicionamiento ptipoAcondicionamiento, List<EjercicioPrograma> plistaEjerciciosPrograma)
        {
            Programa programa = new Programa();
            programa.IdUsuario = pidUsuario;
            programa.TipoAcondicionamiento = ptipoAcondicionamiento;
            programa.ListaEjercicios = plistaEjerciciosPrograma;

            unitOfWork.ProgramaRepository.Insert(programa);
            unitOfWork.ProgramaRepository.Save();
        }

        public void EliminarPrograma(Programa programa)
        {
            unitOfWork.ProgramaRepository.Delete(programa);
            unitOfWork.ProgramaRepository.Save();
        }

        public void ModificarPrograma(int pid, int pidUsuario, TipoAcondicionamiento ptipoAcondicionamiento, List<EjercicioPrograma> plistaEjerciciosPrograma)
        {
            Programa programa = new Programa();
            programa.Id = pid;
            programa.IdUsuario = pidUsuario;
            programa.TipoAcondicionamiento = ptipoAcondicionamiento;
            programa.ListaEjercicios = plistaEjerciciosPrograma;

            unitOfWork.ProgramaRepository.Update(programa);
            unitOfWork.ProgramaRepository.Save();
        }

    }
}