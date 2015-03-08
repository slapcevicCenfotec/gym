using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

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
                 
                    //for (RuleViolation rv in objMusculo.GetRuleViolations())
                    //{
                    //    sb.AppendLine(rv.ErrorMessage);
                    //}
                }

            }
            catch (Exception)
            {

                throw;
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

                    //for (RuleViolation rv in objMusculo.GetRuleViolations())
                    //{
                    //    sb.AppendLine(rv.ErrorMessage);
                    //}
                }

            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
}
