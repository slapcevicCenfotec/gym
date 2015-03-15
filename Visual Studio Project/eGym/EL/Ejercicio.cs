using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Ejercicio:IEntity
    {
        #region Attributes
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
            set{_nombre=value;}
        }

        private string _alias;
        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        private string _posicionInicial;
        public string PosicionInicial
        {
            get { return _posicionInicial; }
            set { _posicionInicial = value; }
        }

        private byte[] _posicionInicialImg;
        public byte[] PosicionInicialImg
        {
            get { return _posicionInicialImg; }
            set { _posicionInicialImg = value; }
        }

        private string _posicionFinal;
        public string PosicionFinal
        {
            get { return _posicionFinal; }
            set { _posicionFinal = value; }
        }

        private byte[] _posicionFinalImg;
        public byte[] PosicionFinalImg
        {
            get { return _posicionFinalImg; }
            set { _posicionFinalImg = value; }
        }

        private string _erroresComunes;
        public string ErroresComunes
        {
            get { return _erroresComunes; }
            set { _erroresComunes = value; }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int _idMusculoPrincipal;
        public int IdMusculoPrincipal
        {
            get { return _idMusculoPrincipal; }
            set { _idMusculoPrincipal = value; }
        }

        private string _musculosSecundarios;
        public string MusculosSecundarios
        {
            get { return _musculosSecundarios; }
            set { _musculosSecundarios = value; }
        }
        #endregion

        #region Contructors

        public Ejercicio(int pid,string pnombre,string palias,string pposicionInicial,string pposicionFinal
            , string perroresComunes,string pdescripcion)
        {
            Id = pid;
            Nombre = pnombre;
            Alias = palias;
            PosicionInicial = pposicionInicial;
            PosicionFinal = pposicionFinal;
            ErroresComunes = perroresComunes;
            Descripcion = pdescripcion;
        }
        public Ejercicio() { }


        public Ejercicio(int pid, string pnombre, string palias, string pposicionInicial, byte[] pfotoPosInc, string pposicionFinal, byte[] pfotoPosFinal
           , string perroresComunes, string pdescripcion, int pidMusculoPrincipal, String pmusculosSecundarios)
        {
            Id = pid;
            Nombre = pnombre;
            Alias = palias;
            PosicionInicial = pposicionInicial;
            PosicionFinal = pposicionFinal;
            ErroresComunes = perroresComunes;
            Descripcion = pdescripcion;
            PosicionInicialImg = pfotoPosInc;
            PosicionFinalImg = pfotoPosFinal;
            IdMusculoPrincipal = pidMusculoPrincipal;
            MusculosSecundarios = pmusculosSecundarios;
        }

        public Ejercicio(string pnombre, string palias, string pposicionInicial, byte[] pfotoPosInc, string pposicionFinal, byte[] pfotoPosFinal
            , string perroresComunes,string pdescripcion,int pidMusculoPrincipal , String pmusculosSecundarios) 
        {
            Nombre = pnombre;
            Alias = palias;
            PosicionInicial = pposicionInicial;
            PosicionFinal = pposicionFinal;
            ErroresComunes = perroresComunes;
            Descripcion = pdescripcion;
            PosicionInicialImg = pfotoPosInc;
            PosicionFinalImg = pfotoPosFinal;
            IdMusculoPrincipal = pidMusculoPrincipal;
            MusculosSecundarios = pmusculosSecundarios;
        }

        #endregion

        #region Reglas de objeto

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }        
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "Nombre");
            }
            if (string.IsNullOrEmpty(Alias))
            {
                yield return new RuleViolation("Alias Requerido", "Alias");
            }
            if (string.IsNullOrEmpty(PosicionInicial))
            {
                yield return new RuleViolation("Posicion Inicial Requerida", "PosicionInicial");
            }
            if (string.IsNullOrEmpty(PosicionFinal))
            {
                yield return new RuleViolation("Posicion Final Requerida", "PosicionFinal");
            }
            if (string.IsNullOrEmpty(ErroresComunes))
            {
                yield return new RuleViolation("Errores Comunes Requerido", "ErroresComunes");
            }
            if (string.IsNullOrEmpty(Descripcion))
            {
                yield return new RuleViolation("Descripcion Requerido", "Descripcion");
            }
        
        
        }


        #endregion
    }
}
