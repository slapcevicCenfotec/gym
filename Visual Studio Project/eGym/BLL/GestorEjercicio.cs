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
    /// Descripcion: Esta clase se encarga de manejar los metodos de insercion, modificaion y eliminacionpara de los músculo del sistema
    /// </summary>
    public class GestorEjercicio
    {
        private UnitOfWork Uow = new UnitOfWork();
        private GestorExcepcion gestorExcepciones = new GestorExcepcion();
        private GestorEvento gestorEventos = new GestorEvento();

        /// <summary>
        /// Autor:Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripcion: Esta metodo devuelve una lista de eC:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\DAL\Repositories\EjercicioRepository.csjercicios
        /// </summary>
        /// <returns>List<Ejercicio></returns>
        public List<Ejercicio> listarEjercicios()
        {
            return Uow.EjercicioRepository.GetAll().ToList<Ejercicio>();
        }
        /// <summary>
        /// Autor:Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripcion: Esta metodo insertar un nuevo ejercicio
        /// 
        /// </summary>
        /// <param name="pnombre"></param>
        /// <param name="palias"></param>
        /// <param name="pposicionInc"></param>
        /// <param name="pposIncImg"></param>
        /// <param name="pposicionFinal"></param>
        /// <param name="pposicionFinalImg"></param>
        /// <param name="perroresComunes"></param>
        /// <param name="pdescripcion"></param>
        /// <param name="pidMusculoPrincipal"></param>
        /// <param name="pmusculosSecundarios"></param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error agregando el ejercicio
        /// or
        /// Ha ocurrido un error agregando el ejercicio
        /// </exception>
        public void insertarEjercicio(string pnombre ,string palias,string pposicionInc,byte[] pposIncImg,
            string pposicionFinal , byte[] pposicionFinalImg, string perroresComunes,string pdescripcion,int pidMusculoPrincipal, string pmusculosSecundarios)
        {
            Ejercicio objEjercicio = new Ejercicio(pnombre, palias, pposicionInc, pposIncImg, pposicionFinal, pposicionFinalImg, perroresComunes, pdescripcion, pidMusculoPrincipal, pmusculosSecundarios);
            try
            {
                //if (objEjercicio.IsValid)
                //{
                    Uow.EjercicioRepository.Insert(objEjercicio);
                    Uow.EjercicioRepository.Save();

                //    gestorEventos.insertarEvento("Insertar ejercicio", "El usuario ha insertado un ejercicio " + objEjercicio.Nombre + " al sistema.");
                //}
                //else 
                //{
                //    StringBuilder sb = new StringBuilder();
                //    foreach (RuleViolation rv in objEjercicio.GetRuleViolations())
                //    {
                //        sb.AppendLine(rv.ErrorMessage);
                //    }
                //    throw new BusinessLogicException(sb.ToString());
                
                //}
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando un ejercicio");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando el ejercicio");
            }
            
            
        }


        /// <summary>
        /// Autor:Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripción : metodo que devueve la imagenes de como realizar el ejercicio
        /// </summary>
        /// <param name="pid"></param>
        /// <returns>Ejericio</returns>
        /// 
        public Ejercicio getEjercicio(int pid)
        {
            return Uow.EjercicioRepository.GetById(pid);
        }

       
        /// <summary>
        /// Autor:Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripción : metodo que modificar la información de un ejericio
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="pnombre"></param>
        /// <param name="palias"></param>
        /// <param name="pposicionInc"></param>
        /// <param name="pposIncImg"></param>
        /// <param name="pposicionFinal"></param>
        /// <param name="pposicionFinalImg"></param>
        /// <param name="perroresComunes"></param>
        /// <param name="pdescripcion"></param>
        /// <param name="pidMusculoPrincipal"></param>
        /// <param name="pmusculosSecundarios"></param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error modificando el ejercicio
        /// or
        /// Ha ocurrido un error modificando el ejercicio
        /// </exception>
        public void modificarEjercicio(int pid, string pnombre, string palias, string pposicionInc, byte[] pposIncImg,
            string pposicionFinal, byte[] pposicionFinalImg, string perroresComunes, string pdescripcion, int pidMusculoPrincipal, string pmusculosSecundarios)
        {
            try
            {
                Ejercicio objEjercicio = new Ejercicio(pid, pnombre, palias, pposicionInc, pposIncImg, pposicionFinal, pposicionFinalImg, perroresComunes, pdescripcion, pidMusculoPrincipal, pmusculosSecundarios);

                if (objEjercicio.IsValid)
                {
                    Uow.EjercicioRepository.Update(objEjercicio);
                    Uow.EjercicioRepository.Save();

                    gestorEventos.insertarEvento("Modificar Ejercicio", "El usuario ha modificado el ejercicio " + objEjercicio.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (RuleViolation rv in objEjercicio.GetRuleViolations())
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
                throw new DataAccessException("Ha ocurrido un error agregando el rol");
            }


        }

        /// <summary>
        /// Autor:Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripción : metodo que retorna el músculo principal asociado a un ejercicio
        /// </summary>
        /// <param name="pid"></param>
        /// <returns> Musculo </returns>
        public Musculo getMusculoPrincipal(int pid)
        {

            Musculo objMusculo = null;


            var sqlQuery = "SELECT E.ID_MUSCULO, M.[NOMBRE] FROM [T_MUSCULO_EJERCICIO] E JOIN [dbo].[T_MUSCULO] M ON(E.ID_MUSCULO=M.ID) WHERE E.ID_EJERCICIO = @idEjercicio AND E.[tipoRelacion] = 'Principal'";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idEjercicio", pid);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objMusculo = new Musculo
                {
                    Id = Convert.ToInt32(dr["ID_MUSCULO"]),
                    Nombre = dr["NOMBRE"].ToString(),
                };

            }

            return objMusculo;

        }

        /// <summary>
        /// Autor:Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripción : metodo que retorna una lista de musculos secundarios
        /// </summary>
        /// <param name="pid"></param>
        /// <returns>List<Musculo></returns>
        public List<Musculo> getMusculoSecundarios(int pid)
        {

            List<Musculo> objMusculos = new List<Musculo>();

            var sqlQuery = "SELECT E.ID_MUSCULO, M.[NOMBRE] FROM [T_MUSCULO_EJERCICIO] E JOIN [dbo].[T_MUSCULO] M ON(E.ID_MUSCULO=M.ID) WHERE E.ID_EJERCICIO = @idEjercicio AND E.[tipoRelacion] = 'Secundario'";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idEjercicio", pid);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var dr = ds.Tables[0].Rows[i];

                    objMusculos.Add(new Musculo
                    {
                        Id = Convert.ToInt32(dr["ID_MUSCULO"]),
                        Nombre = dr["NOMBRE"].ToString(),
                    });
                }
                
            }

            return objMusculos;

        }

        /// <summary>
        /// Autor:Danny Espinoza
        /// Fecha:03/15/2015
        /// Descripción : metodo quq elimina un ejercicio
        /// </summary>
        /// <param name="pEjercicio"></param>
        public void eliminarEjercicio(Ejercicio pEjercicio)
        {
            try
            {
                if (pEjercicio.IsValid)
                {
                    Uow.EjercicioRepository.Delete(pEjercicio);
                    Uow.EjercicioRepository.Save();
                    gestorEventos.insertarEvento("Eliminar ejercicio", "El usuario ha Eliminado el ejercicio " + pEjercicio.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in pEjercicio.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
               
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error Eliminando el ejercicio");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error Eliminiado el ejercicio");
            }
            
        }

    }
}
