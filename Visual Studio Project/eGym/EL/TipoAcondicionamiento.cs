using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL
{
    class TipoAcondicionamiento
    {
        private int _id;
        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
