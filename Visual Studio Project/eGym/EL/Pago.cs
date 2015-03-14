using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Pago : IEntity
    {
        private int _id;
        private float _monto;
        private int _tipo;
        private DateTime _fecha;
        private DateTime _hasta;
        private DateTime _desde;
        private bool _habilitado;

      

        public Pago()
        { }
        public Pago(int pId)
        {
            this._id = pId;
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
            if (Monto == null)
            {
                yield return new RuleViolation("Monto es requerido", "Id");
            }
            if (Tipo == null)
            {
                yield return new RuleViolation("Tipo es requerido", "Id");
            }
            if (Fecha == null)
            {
                yield return new RuleViolation("Fecha es requerido", "Id");
            } if (Desde == null)
            {
                yield return new RuleViolation("Desde es requerido", "Id");
            } if (Hasta == null)
            {
                yield return new RuleViolation("Hasta es requerido", "Id");
            } if (Habilitado == null)
            {
                yield return new RuleViolation("Habilitado es requerido", "Id");
            }
            yield break;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public float Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
        

        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public DateTime Desde
        {
            get { return _desde; }
            set { _desde = value; }
        }
        

        public DateTime Hasta
        {
            get { return _hasta; }
            set { _hasta = value; }
        }

       
       
    }
}
