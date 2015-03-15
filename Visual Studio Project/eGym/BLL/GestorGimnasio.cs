using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;
using Exceptions.CustomExceptions;
using System.Data.SqlClient;

namespace BLL
{


    /// <summary>
    /// Autor:Alexis Soto
    /// Fecha:03/15/2015
    /// Descripcion: Esta clase se encarga de manejar los metodos de de insercion y modificacion  de los datos del gimnasio
    /// </summary>
    public class GestorGimnasio
    {
        private GestorEvento gestorEventos = new GestorEvento();
        private GestorExcepcion gestorExcepciones = new GestorExcepcion();
        private UnitOfWork UoW = new UnitOfWork();

        /// <summary>
        /// Autor:Alexis Soto
        /// Fecha:03/15/2015
        /// Descripcion: Devuelve una lista de gimnasios.
        /// </summary>
        /// <returns>IEnumerable<Gimnasio></returns>
        public IEnumerable<Gimnasio> listarGimnasios()
        {

            return UoW.GimnasioRepository.GetAll();
        }

        /// <summary>
        /// Autor:Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion Obtiene un gimnasio cuando se le envia un Id.
        /// </summary>
        /// <param name="id">Identificador.</param>
        /// <returns>List<Gimnasio></returns>
        public List<Gimnasio> obtenerGimnasio(int id)
        {
            List<Gimnasio> listaGimnasios = new List<Gimnasio>();
            listaGimnasios.Add(UoW.GimnasioRepository.GetById(id));
            return listaGimnasios;
        }

        /// <summary>
        /// Autor:Alexis Soto
        /// Fecha:3/15/2015
        /// Descripcion: Modifica los datos del gimnasio.
        /// </summary>
        /// <param name="pId">The p identifier.</param>
        /// <param name="pnombre">The pnombre.</param>
        /// <param name="pUbicacion">The p ubicacion.</param>
        /// <param name="ptelefono">The ptelefono.</param>
        /// <param name="pFax">The p fax.</param>
        /// <param name="pcedulaJuridica">The pcedula juridica.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error modificando el Gimnasio
        /// or
        /// Ha ocurrido un error modificando el Gimnasio
        /// </exception>
        public void ModificarGimnasio(int pId, String pnombre, String pUbicacion, String ptelefono, String pFax, String pcedulaJuridica)
        {

            Gimnasio objGimnasio = null;
            objGimnasio = new Gimnasio();
            objGimnasio.Id = pId;
            objGimnasio.Nombre = pnombre;
            objGimnasio.Ubicacion = pUbicacion;
            objGimnasio.Telefono = ptelefono;
            objGimnasio.Fax = pFax;
            objGimnasio.CedulaJuridica = pcedulaJuridica;



            try
            {
                if (objGimnasio.IsValid)
                {
                    UoW.GimnasioRepository.Update(objGimnasio);
                    UoW.GimnasioRepository.Save();
                    gestorEventos.insertarEvento("Modificar Gimnasio", "El usuario a modificado el gimnasio " + objGimnasio.Nombre + " al sistema.");

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objGimnasio.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error modificando el Gimnasio");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error modificando el Gimnasio");
            }


        }
        /// <summary>
        /// Autor:Alexis Soto
        /// Fecha:3/15/2015
        /// Descripcion: Inserta los  datos del gimnasio.
        /// </summary>
        /// <param name="pnombre">The pnombre.</param>
        /// <param name="pUbicacion">The p ubicacion.</param>
        /// <param name="pTelefono">The p telefono.</param>
        /// <param name="pFax">The p fax.</param>
        /// <param name="pCedulaJuridica">The p cedula juridica.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error insertando el gimnasio
        /// or
        /// Ha ocurrido un error insertando el gimnasio
        /// </exception>
        public void insertarGimnasio(String pnombre, String pUbicacion, String pTelefono, String pFax, String pCedulaJuridica)
        {

            Gimnasio objGimnasio = null;
            objGimnasio = new Gimnasio();
            objGimnasio.Nombre = pnombre;
            objGimnasio.Ubicacion = pUbicacion;
            objGimnasio.Telefono = pTelefono;
            objGimnasio.Fax = pFax;
            objGimnasio.CedulaJuridica = pCedulaJuridica;

            try
            {
                if (objGimnasio.IsValid)
                {
                    UoW.GimnasioRepository.Insert(objGimnasio);
                    UoW.GimnasioRepository.Save();

                    gestorEventos.insertarEvento("Insertar Gimnasio", "El usuario a insertado el gimnasio " + objGimnasio.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objGimnasio.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error insertando el gimnasio");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error insertando el gimnasio");
            }

        }
    }
}
