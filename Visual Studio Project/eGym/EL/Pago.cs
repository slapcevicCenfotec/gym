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
        private string _factura;
        private double _monto;
        private int _tipo;
        private DateTime _hasta;
        private DateTime _desde;
        private DateTime _fecha;
        private bool _habilitado;
        private int _usuario;
        private string _tipoDePago;
        private string _nombreCliente;

       
        
        

      

        public Pago()
        { }
        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }

        public string TipoDePago
        {
            get { return _tipoDePago; }
            set { _tipoDePago = value; }
        }


        public Pago(int pId)
        {
            this._id = pId;
        }
        public Pago(string pFactura, double pMonto, int pTipo, DateTime pHasta, DateTime pDesde, int pUsuario)
        {
            this.Factura = pFactura;
            this.Monto = pMonto;
            this.Tipo = pTipo;
            this.Hasta = pHasta;
            this.Desde = pDesde;
            this.User = pUsuario;
        
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
            if (Desde == null)
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
        

        public double Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
        public string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public int User
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
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
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
       
       
    }
}
