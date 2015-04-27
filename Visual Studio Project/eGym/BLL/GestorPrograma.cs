using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DAL;
using EL;
using Exceptions.CustomExceptions;

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

        public List<Programa> ListarProgramas()
        {
            return unitOfWork.ProgramaRepository.GetAll().ToList<Programa>();
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

        public void AgregarPrograma(int pidUsuario, int ptipoAcondicionamiento)
        {
            Programa programa = new Programa();
            programa.IdUsuario = pidUsuario;
            programa.TipoAcondicionamiento = ptipoAcondicionamiento;

            unitOfWork.ProgramaRepository.Insert(programa);
            unitOfWork.ProgramaRepository.Save();
        }

        public void EliminarPrograma(Programa programa)
        {
            unitOfWork.ProgramaRepository.Delete(programa);
            unitOfWork.ProgramaRepository.Save();
        }

        public void ModificarPrograma(int pid, int pidUsuario, int ptipoAcondicionamiento, int pestado)
        {
            Programa programa = new Programa();
            programa.Id = pid;
            programa.IdUsuario = pidUsuario;
            programa.TipoAcondicionamiento = ptipoAcondicionamiento;
            programa.Estado = pestado;

            unitOfWork.ProgramaRepository.Update(programa);
            unitOfWork.ProgramaRepository.Save();
        }

    }
}