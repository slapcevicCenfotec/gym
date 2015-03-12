using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EL
{
    public class Maquina : IEntity
    {
        #region variables

        private int _id;
        private string _numeroActivo;
        private string _numeroMaquina;
        private Boolean _habilitado;
        private int _tipoDeMaquina;
        private string _nombreTipoMaquina;

        #endregion

        #region propiedades

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

                public Maquina(string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, string pnombretipoDeMaquina)
                {
                    NumeroActivo = pnumeroActivo;
                    NumeroMaquina = pnumeroMaquina;
                    Habilitado = phabilitado;
                    NombreTipoMaquina = pnombretipoDeMaquina;
                }

                public Maquina()
                {
                    NumeroActivo = "";
                    NumeroMaquina = "";
                    Habilitado = true;
                    TipoDeMaquina = 0;
                }

        #endregion

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
