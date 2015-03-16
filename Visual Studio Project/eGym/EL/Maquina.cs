using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
/// <summary>
/// Fecha de creación: 07/03/2015:
/// Autor: Mauricio Fernández Mora
/// Fecha de modificación: 14/03/2015
/// Modificado por: Mauricio Fernández Mora
/// </summary>
/// 
namespace EL
{
    public class Maquina : IEntity
    {
        #region Variables

        private int _id;
        private string _numeroActivo;
        private string _numeroMaquina;
        private Boolean _habilitado;
        private int _tipoDeMaquina;
        private string _nombreTipoMaquina;

        #endregion

        #region Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string NumeroActivo
        {
            get { return _numeroActivo; }
            set { _numeroActivo = value; }
        }

        public string NumeroMaquina
        {
            get { return _numeroMaquina; }
            set { _numeroMaquina = value; }
        }

        public Boolean Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public int TipoDeMaquina
        {
            get { return _tipoDeMaquina; }
            set { _tipoDeMaquina = value; }
        }

        public string NombreTipoMaquina
        {
            get { return _nombreTipoMaquina; }
            set { _nombreTipoMaquina = value; }
        }

        #endregion

        #region Constructores

                public Maquina(int pid, string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
                {
                    Id = pid;
                    NumeroActivo = pnumeroActivo;
                    NumeroMaquina = pnumeroMaquina;
                    Habilitado = phabilitado;
                    TipoDeMaquina = ptipoDeMaquina;
                }

                public Maquina(string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
                {
                    NumeroActivo = pnumeroActivo;
                    NumeroMaquina = pnumeroMaquina;
                    Habilitado = phabilitado;
                    TipoDeMaquina = ptipoDeMaquina;
                }

                public Maquina(string pnumeroActivo, string pnumeroMaquina, int ptipoDeMaquina)
                {
                    NumeroActivo = pnumeroActivo;
                    NumeroMaquina = pnumeroMaquina;
                    Habilitado = true;
                    TipoDeMaquina = ptipoDeMaquina;
                }

                public Maquina()
                {
                    NumeroActivo = "";
                    NumeroMaquina = "";
                    Habilitado = true;
                    TipoDeMaquina = 0;
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
            if (String.IsNullOrEmpty(NumeroMaquina))
            {
                yield return new RuleViolation("Número de máquina es requerido", "Número de Máquina");
            }
            if (String.IsNullOrEmpty(NumeroActivo))
            {
                yield return new RuleViolation("Número de activo es requerido", "Número de Activo");
            }
            if (Habilitado == null)
            {
                yield return new RuleViolation("Debe asignarse una estado", "Habilitado");
            }
            if (TipoDeMaquina == null)
            {
                yield return new RuleViolation("Tipo de máquina asociado es requerido", "Tipo de Máquina");
            }
            yield break;
        }
    }
}
