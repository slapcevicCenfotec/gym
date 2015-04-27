using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL
{
    public class TipoMedida
    {
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


    }
}
