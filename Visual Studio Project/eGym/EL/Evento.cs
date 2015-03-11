using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Evento : IEntity
    {
        #region variables 

        private int _id;
        private String _titulo;
        private String _descripcion;
        private DateTime _fecha;
        private String _usuario;

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
        public String Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        #endregion 

        #region validacion
        public Evento(int pid, String ptitulo, String pdescripcion, DateTime pfecha, String pusuario)
        {
            Id = pid;
            Titulo = ptitulo;
            Descripcion = pdescripcion;
            Fecha = pfecha;
            Usuario = pusuario;
        }

        public Evento(String ptitulo, String pdescripcion, String pusuario)
        {
            Titulo = ptitulo;
            Descripcion = pdescripcion;
            Usuario = pusuario;
        }

        public Evento(int pid, String ptitulo, String pdescripcion, String pusuario)
        {
            Id = pid;
            Titulo = ptitulo;
            Descripcion = pdescripcion;
            Usuario = pusuario;
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
            if (String.IsNullOrEmpty(Usuario))
            {
                yield return new RuleViolation("Usuario requerido", "Usuario");
            }
            yield break;
        }
        #endregion
    }
}
