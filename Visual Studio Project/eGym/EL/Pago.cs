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
