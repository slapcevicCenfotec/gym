using DAL;
using EL;
using Exceptions.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorExcepcion
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void insertarExcepcion(String ptitulo, String pdescripcion)
        {

            Excepcion objExcepcion = new Excepcion(ptitulo, pdescripcion);

            try
            {
                if (objExcepcion.IsValid)
                {
                    UoW.ExcepcionRepository.Insert(objExcepcion);
                    UoW.ExcepcionRepository.Save();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objExcepcion.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
            catch (SqlException ex)
            {
                
            }
        }

    }
}
