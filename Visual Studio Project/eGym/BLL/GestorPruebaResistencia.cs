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
    public class GestorPruebaResistencia
    {
        private UnitOfWork UoW = new UnitOfWork();
        private GestorEvento gestorEventos = new GestorEvento();
        private GestorExcepcion gestorExcepciones = new GestorExcepcion();
        //<summary>
        // Autor:Alexis Soto
        // Fecha:03/15/2015
        // Descripcion: Devuelve una lista de gimnasios.
        // </summary>
        // <returns>IEnumerable<Gimnasio></returns>
        public IEnumerable<PruebaResistencia> listarPruebasResistencia()
        {
            return UoW.PruebaResistenciaRepository.GetAll();
        }

        public List<PruebaResistencia> obtenerPruebaResistencia(int id)
        {
            List<PruebaResistencia> listaPruebas = new List<PruebaResistencia>();
            listaPruebas.Add(UoW.PruebaResistenciaRepository.GetById(id));
            return listaPruebas;
        }

        public void ModificarPrueba(int pId, Double pPeso, int ptipoPrueba)
        {

            PruebaResistencia objPrueba = null;
            objPrueba = new PruebaResistencia();
            objPrueba.Id = pId;
            objPrueba.Peso = pPeso;
            objPrueba.IdTipoPrueba = ptipoPrueba;

            try
            {
                if (objPrueba.IsValid)
                {
                    UoW.PruebaResistenciaRepository.Update(objPrueba);
                    UoW.PruebaResistenciaRepository.Save();
                    gestorEventos.insertarEvento("Modificar Gimnasio", "El usuario a modificado el gimnasio " + objPrueba.Id + " al sistema.");

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objPrueba.GetRuleViolations())
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
    }



    }

