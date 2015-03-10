using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Musculo : IEntity
    {
        #region Atributos

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }

        }

        private string _ubicacion;
        public string Ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; }
        }

        private string _origen;
        public string Origen
        {
            get { return _origen; }
            set { _origen = value; }

        }

        private string _inserccion;
        public String Inserccion
        {
            get { return _inserccion; }
            set { _inserccion = value; }
        }

        private string _inervacion;
        public string Inervacion
        {
            get { return _inervacion; }
            set { _inervacion = value; }
        }

        private string _irrigacion;
        public string Irrigacion
        {
            get { return _irrigacion; }
            set { _irrigacion = value; }
        }


        #endregion

        #region Constructor

        public Musculo() { }

        public Musculo(string pnombre,string pubicacion, string porigen, string pinserccion ,string pinervacion, string pirrigacion)
        {
            Nombre = pnombre;
            Ubicacion = pubicacion;
            Origen = porigen;
            Inserccion=pinserccion;
            Inervacion = pinervacion;
            Irrigacion=pirrigacion;
        }
        public Musculo(int pid, string pnombre, string pubicacion, string porigen, string pinserccion, string pinervacion, string pirrigacion)
        {
            Id = pid;
            Nombre = pnombre;
            Ubicacion = pubicacion;
            Origen = porigen;
            Inserccion = pinserccion;
            Inervacion = pinervacion;
            Irrigacion = pirrigacion;
        }


        #endregion

        #region Reglas de objeto

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "Nombre");
            }

            if (String.IsNullOrEmpty(Ubicacion))
            {
                yield return new RuleViolation("Ubicaion es requerida", "Ubicacion");
            }
            if (String.IsNullOrEmpty(Origen))
            {
                yield return new RuleViolation("Origen es requerida", "Origen");
            }
            if (String.IsNullOrEmpty(Inserccion))
            {
                yield return new RuleViolation("Inserccion es requerida", "Inserccion");
            }
            if (String.IsNullOrEmpty(Inervacion))
            {
                yield return new RuleViolation("Inervacion es requerida", "Inervacion");
            }
            if (String.IsNullOrEmpty(Irrigacion))
            {
                yield return new RuleViolation("Irrigacion es requerida", "Irrigacion");
            }

            yield break;

        }

        #endregion


        int IEntity.Id
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
