using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EventoCalendario : IEntity
    {
        #region variables 

        private int _id;
        private int _usuario;
        private int _tipo;
        private String _titulo;
        private String _descripcion;
        private DateTime _fechaInicial;
        private DateTime _fechaFinal;
        private bool _habilitado;

        #endregion

        #region propiedades
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
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
        public DateTime FechaInicial
        {
            get { return _fechaInicial; }
            set { _fechaInicial = value; }
        }
        public DateTime FechaFinal
        {
            get { return _fechaFinal; }
            set { _fechaFinal = value; }
        }
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
        #endregion 

        #region validacion

        public EventoCalendario()
        {
            
        }
        public EventoCalendario(int pId)
        {
            this._id = pId;
        }
        public EventoCalendario(int pId, int pUsuario, int pTipo, String pTitulo, String pDescripcion, DateTime pFechaInicial, DateTime pFechaFinal)
        {
            this._id = pId;
            this._usuario = pUsuario;
            this._tipo = pTipo;
            this._titulo = pTitulo;
            this._descripcion = pDescripcion;
            this._fechaInicial = pFechaInicial;
            this._fechaFinal = pFechaFinal;
        }

        public EventoCalendario(int pUsuario, int pTipo, String pTitulo, String pDescripcion, DateTime pFechaInicial, DateTime pFechaFinal)
        {
            this._usuario = pUsuario;
            this._tipo = pTipo;
            this._titulo = pTitulo;
            this._descripcion = pDescripcion;
            this._fechaInicial = pFechaInicial;
            this._fechaFinal = pFechaFinal;
        }

       

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (Id == null)
            {
                yield return new RuleViolation("Id es requerido", "Id");
            }
            if (Tipo == null)
            {
                yield return new RuleViolation("Tipo es requerido", "Tipo");
            }
            if (Usuario == null)
            {
                yield return new RuleViolation("Usuario es requerido", "Usuario");
            }
            if (String.IsNullOrEmpty(Titulo))
            {
                yield return new RuleViolation("Titulo requerido", "Titulo");
            }
            if (String.IsNullOrEmpty(Descripcion))
            {
                yield return new RuleViolation("Descripcion requerida", "Descripcion");
            }
            if (String.IsNullOrEmpty(FechaInicial.ToString()))
            {
                yield return new RuleViolation("FechaInicial requerida", "FechaInicial");
            }
            if (String.IsNullOrEmpty(FechaFinal.ToString()))
            {
                yield return new RuleViolation("FechaFinal requerida", "FechaFinal");
            }
            yield break;
        }
        #endregion
    }
}
