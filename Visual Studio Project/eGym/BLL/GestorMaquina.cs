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

    public class GestorMaquina
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
        /// Lista cada una de las instancias de máquina.
        /// </summary>
        /// <returns></returns>
        public List<Maquina> listarMaquinas()
        {
            return UoW.MaquinaRepository.GetAll().ToList<Maquina>();
        }

        /// <summary>
        /// Lista cada una de las instancias de máquina para web services.
        /// </summary>
        /// <returns></returns>
        public List<Maquina> listarMaquinasServices()
        {
            return UoW.MaquinaRepository.GetAll().ToList<Maquina>();
        }

        /// <summary>
        /// Obtiene una instancia de maquina por Id.
        /// </summary>
        /// <param name="pid">Id de la máquina.</param>
        /// <returns></returns>
        public Maquina GetMaquinaById(int pid)
        {
            return UoW.MaquinaRepository.GetById(pid);
        }

        /// <summary>
        /// Registra una instancia de máquina.
        /// </summary>
        /// <param name="pnumeroActivo">Número de activo de la máquina.</param>
        /// <param name="pnumeroMaquina">Número de máquina de la máquina.</param>
        /// <param name="ptipoDeMaquina">Id del tipo de máquina asociado a la máquina.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error agregando la máquina
        /// or
        /// Ha ocurrido un error agregando la máquina
        /// </exception>
        public void insertarMaquina(string pnumeroActivo, string pnumeroMaquina, int ptipoDeMaquina)
        {
            Maquina maquina = new Maquina(pnumeroActivo, pnumeroMaquina, ptipoDeMaquina);

            try
            {
                if (maquina.IsValid)
                {
                    UoW.MaquinaRepository.Insert(maquina);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.MaquinaRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Insertar máquina", "El usuario ha insertado una máquina con número de activo " + maquina.NumeroActivo + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in maquina.GetRuleViolations())
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
                throw new DataAccessException("Ha ocurrido un error agregando la máquina");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando la máquina");
            }

        }

        /// <summary>
        /// Modificar una instancia de máquina.
        /// </summary>
        /// <param name="pid">The pid.</param>
        /// <param name="pnumeroActivo">Número de activo de la máquina.</param>
        /// <param name="pnumeroMaquina">Número de máquina de la máquina.</param>
        /// <param name="phabilitado">Si es<c>true</c> [phabilitado].</param>
        /// <param name="ptipoDeMaquina">Id del tipo de máquina asociado a la máquina.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error modificando la máquina
        /// or
        /// Ha ocurrido un error modificando la máquina
        /// </exception>
        public void modificarMaquina(int pid, string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
        {
            Maquina maquina = new Maquina(pid, pnumeroActivo, pnumeroMaquina, phabilitado, ptipoDeMaquina);

            try
            {
                if (maquina.IsValid)
                {
                    UoW.MaquinaRepository.Update(maquina);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.MaquinaRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Modificar máquina", "El usuario ha modificado una máquina con número de activo " + maquina.NumeroActivo + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in maquina.GetRuleViolations())
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
                throw new DataAccessException("Ha ocurrido un error modificando la máquina");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error modificando la máquina");
            }
        }

        /// <summary>
        /// Eliminar una instancia de máquina.
        /// </summary>
        /// <param name="pmaquina">La instancia de la máquina a eliminar.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error eliminando la máquina
        /// or
        /// Ha ocurrido un error eliminando la máquina
        /// </exception>
        public void eliminarMaquina(Maquina pmaquina)
        {
            try
            {
                if (pmaquina.IsValid)
                {
                    UoW.MaquinaRepository.Delete(pmaquina);

                    /// <summary>
                    ///Guarda los cambios.
                    /// </summary>
                    UoW.MaquinaRepository.Save();

                    //Registra la acción en la bitácora de acciones.
                    gestorEventos.insertarEvento("Eliminar máquina", "El usuario ha eliminado una máquina con número de activo " + pmaquina.NumeroActivo + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in pmaquina.GetRuleViolations())
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
                throw new DataAccessException("Ha ocurrido un error eliminando la máquina");
            }
            catch (Exception ex)
            {
                //Registra la excepción en la bitácora de excepciones.
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error eliminando la máquina");
            }
        }

    }
}
