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
