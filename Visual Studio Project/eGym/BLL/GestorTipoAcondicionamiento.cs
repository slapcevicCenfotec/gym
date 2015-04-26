using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;

namespace BLL
{
    public class GestorTipoAcondicionamiento
    {
        // VARIABLES
        private UnitOfWork unitOfWork;

        // CONSTRUCTOR
        public GestorTipoAcondicionamiento()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<TipoAcondicionamiento> ListarTiposAcondicionamiento()
        {
            return unitOfWork.TipoAcondicionamientoRepository.GetAll();
        }



        public TipoAcondicionamiento ObtenerTipoAcondicionamiento(int pId)
        {
            var tipoAcondicionamiento = unitOfWork.TipoAcondicionamientoRepository.GetById(pId);
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
            return tipoAcondicionamiento;
        }

        public void AgregarTipoAcondicionamiento(string pnombre)
        {
            TipoAcondicionamiento tipoAcondicionamiento = new TipoAcondicionamiento();
            tipoAcondicionamiento.Nombre = pnombre;

            unitOfWork.TipoAcondicionamientoRepository.Insert(tipoAcondicionamiento);
            unitOfWork.TipoAcondicionamientoRepository.Save();
        }

        public void EliminarPrograma(TipoAcondicionamiento tipoAcondicionamiento)
        {
            unitOfWork.TipoAcondicionamientoRepository.Delete(tipoAcondicionamiento);
            unitOfWork.TipoAcondicionamientoRepository.Save();
        }

        public void ModificarPrograma(int pid, string pnombre)
        {
            TipoAcondicionamiento tipoAcondicionamiento = new TipoAcondicionamiento();
            tipoAcondicionamiento.Id = pid;
            tipoAcondicionamiento.Nombre = pnombre;

            unitOfWork.TipoAcondicionamientoRepository.Update(tipoAcondicionamiento);
            unitOfWork.TipoAcondicionamientoRepository.Save();
        }

    }
}