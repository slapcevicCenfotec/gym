using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class TipoAcondicionamiento : IEntity
    {
        private int _id;
        private String _nombre;

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

    }
}
