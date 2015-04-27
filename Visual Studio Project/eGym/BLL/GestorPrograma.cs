using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DAL;
using EL;
using Exceptions.CustomExceptions;
using System.Data.SqlClient;

namespace BLL
{
    public class GestorProgramas
    {
        // VARIABLES
        private UnitOfWork unitOfWork;
        private GestorExcepcion gestorExcepciones = new GestorExcepcion();
        private GestorEvento gestorEventos = new GestorEvento();
        private GestorEjercicioPrograma gestorEjercicios = new GestorEjercicioPrograma();

        // CONSTRUCTOR
        public GestorProgramas()
        {
            unitOfWork = new UnitOfWork();
        }

        public List<Programa> ListarProgramas()
        {
            List<Programa> listaProgramas = null;
            try
            {
                listaProgramas = unitOfWork.ProgramaRepository.GetAll().ToList<Programa>();
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error obteniendo los programas");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new BusinessLogicException("Ha ocurrido un error obteniendo los programas");
            }
            return listaProgramas;
        }

        public Programa ObtenerPrograma(int pId)
        {
            Programa programa = null;
            try
            {
                programa = unitOfWork.ProgramaRepository.GetById(pId);
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error obteniendo el programa");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new BusinessLogicException("Ha ocurrido un error obteniendo el programa");
            }
            return programa;
        }

        public Programa ObtenerUltimoPrograma()
        {
            Programa programa = null;
            try
            {
                programa = unitOfWork.ProgramaRepositoryOriginal.GetLast();
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error obteniendo el programa");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new BusinessLogicException("Ha ocurrido un error obteniendo el programa");
            }
            return programa;
        }

        public void AgregarPrograma(int pidUsuario, int ptipoAcondicionamiento)
        {
            try { 
            Programa programa = new Programa();
            programa.IdUsuario = pidUsuario;
            programa.TipoAcondicionamiento = new TipoAcondicionamiento { Id = ptipoAcondicionamiento };

            unitOfWork.ProgramaRepository.Insert(programa);
            unitOfWork.ProgramaRepository.Save();
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error generando el programa");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new BusinessLogicException ("Ha ocurrido un error generando el programa");
            }
        }

        public void EliminarPrograma(Programa programa)
        {
            try {
                unitOfWork.ProgramaRepository.Delete(programa);
                unitOfWork.ProgramaRepository.Save();
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error eliminando el programa");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new BusinessLogicException("Ha ocurrido un error eliminando el programa");
            }
        }

        public void ModificarPrograma(int pid, int pidUsuario, int ptipoAcondicionamiento, int pestado)
        {
            try
            {
                Programa programa = new Programa();
                programa.Id = pid;
                programa.IdUsuario = pidUsuario;
                programa.TipoAcondicionamiento = new TipoAcondicionamiento { Id = ptipoAcondicionamiento };
                programa.Estado = pestado;

                unitOfWork.ProgramaRepository.Update(programa);
                unitOfWork.ProgramaRepository.Save();
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error modificando el programa");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new BusinessLogicException("Ha ocurrido un error modificando el programa");
            }
        }

    }
}