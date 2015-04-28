using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
   public class PruebaResistencia : IEntity
    {
        #region Atributos
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Double _peso;

        public Double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private int _idUsuario;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private String _nombreUsuario;

        public String NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        private String _nombrePrueba;

        public String NombrePrueba
        {
            get { return _nombrePrueba; }
            set { _nombrePrueba = value; }
        }

        private int _idTipoPrueba;

        public int IdTipoPrueba
        {
            get { return _idTipoPrueba; }
            set { _idTipoPrueba = value; }
        }

        private List<ResultadoPruebaResistencia> _listaPruebas;

        public List<ResultadoPruebaResistencia> ListaPruebas
        {
            get { return _listaPruebas; }
            set { _listaPruebas = value; }
        }

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        #endregion atributos

         #region RuleViolations
         public IEnumerable<RuleViolation> GetRuleViolations()
         {
             if (Id == null)
             {
                 yield return new RuleViolation("Id es requerido", "Id");
             }


             yield break;
         }     
         #endregion
                 #region Constructores

                 public PruebaResistencia(int pid,Double ppeso,DateTime pfecha,String pNombreUsuario,int pidUsuario,int ptipoPrueba)
        {
            Id = pid;
            Peso = ppeso;
            Fecha = pfecha;
            NombreUsuario = pNombreUsuario;
            IdUsuario = pidUsuario;
            IdTipoPrueba = ptipoPrueba;
        }
                 public PruebaResistencia()
        {
           
        }
                #endregion Constructores
    }
}
