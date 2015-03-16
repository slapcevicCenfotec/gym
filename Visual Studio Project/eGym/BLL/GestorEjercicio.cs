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
    public class GestorEjercicio
    {
        private UnitOfWork Uow = new UnitOfWork();

        public IEnumerable<Ejercicio> listarEjercicios()
        {

            return Uow.EjercicioRepository.GetAll();
        }

        public void insertarEjercicio(string pnombre ,string palias,string pposicionInc,byte[] pposIncImg,
            string pposicionFinal , byte[] pposicionFinalImg, string perroresComunes,string pdescripcion,int pidMusculoPrincipal, string pmusculosSecundarios)
        {
            Ejercicio objEjercicio = new Ejercicio(pnombre, palias, pposicionInc, pposIncImg, pposicionFinal, pposicionFinalImg, perroresComunes, pdescripcion, pidMusculoPrincipal, pmusculosSecundarios);
            try
            {
                if (objEjercicio.IsValid)
                {
                    Uow.EjercicioRepository.Insert(objEjercicio);
                    Uow.EjercicioRepository.Save();
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

                throw new DataAccessException("Ha ocurrido un error agregando un ejercicio");
            }

            
            
        }

        public Ejercicio getImagenes(int pid)
        {
            return Uow.EjercicioRepository.GetById(pid);
        }

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

                throw new DataAccessException("Ha ocurrido un error agregando un musculo");
            }



        }
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

        public void eliminarEjercicio(Ejercicio pEjercicio)
        {
            Uow.EjercicioRepository.Delete(pEjercicio);
            Uow.EjercicioRepository.Save();
        }

    }
}
