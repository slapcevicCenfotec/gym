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

    public class GestorMaquina
    {
        private UnitOfWork UoW = new UnitOfWork();

        public IEnumerable<Maquina> listarMaquinas()
        {
            return UoW.MaquinaRepository.GetAll();
        }

        public Maquina GetMaquinaById(int pid)
        {
            return UoW.MaquinaRepository.GetById(pid);
        }

        public void insertarMaquina(string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
        {
            Maquina maquina = new Maquina(pnumeroActivo, pnumeroMaquina, phabilitado, ptipoDeMaquina);

            try
            {
                if (maquina.IsValid)
                {
                    UoW.MaquinaRepository.Insert(maquina);
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
            catch(Exception ex)
            {
                //logear la excepcion a la bd con un Exception
                //gestorBitacoraErrores.agregarBitacoraErrores();
                //gestorBitacoraErrores.guardarCambios();
            }

            try
            {
                UoW.MaquinaRepository.Save();
                //gestorBitacoraAcciones.agregarBitacoraAcciones();
                //gestorBitacoraAcciones.guardarCambiosAcciones();
                //throw new DataAccessException("Ha ocurrido un error al agregar una carrera", ex);
 
            }
            catch(DataAccessException ex)
            {
                //gestorBitacoraErrores.agregarBitacoraErrores(ex.StackTrace, "Carrera", ex.InnerException.ToString(), ex.Message);
                //gestorBitacoraErrores.guardarCambios();

            }

        }

        public void modificarMaquina(int pid, string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
        {
            Maquina Maquina = new Maquina(pid, pnumeroActivo, pnumeroMaquina, phabilitado, ptipoDeMaquina);
            UoW.MaquinaRepository.Update(Maquina);
            UoW.MaquinaRepository.Save();
        }

        public void eliminarMaquina(Maquina ptipoMaquina)
        {
            UoW.MaquinaRepository.Delete(ptipoMaquina);
            UoW.MaquinaRepository.Save();
        }

    }
}
