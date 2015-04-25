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
    public class GestorEvento
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void insertarEvento(String ptitulo, String pdescripcion)
        {

            //String nombreUsuario = GestorSesion.usuarioSesion.Nombre + " " + GestorSesion.usuarioSesion.Apellido;
            String nombreUsuario = "Alexis";
            Evento objEvento = new Evento(ptitulo, pdescripcion, nombreUsuario);

            try
            {
                if (objEvento.IsValid)
                {
                    UoW.EventoRepository.Insert(objEvento);
                    UoW.EventoRepository.Save();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objEvento.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("Ha ocurrido un error agregando el evento");
            }
        }

    }
}
