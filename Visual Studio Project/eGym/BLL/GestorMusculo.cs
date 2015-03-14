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
    public class GestorMusculo
    {
        private UnitOfWork Uow = new UnitOfWork();


        public IEnumerable<Musculo> listarMusculos()
        {
            return Uow.MusculoRepository.GetAll();      
        }

        public void agregarMusculo(string pnombre,string ubicacion , string origen, string inserccion , string inervacion, string irrigacion)
        {
            try
            {
                Musculo objMusculo = new Musculo(pnombre, ubicacion,origen, inserccion, inervacion, irrigacion);

                if (objMusculo.IsValid)
                {
                    Uow.MusculoRepository.Insert(objMusculo);
                    Uow.MusculoRepository.Save();

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

                throw new DataAccessException("Ha ocurrido un error agregando un musculo");
            }

        }

        public void modificarMusculo(int pid,string pnombre, string ubicacion, string origen, string inserccion, string inervacion, string irrigacion)
        {
            try
            {
                Musculo objMusculo = new Musculo(pid, pnombre, ubicacion, origen, inserccion, inervacion, irrigacion);

                if (objMusculo.IsValid)
                {
                    Uow.MusculoRepository.Update(objMusculo);
                    Uow.MusculoRepository.Save();

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

                throw new DataAccessException("Ha ocurrido un error agregando un musculo");
            }
        
        }
    }
}
