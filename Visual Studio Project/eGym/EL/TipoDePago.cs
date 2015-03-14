using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class TipoDePago : IEntity
    {
        private int _id;
        private String _nombre;
        private float _monto;
        private int _duracion;
        private bool _habilitado;

        public TipoDePago()
        { }
        public TipoDePago(int pId)
        {
            this._id = pId;
        }
        public TipoDePago(String pNommbre, float pMonto, int pDuracion)
        {
            this._nombre = pNommbre;
            this._monto = pMonto;
            this._duracion = pDuracion;
        }
        public TipoDePago(int pId, String pNommbre, float pMonto, int pDuracion, bool pHabilitado)
        {
            this._id = pId;
            this._nombre = pNommbre;
            this._monto = pMonto;
            this._duracion = pDuracion;
            this._habilitado = pHabilitado;
        }
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }
        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            int auxNumber;
            bool isNumeric = int.TryParse(Duracion.ToString(), out auxNumber);
            if (Id == null)
            {
                yield return new RuleViolation("Id es requerido", "Id");
            }
            if (Nombre == null)
            {
                yield return new RuleViolation("Nombre es requerido", "Nombre");
            }
            if (Monto == null)
            {
                yield return new RuleViolation("Monto es requerido", "Monto");
            }
            if (Duracion == null)
            {
                yield return new RuleViolation("Duracion  es requerido", "Duracion");
            }
    
            yield break;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public float Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
        public int Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
    }
}
