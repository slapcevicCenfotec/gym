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
/// <summary>
/// Fecha de creación: 07/03/2015:
/// Autor: Mauricio Fernández Mora
/// Fecha de modificación: 14/03/2015
/// Modificado por: Mauricio Fernández Mora
/// </summary>

namespace BLL
{
    public class GestorTipoDeMaquina
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

        /// Lista cada una de las instancias de tipo de máquina.
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TipoDeMaquina> listarTiposDeMaquinas()
        {
            return UoW.TipoDeMaquinaRepository.GetAll();
        }

        /// <summary>
        /// Obtiene una instancia de tipo de maquina por Id.
        /// </summary>
        /// <param name="pid">Id del tipo de máquina.</param>
        /// <returns></returns>
        public TipoDeMaquina GetTipoDeMaquinaById(int pid)
        {
            return UoW.TipoDeMaquinaRepository.GetById(pid);
        }

        /// <summary>
        /// Registra una instancia de tipo de máquina.
        /// </summary>
        /// <param name="pfoto">Foto del tipo de máquina.</param>
        /// <param name="pnombre">Nombre del tipo de máquina.</param>
        /// <param name="pdescripcion">Descripción del tipo de máquina.</param>
        /// <param name="phabilitado">Si es<c>true</c> [phabilitado].</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error agregando el tipo de máquina
        /// o
        /// Ha ocurrido un error agregando el tipo de máquina
        /// </exception>
        public void insertarTipoDeMaquina(byte[] pfoto, string pnombre, string pdescripcion)
        {
            TipoDeMaquina tipoDeMaquina = new TipoDeMaquina(pfoto, pnombre, pdescripcion);

            try
            {
                if (tipoDeMaquina.IsValid)
                {
                    UoW.TipoDeMaquinaRepository.Insert(tipoDeMaquina);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.TipoDeMaquinaRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Insertar tipo de máquina", "El usuario ha insertado un tipo de máquina " + tipoDeMaquina.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in tipoDeMaquina.GetRuleViolations())
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
                throw new DataAccessException("Ha ocurrido un error agregando el tipo de máquina");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando el tipo de máquina");
            }

        }

        /// <summary>
        /// Modificar una instancia de tipo de máquina.
        /// </summary>
        /// <param name="pid">Id del tipo de máquina.</param>
        /// <param name="pfoto">Foto del tipo de máquina.</param>
        /// <param name="pnombre">Nombre del tipo de máquina.</param>
        /// <param name="pdescripcion">Descripción del tipo de máquina.</param>
        /// <param name="phabilitado">Si es<c>true</c> [phabilitado].</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error modificando el tipo de máquina
        /// o
        /// Ha ocurrido un error modificando el tipo de máquina
        /// </exception>
        public void modificarTipoDeMaquina(int pid, byte[] pfoto, string pnombre, string pdescripcion, Boolean phabilitado)
        {
            TipoDeMaquina tipoDeMaquina = new TipoDeMaquina(pid, pfoto, pnombre, pdescripcion, phabilitado);

            try
            {
                if (tipoDeMaquina.IsValid)
                {
                    UoW.TipoDeMaquinaRepository.Update(tipoDeMaquina);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.TipoDeMaquinaRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Modificar tipo de máquina", "El usuario ha modificado un tipo de máquina " + tipoDeMaquina.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in tipoDeMaquina.GetRuleViolations())
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
                throw new DataAccessException("Ha ocurrido un error modificando el tipo de máquina");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error modificando el tipo de máquina");
            }
        }

        /// <summary>
        /// Eliminar una instancia de tipo de máquina.
        /// </summary>
        /// <param name="ptipoMaquina">La instancia de máquina a eliminar.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error eliminando el tipo de máquina
        /// o
        /// Ha ocurrido un error eliminando el tipo de máquina
        /// </exception>
        public void eliminarTipoDeMaquina(TipoDeMaquina ptipoMaquina)
        {
            try
            {
                if (ptipoMaquina.IsValid)
                {
                    UoW.TipoDeMaquinaRepository.Delete(ptipoMaquina);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.TipoDeMaquinaRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Eliminar tipo de máquina", "El usuario ha eliminado una máquina " + ptipoMaquina.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in ptipoMaquina.GetRuleViolations())
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
                throw new DataAccessException("Ha ocurrido un error eliminando el tipo de máquina");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error eliminando el tipo de máquina");
            }
        }

    }
}
