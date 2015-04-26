using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
/// <summary>
/// Fecha de creación: 04/02/2015
/// Autor: Mauricio Fernández Mora
/// Fecha de modificación: 04/02/2015
/// Modificado por: Mauricio Fernández Mora
/// </summary>
/// 
namespace EL
{
    public class FichaMedicion : IEntity
    {
        #region Variables

        private int _id;
        private int _cliente;
        private DateTime _fechaCreacion;
        private float _peso;
        private float _altura;
        private float _imc;
        private string _clasificacionIMC;
        private float _porcentajeGrasaCorporal;
        private float _porcentajeMasaMuscular;
        private float _pesoGraso;
        private float _perBicepsIzquierdo;
        private float _perBicepsDerecho;
        private float _perBicepsIzqContraido;
        private float _perBicepsDerContraido;
        private float _perPantorrillaIzquierda;
        private float _perPantorrillaDerecha;
        private float _perMusloIzquierdo;
        private float _perMusloDerecho;
        private float _perCintura;
        private float _perAbdomen;
        private float _perCadera;
        private float _perPecho;
        private float _perEspalda;
        private float _pliTricepsIzquierdo;
        private float _pliTricepsDerecho;
        private float _pliSubescapularIzquierdo;
        private float _pliSubescapularDerecho;
        private float _pliSupraespinalIzquierdo;
        private float _pliSupraespinalDerecho;
        private float _pliAbdominalIzquierdo;
        private float _pliAbdominalDerecho;
        private float _pliMusloIzquierdo;
        private float _pliMusloDerecho;
        private float _pliPantorrillaIzquierda;
        private float _pliPantorrillaDerecha;
        private Boolean _habilitado;

        #endregion

        #region Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public DateTime FechaCreacion
        {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }
        }

        public float Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public float Imc
        {
            get { return _imc; }
            set { _imc = value; }
        }

        public string ClasificacionIMC
        {
            get { return _clasificacionIMC; }
            set { _clasificacionIMC = value; }
        }

        public float PorcentajeGrasaCorporal
        {
            get { return _porcentajeGrasaCorporal; }
            set { _porcentajeGrasaCorporal = value; }
        }

        public float PorcentajeMasaMuscular
        {
            get { return _porcentajeMasaMuscular; }
            set { _porcentajeMasaMuscular = value; }
        }

        public float PesoGraso
        {
            get { return _pesoGraso; }
            set { _pesoGraso = value; }
        }

        public float PerBicepsIzquierdo
        {
            get { return _perBicepsIzquierdo; }
            set { _perBicepsIzquierdo = value; }
        }

        public float PerBicepsDerecho
        {
            get { return _perBicepsDerecho; }
            set { _perBicepsDerecho = value; }
        }

        public float PerBicepsIzqContraido
        {
            get { return _perBicepsIzqContraido; }
            set { _perBicepsIzqContraido = value; }
        }

        public float PerBicepsDerContraido
        {
            get { return _perBicepsDerContraido; }
            set { _perBicepsDerContraido = value; }
        }

        public float PerPantorrillaIzquierda
        {
            get { return _perPantorrillaIzquierda; }
            set { _perPantorrillaIzquierda = value; }
        }

        public float PerPantorrillaDerecha
        {
            get { return _perPantorrillaDerecha; }
            set { _perPantorrillaDerecha = value; }
        }

        public float PerMusloIzquierdo
        {
            get { return _perMusloIzquierdo; }
            set { _perMusloIzquierdo = value; }
        }

        public float PerMusloDerecho
        {
            get { return _perMusloDerecho; }
            set { _perMusloDerecho = value; }
        }

        public float PerCintura
        {
            get { return _perCintura; }
            set { _perCintura = value; }
        }

        public float PerAbdomen
        {
            get { return _perAbdomen; }
            set { _perAbdomen = value; }
        }

        public float PerCadera
        {
            get { return _perCadera; }
            set { _perCadera = value; }
        }

        public float PerPecho
        {
            get { return _perPecho; }
            set { _perPecho = value; }
        }

        public float PerEspalda
        {
            get { return _perEspalda; }
            set { _perEspalda = value; }
        }

        public float PliTricepsIzquierdo
        {
            get { return _pliTricepsIzquierdo; }
            set { _pliTricepsIzquierdo = value; }
        }

        public float PliTricepsDerecho
        {
            get { return _pliTricepsDerecho; }
            set { _pliTricepsDerecho = value; }
        }

        public float PliSubescapularIzquierdo
        {
            get { return _pliSubescapularIzquierdo; }
            set { _pliSubescapularIzquierdo = value; }
        }

        public float PliSubescapularDerecho
        {
            get { return _pliSubescapularDerecho; }
            set { _pliSubescapularDerecho = value; }
        }

        public float PliSupraespinalIzquierdo
        {
            get { return _pliSupraespinalIzquierdo; }
            set { _pliSupraespinalIzquierdo = value; }
        }

        public float PliSupraespinalDerecho
        {
            get { return _pliSupraespinalDerecho; }
            set { _pliSupraespinalDerecho = value; }
        }

        public float PliAbdominalIzquierdo
        {
            get { return _pliAbdominalIzquierdo; }
            set { _pliAbdominalIzquierdo = value; }
        }

        public float PliAbdominalDerecho
        {
            get { return _pliAbdominalDerecho; }
            set { _pliAbdominalDerecho = value; }
        }

        public float PliMusloIzquierdo
        {
            get { return _pliMusloIzquierdo; }
            set { _pliMusloIzquierdo = value; }
        }

        public float PliMusloDerecho
        {
            get { return _pliMusloDerecho; }
            set { _pliMusloDerecho = value; }
        }

        public float PliPantorrillaIzquierda
        {
            get { return _pliPantorrillaIzquierda; }
            set { _pliPantorrillaIzquierda = value; }
        }

        public float PliPantorrillaDerecha
        {
            get { return _pliPantorrillaDerecha; }
            set { _pliPantorrillaDerecha = value; }
        }

        public Boolean Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        #endregion

        #region Constructores

        public FichaMedicion(int pid, int pcliente, float ppeso, float paltura, float pimc, string pclasificacionimc,
                            float pporcentajeGrasaCorporal, float pporcentajeMasaMuscular, float ppesoGraso, float pperCintura, float pperCadera,
                            float pperAbdomen, float pperPecho, float pperEspalda, float pperMusloIzquierdo, float pperMusloDerecho,
                            float pperBicepsIzquierdo, float pperBicepsDerecho, float pperBicepsIzqContraido, float pperBicepsDerContraido,
                            float pperPantorrillaIzquierda, float pperPantorrillaDerecha, float ppliAbdominalIzquierdo, float ppliAbdominalDerecho,
                            float ppliMusloIzquierdo, float ppliMusloDerecho, float ppliPantorrillaIzquierda, float ppliPantorrillaDerecha,
                            float ppliTricepsIzquierdo, float ppliTricepsDerecho, float ppliSubescapularIzquierdo, float ppliSubescapularDerecho,
                            float ppliSupraespinalIzquierdo, float ppliSupraespinalDerecho, Boolean phabilitado)
        {
            Id = pid;
            Cliente = pcliente;
            Peso = ppeso;
            Altura = paltura;
            Imc = pimc;
            ClasificacionIMC = pclasificacionimc;
            PorcentajeGrasaCorporal = pporcentajeGrasaCorporal;
            PorcentajeMasaMuscular = pporcentajeMasaMuscular;
            PesoGraso = ppesoGraso;
            PerCintura = pperCintura;
            PerCadera = pperCadera;
            PerAbdomen = pperAbdomen;
            PerPecho = pperPecho;
            PerEspalda = pperEspalda;
            PerMusloIzquierdo = pperMusloIzquierdo;
            PerMusloDerecho = pperMusloDerecho;
            PerBicepsIzquierdo = pperBicepsIzquierdo;
            PerBicepsDerecho = pperBicepsDerecho;
            PerBicepsIzqContraido = pperBicepsIzqContraido;
            PerBicepsDerContraido = pperBicepsDerContraido;
            PerPantorrillaIzquierda = pperPantorrillaIzquierda;
            PerPantorrillaDerecha = pperPantorrillaDerecha;
            PliAbdominalIzquierdo = ppliAbdominalIzquierdo;
            PliAbdominalDerecho = ppliAbdominalDerecho;
            PliMusloIzquierdo = ppliMusloIzquierdo;
            PliMusloDerecho = ppliMusloDerecho;
            PliPantorrillaIzquierda = ppliPantorrillaIzquierda;
            PliPantorrillaDerecha = ppliPantorrillaDerecha;
            PliTricepsIzquierdo = ppliTricepsIzquierdo;
            PliTricepsDerecho = ppliTricepsDerecho;
            PliSubescapularIzquierdo = ppliSubescapularIzquierdo;
            PliSubescapularDerecho = ppliSubescapularDerecho;
            PliSupraespinalIzquierdo = ppliSupraespinalIzquierdo;
            PliSupraespinalDerecho = ppliSupraespinalDerecho;
            Habilitado = phabilitado;
        }

        public FichaMedicion(int pcliente, float ppeso, float paltura, float pimc, string pclasificacionimc,
                            float pporcentajeGrasaCorporal, float pporcentajeMasaMuscular, float ppesoGraso, float pperCintura, float pperCadera,
                            float pperAbdomen, float pperPecho, float pperEspalda, float pperMusloIzquierdo, float pperMusloDerecho,
                            float pperBicepsIzquierdo, float pperBicepsDerecho, float pperBicepsIzqContraido, float pperBicepsDerContraido,
                            float pperPantorrillaIzquierda, float pperPantorrillaDerecha, float ppliAbdominalIzquierdo, float ppliAbdominalDerecho,
                            float ppliMusloIzquierdo, float ppliMusloDerecho, float ppliPantorrillaIzquierda, float ppliPantorrillaDerecha,
                            float ppliTricepsIzquierdo, float ppliTricepsDerecho, float ppliSubescapularIzquierdo, float ppliSubescapularDerecho,
                            float ppliSupraespinalIzquierdo, float ppliSupraespinalDerecho)
        {
            Cliente = pcliente;
            Peso = ppeso;
            Altura = paltura;
            Imc = pimc;
            ClasificacionIMC = pclasificacionimc;
            PorcentajeGrasaCorporal = pporcentajeGrasaCorporal;
            PorcentajeMasaMuscular = pporcentajeMasaMuscular;
            PesoGraso = ppesoGraso;
            PerCintura = pperCintura;
            PerCadera = pperCadera;
            PerAbdomen = pperAbdomen;
            PerPecho = pperPecho;
            PerEspalda = pperEspalda;
            PerMusloIzquierdo = pperMusloIzquierdo;
            PerMusloDerecho = pperMusloDerecho;
            PerBicepsIzquierdo = pperBicepsIzquierdo;
            PerBicepsDerecho = pperBicepsDerecho;
            PerBicepsIzqContraido = pperBicepsIzqContraido;
            PerBicepsDerContraido = pperBicepsDerContraido;
            PerPantorrillaIzquierda = pperPantorrillaIzquierda;
            PerPantorrillaDerecha = pperPantorrillaDerecha;
            PliAbdominalIzquierdo = ppliAbdominalIzquierdo;
            PliAbdominalDerecho = ppliAbdominalDerecho;
            PliMusloIzquierdo = ppliMusloIzquierdo;
            PliMusloDerecho = ppliMusloDerecho;
            PliPantorrillaIzquierda = ppliPantorrillaIzquierda;
            PliPantorrillaDerecha = ppliPantorrillaDerecha;
            PliTricepsIzquierdo = ppliTricepsIzquierdo;
            PliTricepsDerecho = ppliTricepsDerecho;
            PliSubescapularIzquierdo = ppliSubescapularIzquierdo;
            PliSubescapularDerecho = ppliSubescapularDerecho;
            PliSupraespinalIzquierdo = ppliSupraespinalIzquierdo;
            PliSupraespinalDerecho = ppliSupraespinalDerecho;
            Habilitado = true;
        }

        public FichaMedicion()
        {
            Cliente = 0;
            FechaCreacion = DateTime.MinValue;
            Peso = 0;
            Altura = 0;
            Imc = 0;
            ClasificacionIMC = "";
            PorcentajeGrasaCorporal = 0;
            PorcentajeMasaMuscular = 0;
            PesoGraso = 0;
            PerCintura = 0;
            PerCadera = 0;
            PerAbdomen = 0;
            PerPecho = 0;
            PerEspalda = 0;
            PerMusloIzquierdo = 0;
            PerMusloDerecho = 0;
            PerBicepsIzquierdo = 0;
            PerBicepsDerecho = 0;
            PerBicepsIzqContraido = 0;
            PerBicepsDerContraido = 0;
            PerPantorrillaIzquierda = 0;
            PerPantorrillaDerecha = 0;
            PliAbdominalIzquierdo = 0;
            PliAbdominalDerecho = 0;
            PliMusloIzquierdo = 0;
            PliMusloDerecho = 0;
            PliPantorrillaIzquierda = 0;
            PliPantorrillaDerecha = 0;
            PliTricepsIzquierdo = 0;
            PliTricepsDerecho = 0;
            PliSubescapularIzquierdo = 0;
            PliSubescapularDerecho = 0;
            PliSupraespinalIzquierdo = 0;
            PliSupraespinalDerecho = 0;
            Habilitado = true;
        }

        public FichaMedicion(int pid)
        {
            Id = pid;
            Cliente = 0;
            FechaCreacion = DateTime.MinValue;
            Peso = 0;
            Altura = 0;
            Imc = 0;
            ClasificacionIMC = "eliminar";
            PorcentajeGrasaCorporal = 0;
            PorcentajeMasaMuscular = 0;
            PesoGraso = 0;
            PerCintura = 0;
            PerCadera = 0;
            PerAbdomen = 0;
            PerPecho = 0;
            PerEspalda = 0;
            PerMusloIzquierdo = 0;
            PerMusloDerecho = 0;
            PerBicepsIzquierdo = 0;
            PerBicepsDerecho = 0;
            PerBicepsIzqContraido = 0;
            PerBicepsDerContraido = 0;
            PerPantorrillaIzquierda = 0;
            PerPantorrillaDerecha = 0;
            PliAbdominalIzquierdo = 0;
            PliAbdominalDerecho = 0;
            PliMusloIzquierdo = 0;
            PliMusloDerecho = 0;
            PliPantorrillaIzquierda = 0;
            PliPantorrillaDerecha = 0;
            PliTricepsIzquierdo = 0;
            PliTricepsDerecho = 0;
            PliSubescapularIzquierdo = 0;
            PliSubescapularDerecho = 0;
            PliSupraespinalIzquierdo = 0;
            PliSupraespinalDerecho = 0;
            Habilitado = false;
        }

        #endregion

        /// <summary>
        /// Valida si esta instancia es válida.
        /// </summary>
        /// <value>
        ///   <c>true</c> Si esta instancia es válida; de lo contrario, <c>false</c>.
        /// </value>
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        /// <summary>
        /// Obtiene todos los rule violations.
        /// </summary>
        /// <returns>
        /// Lista tipo IEnumerable<RuleViolation>
        /// </returns>
        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (Id == null)
            {
                yield return new RuleViolation("Id es requerido", "Id");
            }
            if (Cliente == null)
            {
                yield return new RuleViolation("Cliente es requerido", "Id Cliente");
            }
            if (FechaCreacion == null)
            {
                yield return new RuleViolation("Fecha de creación es requerida", "Fecha de creación");
            }
            if (Peso == null)
            {
                yield return new RuleViolation("El peso es requerido", "Peso");
            }
            if (Altura == null)
            {
                yield return new RuleViolation("La altura es requerida", "Altura");
            }
            if (Imc == null)
            {
                yield return new RuleViolation("El IMC es requerido", "IMC");
            }
            if (String.IsNullOrEmpty(ClasificacionIMC))
            {
                yield return new RuleViolation("La clasificación del IMC es requerida", "Clasificación del IMC");
            }
            if (PorcentajeGrasaCorporal == null)
            {
                yield return new RuleViolation("El porcentaje de grasa corporal es requerido", "Porcentaje de grasa corporal");
            }
            if (PorcentajeMasaMuscular == null)
            {
                yield return new RuleViolation("El porcentaje de masa muscular es requerido", "Porcentaje de masa muscular");
            }
            if (PesoGraso == null)
            {
                yield return new RuleViolation("El peso graso es requerido", "Peso Graso ");
            }
            if (PerBicepsIzquierdo == null)
            {
                yield return new RuleViolation("", "Perímetro Biceps Izquierdo ");
            }
            if (PerBicepsDerecho == null)
            {
                yield return new RuleViolation("El perímetro de bíceps derecho es requerido", "Perímetro Biceps Derecho");
            }
            if (PerBicepsIzqContraido == null)
            {
                yield return new RuleViolation("El perímetro de bíceps izquierdo contraido es requerido", "Perímetro Biceps Izquierdo Contraido");
            }
            if (PerBicepsDerContraido == null)
            {
                yield return new RuleViolation("El perímetro de bíceps derecho contraido es requerido", "Perímetro Biceps derecho Contraido");
            }
            if (PerPantorrillaIzquierda == null)
            {
                yield return new RuleViolation("El perímetro de la pantorrilla izquierda es requerido", "Perímetro pantorrilla izquierda");
            }
            if (PerPantorrillaDerecha == null)
            {
                yield return new RuleViolation("El perímetro de la pantorrilla derecha es requerido", "Perímetro pantorrilla derecha");
            }
            if (PerMusloIzquierdo == null)
            {
                yield return new RuleViolation("El perímetro del muslo izquierdo es requerido", "Perímetro muslo derecho");
            }
            if (PerMusloDerecho == null)
            {
                yield return new RuleViolation("El perímetro del muslo derecho es requerido", "Perímetro muslo derecho");
            }
            if (PerCintura == null)
            {
                yield return new RuleViolation("El perímetro de la cintura es requerido", "Perímetro cintura");
            }
            if (PerAbdomen == null)
            {
                yield return new RuleViolation("El perímetro de la cintura es requerido", "Perímetro cintura");
            }
            if (PerCadera == null)
            {
                yield return new RuleViolation("El perímetro de la cadera es requerido", "Perímetro cadera");
            }
            if (PerPecho == null)
            {
                yield return new RuleViolation("El perímetro del pecho es requerido", "Perímetro pecho");
            }
            if (PerEspalda == null)
            {
                yield return new RuleViolation("El perímetro de la espalda es requerido", "Perímetro espalda");
            }
            if (PliTricepsIzquierdo == null)
            {
                yield return new RuleViolation("El pliegue tríceps izquierdo es requerido", "Perímetro tríceps izquierdo");
            }
            if (PliTricepsDerecho == null)
            {
                yield return new RuleViolation("El pliegue tríceps derecho es requerido", "Pliegue tríceps derecho");
            }
            if (PliSubescapularIzquierdo == null)
            {
                yield return new RuleViolation("El pliegue subescapular izquierdo es requerido", "Pliegue subescapular izquierdo");
            }
            if (PliSubescapularDerecho == null)
            {
                yield return new RuleViolation("El pliegue subescapular derecho es requerido", "Pliegue subescapular derecho");
            }
            if (PliSupraespinalIzquierdo == null)
            {
                yield return new RuleViolation("El pliegue supraespinal izquierdo es requerido", "Pliegue supraespinal izquierdo");
            }
            if (PliSupraespinalDerecho == null)
            {
                yield return new RuleViolation("El pliegue del supraespinal derecho es requerido", "Pliegue supraespinal derecho");
            }
            if (PliAbdominalIzquierdo == null)
            {
                yield return new RuleViolation("El pliegue abdominal izquierdo es requerido", "Pliegue abdominal izquierdo");
            }
            if (PliAbdominalDerecho == null)
            {
                yield return new RuleViolation("El pliegue abdominal derecho es requerido", "Pliegue abdominal derecho");
            }
            if (PliMusloIzquierdo == null)
            {
                yield return new RuleViolation("El pliegue del muslo izquierdo es requerido", "Pliegue muslo izquierdo");
            }
            if (PliMusloDerecho == null)
            {
                yield return new RuleViolation("El pliegue del muslo derecho es requerido", "Pliegue muslo derecho");
            }
            if (PliPantorrillaIzquierda == null)
            {
                yield return new RuleViolation("El pliegue de la pantorrilla izquierda es requerido", "Pliegue pantorrilla izquierda");
            }
            if (PliPantorrillaDerecha == null)
            {
                yield return new RuleViolation("El pliegue de la pantorrilla derecha es requerido", "Pliegue pantorrilla derecha");
            }
            yield break;
        }
    }
}
