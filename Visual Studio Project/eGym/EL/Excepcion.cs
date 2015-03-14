using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Excepcion : IEntity
    {
        #region variables 

        private int _id;
        private String _titulo;
        private String _descripcion;
        private DateTime _fecha;

        #endregion

        #region propiedades
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        #endregion 

        #region validacion
        public Excepcion(int pid, String ptitulo, String pdescripcion, DateTime pfecha)
        {
            Id = pid;
            Titulo = ptitulo;
            Descripcion = pdescripcion;
            Fecha = pfecha;
        }

        public Excepcion(String ptitulo, String pdescripcion)
        {
            Titulo = ptitulo;
            Descripcion = pdescripcion;
        }

        public Excepcion(int pid, String ptitulo, String pdescripcion)
        {
            Id = pid;
            Titulo = ptitulo;
            Descripcion = pdescripcion;
        }

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(Titulo))
            {
                yield return new RuleViolation("Titulo requerido", "Titulo");
            }
            if (String.IsNullOrEmpty(Descripcion))
            {
                yield return new RuleViolation("Descripcion requerida", "Descripcion");
            }
            yield break;
        }
        #endregion
    }
}
