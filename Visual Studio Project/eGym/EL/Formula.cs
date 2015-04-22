using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Formula : IEntity
    {
        #region Atributos

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _formulas;

        public String Formulas
        {
            get { return _formulas; }
            set { _formulas= value; }
        }


        private String _descripcion;

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        #endregion atributos

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }
        #region RuleViolations
        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (Id == null)
            {
                yield return new RuleViolation("Id es requerido", "Id");
            }
            if (String.IsNullOrEmpty(Formulas))
            {
                yield return new RuleViolation("Formula requerido", "Formula");
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
