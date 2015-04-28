﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class TipoPruebaResistencia :IEntity
    {

        #region Atributos

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion
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
            if (String.IsNullOrEmpty(Nombre))
            {
                yield return new RuleViolation("Nombre requerido", "Nombre");
            }

            yield break;
        }
        #endregion

       #region Constructores

         public TipoPruebaResistencia(int pid,String pnombre)
        {
            Id = pid;
            Nombre = pnombre;
        }
         public TipoPruebaResistencia()
        {
           
        }

        #endregion Constructores
    }
}
