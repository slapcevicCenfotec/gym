using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EL;
using Exceptions.CustomExceptions;
using System.Data.SqlClient;
using DAL;
/// <summary>
/// Fecha de creación: 02/04/2015
/// Autor: Mauricio Fernández Mora
/// Fecha de modificación: 02/04/2015
/// Modificado por: Mauricio Fernández Mora
/// </summary>

namespace BLL
{

    public class GestorFichaMedicion
    {
        /// <summary>
        /// Instancia de unit of work
        /// </summary>
        private UnitOfWork UoW = new UnitOfWork();

        /// <summary>
        /// Instancia de gestor de excepciones
        /// </summary>
        private GestorExcepcion gestorExcepciones = new GestorExcepcion();

        /// <summary>
        /// Instancia de gestor de eventos
        /// </summary>
        private GestorEvento gestorEventos = new GestorEvento();

        /// <summary>
        /// Lista cada una de las instancias de fichas de medición.
        /// </summary>
        /// <returns></returns>
        public List<FichaMedicion> listarFichasMedicion()
        {
            return UoW.FichaMedicionRepository.GetAll().ToList<FichaMedicion>();
        }

        /// <summary>
        /// Obtiene una instancia de ficha de medición por Id.
        /// </summary>
        /// <param name="pid">Id de la ficha de medición.</param>
        /// <returns></returns>
        public FichaMedicion GetFichaMedicionById(int pid)
        {
            return UoW.FichaMedicionRepository.GetById(pid);
        }

        /// <summary>FALTA COMENTAR
        public void insertarFichaMedicion(int pcliente, DateTime pfecha, float ppeso, float paltura, float pimc, string pclasificacionimc,
                            float pporcentajeGrasaCorporal, float pporcentajeMasaMuscular, float ppesoGraso, float pperBicepsIzquierdo,
                            float pperBicepsDerecho, float pperBicepsIzqContraido, float pperBicepsDerContraido, float pperPantorrillaIzquierda,
                            float pperPantorrillaDerecha, float pperMusloIzquierdo, float pperMusloDerecho, float pperCintura, float pperAbdomen,
                            float pperCadera, float pperPecho, float pperEspalda, float ppliTricepsIzquierdo, float ppliTricepsDerecho,
                            float ppliSubescapularIzquierdo, float ppliSubescapularDerecho, float ppliSupraespinalIzquierdo, float ppliSupraespinalDerecho,
                            float ppliAbdominalIzquierdo, float ppliAbdominalDerecho, float ppliMusloIzquierdo, float ppliMusloDerecho,
                            float ppliPantorrillaIzquierda, float ppliPantorrillaDerecha)
        {
            FichaMedicion fichaMedicion = new FichaMedicion(pcliente, pfecha, ppeso, paltura, pimc, pclasificacionimc,
                            pporcentajeGrasaCorporal, pporcentajeMasaMuscular, ppesoGraso, pperBicepsIzquierdo,
                            pperBicepsDerecho, pperBicepsIzqContraido, pperBicepsDerContraido, pperPantorrillaIzquierda,
                            pperPantorrillaDerecha, pperMusloIzquierdo, pperMusloDerecho, pperCintura, pperAbdomen,
                            pperCadera, pperPecho, pperEspalda, ppliTricepsIzquierdo, ppliTricepsDerecho,
                            ppliSubescapularIzquierdo, ppliSubescapularDerecho, ppliSupraespinalIzquierdo, ppliSupraespinalDerecho,
                            ppliAbdominalIzquierdo, ppliAbdominalDerecho, ppliMusloIzquierdo, ppliMusloDerecho,
                            ppliPantorrillaIzquierda, ppliPantorrillaDerecha);

            try
            {
                if (fichaMedicion.IsValid)
                {
                    UoW.FichaMedicionRepository.Insert(fichaMedicion);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.FichaMedicionRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Insertar ficha de medición", "El usuario ha insertado una ficha de medición para el cliente " + fichaMedicion.Cliente + " en el sistema.");
                }                    
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in fichaMedicion.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
            catch (SqlException ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando la ficha de medición");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando la ficha de medición");
            }

        }

        /// FALTA COMENTAR
        public void modificarFichaMedicion(int pid, int pcliente, DateTime pfecha, float ppeso, float paltura, float pimc, string pclasificacionimc,
                            float pporcentajeGrasaCorporal, float pporcentajeMasaMuscular, float ppesoGraso, float pperBicepsIzquierdo,
                            float pperBicepsDerecho, float pperBicepsIzqContraido, float pperBicepsDerContraido, float pperPantorrillaIzquierda,
                            float pperPantorrillaDerecha, float pperMusloIzquierdo, float pperMusloDerecho, float pperCintura, float pperAbdomen,
                            float pperCadera, float pperPecho, float pperEspalda, float ppliTricepsIzquierdo, float ppliTricepsDerecho,
                            float ppliSubescapularIzquierdo, float ppliSubescapularDerecho, float ppliSupraespinalIzquierdo, float ppliSupraespinalDerecho,
                            float ppliAbdominalIzquierdo, float ppliAbdominalDerecho, float ppliMusloIzquierdo, float ppliMusloDerecho,
                            float ppliPantorrillaIzquierda, float ppliPantorrillaDerecha, Boolean phabilitado)
        {
            FichaMedicion fichaMedicion = new FichaMedicion(pid, pcliente, pfecha, ppeso, paltura, pimc, pclasificacionimc,
                            pporcentajeGrasaCorporal, pporcentajeMasaMuscular, ppesoGraso, pperBicepsIzquierdo,
                            pperBicepsDerecho, pperBicepsIzqContraido, pperBicepsDerContraido, pperPantorrillaIzquierda,
                            pperPantorrillaDerecha, pperMusloIzquierdo, pperMusloDerecho, pperCintura, pperAbdomen,
                            pperCadera, pperPecho, pperEspalda, ppliTricepsIzquierdo, ppliTricepsDerecho,
                            ppliSubescapularIzquierdo, ppliSubescapularDerecho, ppliSupraespinalIzquierdo, ppliSupraespinalDerecho,
                            ppliAbdominalIzquierdo, ppliAbdominalDerecho, ppliMusloIzquierdo, ppliMusloDerecho,
                            ppliPantorrillaIzquierda, ppliPantorrillaDerecha, phabilitado);

            try
            {
                if (fichaMedicion.IsValid)
                {
                    UoW.FichaMedicionRepository.Update(fichaMedicion);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.FichaMedicionRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Modificar ficha de medición", "El usuario ha modificado una ficha de medicion con Id" + fichaMedicion.Id + " en el sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in fichaMedicion.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());

                }
            }
            catch (SqlException ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error modificando la ficha de medición");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error modificando la ficha de medición");
            }
        }

        /// FALTA COMENTAR
        public void eliminarFichaMedicion(FichaMedicion pfichaMedicion)
        {
            try
            {
                if (pfichaMedicion.IsValid)
                {
                    UoW.FichaMedicionRepository.Delete(pfichaMedicion);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.FichaMedicionRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Eliminar ficha de medición", "El usuario ha eliminado una ficha de medición con Id " + pfichaMedicion.Id + " en el sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in pfichaMedicion.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
            catch (SqlException ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error eliminando la ficha de medición");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error eliminando la ficha de medición");
            }
        }

    }
}
