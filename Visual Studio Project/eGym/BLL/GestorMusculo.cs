using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;
using Exceptions.CustomExceptions;
using System.Data.SqlClient;

namespace BLL
{
    /// <summary>
    /// Autor:Danny Espinoza
    /// Fecha:03/15/2015
    /// Descripcion: Esta clase se encarga de manejar los metodos de insercion, modificaion y eliminación de los músculos de sistema
    /// </summary>
    public class GestorMusculo
    {
        private UnitOfWork Uow = new UnitOfWork();
        private GestorExcepcion gestorExcepciones = new GestorExcepcion();
        private GestorEvento gestorEventos = new GestorEvento();
        /// <summary>
        /// Autor:Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripcion: Este metodo devuelve una lista de músculos.
        /// </summary>
        /// <returns>List<Musculo></returns>
        public IEnumerable<Musculo> listarMusculos()
        {
            return Uow.MusculoRepository.GetAll();      
        }
        /// <summary>
        /// Autor : Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripcion: Llamma al metodo para insertar un músculo.
        /// </summary>
        /// <param name="pnombre"></param>
        /// <param name="ubicacion"></param>
        /// <param name="origen"></param>
        /// <param name="inserccion"></param>
        /// <param name="inervacion"></param>
        /// <param name="irrigacion"></param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error agregando el músculo
        /// or
        /// Ha ocurrido un error agregando el músculo
        /// </exception>
        public void agregarMusculo(string pnombre,string ubicacion , string origen, string inserccion , string inervacion, string irrigacion)
        {
            try
            {
                Musculo objMusculo = new Musculo(pnombre, ubicacion,origen, inserccion, inervacion, irrigacion);

                if (objMusculo.IsValid)
                {
                    Uow.MusculoRepository.Insert(objMusculo);
                    Uow.MusculoRepository.Save();
                    gestorEventos.insertarEvento("Insertar Músculo", "El usuario a insertado el musculo " + objMusculo.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (RuleViolation rv in objMusculo.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }

                    throw new BusinessLogicException(sb.ToString());
                }

            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando un musculo");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando un músculo");
            }

        }
        /// <summary>
        /// Autor : Danny Espinoza
        /// Descripcion: Este meetodo se encargar Modificar un músculo.
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="pnombre"></param>
        /// <param name="ubicacion"></param>
        /// <param name="origen"></param>
        /// <param name="inserccion"></param>
        /// <param name="inervacion"></param>
        /// <param name="irrigacion"></param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error modificando el músculo
        /// or
        /// Ha ocurrido un error modificando el músculo
        /// </exception>
        public void modificarMusculo(int pid,string pnombre, string ubicacion, string origen, string inserccion, string inervacion, string irrigacion)
        {
            try
            {
                Musculo objMusculo = new Musculo(pid, pnombre, ubicacion, origen, inserccion, inervacion, irrigacion);

                if (objMusculo.IsValid)
                {
                    Uow.MusculoRepository.Update(objMusculo);
                    Uow.MusculoRepository.Save();
                    gestorEventos.insertarEvento("Modificar Músculo", "El usuario a modificado el músculo " + objMusculo.Nombre + " al sistema.");

                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (RuleViolation rv in objMusculo.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }

                    throw new BusinessLogicException(sb.ToString());
                }

            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando un músculo");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error modificando el músculo");
            }
        
        }
        /// <summary>
        /// Autor : Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripcion: Este metodo se encraga de  Eliminar un músculo.
        /// </summary>
        /// <param name="pMusculo">Objeto Musculo que va a ser eliminado</param>
        public void eliminarMusculo(Musculo pMusculo)
        {
            try
            {
                if (pMusculo.IsValid)
                {
                    Uow.MusculoRepository.Delete(pMusculo);
                    Uow.MusculoRepository.Save();
                    gestorEventos.insertarEvento("Eliminar Musculo", "El usuario ha Eliminado el músculo " + pMusculo.Nombre + " al sistema.");
                }
                else 
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in pMusculo.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                
                }

            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error Eliminando el músuclo");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error Eliminiado el músuclo");
            }
           
        }
        /// <summary>
        /// Autor : Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripcion: Este metodo se busca la imagenes de ún músculo
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Musculo musculoPorId(int pId)
        {
            Musculo musculo = Uow.MusculoRepository.GetById(pId);
            return musculo;
        }

        public void habilitarMusculo(int pId)
        {


        }
    }
}
