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
        private decimal _peso;
        private decimal _altura;
        private decimal _imc;
        private string _clasificacionIMC;
        private decimal _porcentajeGrasaCorporal;
        private decimal _porcentajeMasaMuscular;
        private decimal _pesoGraso;
        private decimal _perBicepsIzquierdo;
        private decimal _perBicepsDerecho;
        private decimal _perBicepsIzqContraido;
        private decimal _perBicepsDerContraido;
        private decimal _perPantorrillaIzquierda;
        private decimal _perPantorrillaDerecha;
        private decimal _perMusloIzquierdo;
        private decimal _perMusloDerecho;
        private decimal _perCintura;
        private decimal _perAbdomen;
        private decimal _perCadera;
        private decimal _perPecho;
        private decimal _perEspalda;
        private decimal _pliTricepsIzquierdo;
        private decimal _pliTricepsDerecho;
        private decimal _pliSubescapularIzquierdo;
        private decimal _pliSubescapularDerecho;
        private decimal _pliSupraespinalIzquierdo;
        private decimal _pliSupraespinalDerecho;
        private decimal _pliAbdominalIzquierdo;
        private decimal _pliAbdominalDerecho;
        private decimal _pliMusloIzquierdo;
        private decimal _pliMusloDerecho;
        private decimal _pliPantorrillaIzquierda;
        private decimal _pliPantorrillaDerecha;
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

        public decimal Peso
        {
          get { return _peso; }
          set { _peso = value; }
        }

        public decimal Altura
        {
          get { return _altura; }
          set { _altura = value; }
        }

        public decimal Imc
        {
          get { return _imc; }
          set { _imc = value; }
        }

        public string ClasificacionIMC
        {
          get { return _clasificacionIMC; }
          set { _clasificacionIMC = value; }
        }

        public decimal PorcentajeGrasaCorporal
        {
          get { return _porcentajeGrasaCorporal; }
          set { _porcentajeGrasaCorporal = value; }
        }

        public decimal PorcentajeMasaMuscular
        {
          get { return _porcentajeMasaMuscular; }
          set { _porcentajeMasaMuscular = value; }
        }

        public decimal PesoGraso
        {
          get { return _pesoGraso; }
          set { _pesoGraso = value; }
        }

        public decimal PerBicepsIzquierdo
        {
          get { return _perBicepsIzquierdo; }
          set { _perBicepsIzquierdo = value; }
        }

        public decimal PerBicepsDerecho
        {
          get { return _perBicepsDerecho; }
          set { _perBicepsDerecho = value; }
        }

        public decimal PerBicepsIzqContraido
        {
          get { return _perBicepsIzqContraido; }
          set { _perBicepsIzqContraido = value; }
        }

        public decimal PerBicepsDerContraido
        {
          get { return _perBicepsDerContraido; }
          set { _perBicepsDerContraido = value; }
        }

        public decimal PerPantorrillaIzquierda
        {
          get { return _perPantorrillaIzquierda; }
          set { _perPantorrillaIzquierda = value; }
        }

        public decimal PerPantorrillaDerecha
        {
          get { return _perPantorrillaDerecha; }
          set { _perPantorrillaDerecha = value; }
        }

        public decimal PerMusloIzquierdo
        {
          get { return _perMusloIzquierdo; }
          set { _perMusloIzquierdo = value; }
        }

        public decimal PerMusloDerecho
        {
          get { return _perMusloDerecho; }
          set { _perMusloDerecho = value; }
        }

        public decimal PerCintura
        {
          get { return _perCintura; }
          set { _perCintura = value; }
        }

        public decimal PerAbdomen
        {
          get { return _perAbdomen; }
          set { _perAbdomen = value; }
        }

        public decimal PerCadera
        {
          get { return _perCadera; }
          set { _perCadera = value; }
        }

        public decimal PerPecho
        {
          get { return _perPecho; }
          set { _perPecho = value; }
        }

        public decimal PerEspalda
        {
          get { return _perEspalda; }
          set { _perEspalda = value; }
        }

        public decimal PliTricepsIzquierdo
        {
          get { return _pliTricepsIzquierdo; }
          set { _pliTricepsIzquierdo = value; }
        }

        public decimal PliTricepsDerecho
        {
          get { return _pliTricepsDerecho; }
          set { _pliTricepsDerecho = value; }
        }

        public decimal PliSubescapularIzquierdo
        {
          get { return _pliSubescapularIzquierdo; }
          set { _pliSubescapularIzquierdo = value; }
        }

        public decimal PliSubescapularDerecho
        {
          get { return _pliSubescapularDerecho; }
          set { _pliSubescapularDerecho = value; }
        }

        public decimal PliSupraespinalIzquierdo
        {
          get { return _pliSupraespinalIzquierdo; }
          set { _pliSupraespinalIzquierdo = value; }
        }

        public decimal PliSupraespinalDerecho
        {
          get { return _pliSupraespinalDerecho; }
          set { _pliSupraespinalDerecho = value; }
        }

        public decimal PliAbdominalIzquierdo
        {
          get { return _pliAbdominalIzquierdo; }
          set { _pliAbdominalIzquierdo = value; }
        }

        public decimal PliAbdominalDerecho
        {
            get { return _pliAbdominalDerecho; }
            set { _pliAbdominalDerecho = value; }
        }

        public decimal PliMusloIzquierdo
        {
          get { return _pliMusloIzquierdo; }
          set { _pliMusloIzquierdo = value; }
        }

        public decimal PliMusloDerecho
        {
          get { return _pliMusloDerecho; }
          set { _pliMusloDerecho = value; }
        }

        public decimal PliPantorrillaIzquierda
        {
          get { return _pliPantorrillaIzquierda; }
          set { _pliPantorrillaIzquierda = value; }
        }

        public decimal PliPantorrillaDerecha
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

        public FichaMedicion(int pid, int pcliente, DateTime pfecha, decimal ppeso, decimal paltura, decimal pimc, string pclasificacionimc,
                            decimal pporcentajeGrasaCorporal, decimal pporcentajeMasaMuscular, decimal ppesoGraso, decimal pperBicepsIzquierdo,
                            decimal pperBicepsDerecho, decimal pperBicepsIzqContraido, decimal pperBicepsDerContraido, decimal pperPantorrillaIzquierda,
                            decimal pperPantorrillaDerecha, decimal pperMusloIzquierdo, decimal pperMusloDerecho, decimal pperCintura, decimal pperAbdomen,
                            decimal pperCadera, decimal pperPecho, decimal pperEspalda, decimal ppliTricepsIzquierdo, decimal ppliTricepsDerecho,
                            decimal ppliSubescapularIzquierdo, decimal ppliSubescapularDerecho, decimal ppliSupraespinalIzquierdo, decimal ppliSupraespinalDerecho,
                            decimal ppliAbdominalIzquierdo, decimal ppliAbdominalDerecho, decimal ppliMusloIzquierdo, decimal ppliMusloDerecho,
                            decimal ppliPantorrillaIzquierda, decimal ppliPantorrillaDerecha, Boolean phabilitado)
        {
            Id = pid;
            Cliente = pcliente;
            FechaCreacion = pfecha;
            Peso = ppeso;
            Altura = paltura;
            Imc = pimc;
            ClasificacionIMC = pclasificacionimc;
            PorcentajeGrasaCorporal = pporcentajeGrasaCorporal;
            PorcentajeMasaMuscular = pporcentajeMasaMuscular;
            PesoGraso = ppesoGraso;
            PerBicepsIzquierdo = pperBicepsIzquierdo;
            PerBicepsDerecho = pperBicepsDerecho;
            PerBicepsIzqContraido = pperBicepsIzqContraido;
            PerBicepsDerContraido = pperBicepsDerContraido;
            PerPantorrillaIzquierda = pperPantorrillaIzquierda;
            PerPantorrillaDerecha = pperPantorrillaDerecha;
            PerMusloIzquierdo = pperMusloIzquierdo;
            PerMusloDerecho = pperMusloDerecho;
            PerCintura = pperCintura;
            PerAbdomen = pperAbdomen;
            PerCadera = pperCadera;
            PerPecho = pperPecho;
            PerEspalda = pperEspalda;
            PliTricepsIzquierdo = ppliTricepsIzquierdo;
            PliTricepsDerecho = ppliTricepsDerecho;
            PliSubescapularIzquierdo = ppliSubescapularIzquierdo;
            PliSubescapularDerecho = ppliSubescapularDerecho;
            PliSupraespinalIzquierdo = ppliSupraespinalIzquierdo;
            PliSupraespinalDerecho = ppliSupraespinalDerecho;
            PliAbdominalIzquierdo = ppliAbdominalIzquierdo;
            PliAbdominalDerecho = ppliAbdominalDerecho;
            PliMusloIzquierdo = ppliMusloIzquierdo;
            PliMusloDerecho = ppliMusloDerecho;
            PliPantorrillaIzquierda = ppliPantorrillaIzquierda;
            PliPantorrillaDerecha = ppliPantorrillaDerecha;
            Habilitado = phabilitado;
        }

        public FichaMedicion(int pcliente, DateTime pfecha, decimal ppeso, decimal paltura, decimal pimc, string pclasificacionimc,
                            decimal pporcentajeGrasaCorporal, decimal pporcentajeMasaMuscular, decimal ppesoGraso, decimal pperBicepsIzquierdo,
                            decimal pperBicepsDerecho, decimal pperBicepsIzqContraido, decimal pperBicepsDerContraido, decimal pperPantorrillaIzquierda,
                            decimal pperPantorrillaDerecha, decimal pperMusloIzquierdo, decimal pperMusloDerecho, decimal pperCintura, decimal pperAbdomen,
                            decimal pperCadera, decimal pperPecho, decimal pperEspalda, decimal ppliTricepsIzquierdo, decimal ppliTricepsDerecho,
                            decimal ppliSubescapularIzquierdo, decimal ppliSubescapularDerecho, decimal ppliSupraespinalIzquierdo, decimal ppliSupraespinalDerecho,
                            decimal ppliAbdominalIzquierdo, decimal ppliAbdominalDerecho, decimal ppliMusloIzquierdo, decimal ppliMusloDerecho,
                            decimal ppliPantorrillaIzquierda, decimal ppliPantorrillaDerecha)
        {
            Cliente = pcliente;
            FechaCreacion = pfecha;
            Peso = ppeso;
            Altura = paltura;
            Imc = pimc;
            ClasificacionIMC = pclasificacionimc;
            PorcentajeGrasaCorporal = pporcentajeGrasaCorporal;
            PorcentajeMasaMuscular = pporcentajeMasaMuscular;
            PesoGraso = ppesoGraso;
            PerBicepsIzquierdo = pperBicepsIzquierdo;
            PerBicepsDerecho = pperBicepsDerecho;
            PerBicepsIzqContraido = pperBicepsIzqContraido;
            PerBicepsDerContraido = pperBicepsDerContraido;
            PerPantorrillaIzquierda = pperPantorrillaIzquierda;
            PerPantorrillaDerecha = pperPantorrillaDerecha;
            PerMusloIzquierdo = pperMusloIzquierdo;
            PerMusloDerecho = pperMusloDerecho;
            PerCintura = pperCintura;
            PerAbdomen = pperAbdomen;
            PerCadera = pperCadera;
            PerPecho = pperPecho;
            PerEspalda = pperEspalda;
            PliTricepsIzquierdo = ppliTricepsIzquierdo;
            PliTricepsDerecho = ppliTricepsDerecho;
            PliSubescapularIzquierdo = ppliSubescapularIzquierdo;
            PliSubescapularDerecho = ppliSubescapularDerecho;
            PliSupraespinalIzquierdo = ppliSupraespinalIzquierdo;
            PliSupraespinalDerecho = ppliSupraespinalDerecho;
            PliAbdominalIzquierdo = ppliAbdominalIzquierdo;
            PliAbdominalDerecho = ppliAbdominalDerecho;
            PliMusloIzquierdo = ppliMusloIzquierdo;
            PliMusloDerecho = ppliMusloDerecho;
            PliPantorrillaIzquierda = ppliPantorrillaIzquierda;
            PliPantorrillaDerecha = ppliPantorrillaDerecha;
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
            PerBicepsIzquierdo = 0;
            PerBicepsDerecho = 0;
            PerBicepsIzqContraido = 0;
            PerBicepsDerContraido = 0;
            PerPantorrillaIzquierda = 0;
            PerPantorrillaDerecha = 0;
            PerMusloIzquierdo = 0;
            PerMusloDerecho = 0;
            PerCintura = 0;
            PerAbdomen = 0;
            PerCadera = 0;
            PerPecho = 0;
            PerEspalda = 0;
            PliTricepsIzquierdo = 0;
            PliTricepsDerecho = 0;
            PliSubescapularIzquierdo = 0;
            PliSubescapularDerecho = 0;
            PliSupraespinalIzquierdo = 0;
            PliSupraespinalDerecho = 0;
            PliAbdominalIzquierdo = 0;
            PliAbdominalDerecho = 0;
            PliMusloIzquierdo = 0;
            PliMusloDerecho = 0;
            PliPantorrillaIzquierda = 0;
            PliPantorrillaDerecha = 0;
            Habilitado = true;
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
