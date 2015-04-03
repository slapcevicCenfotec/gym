using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Contacto
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set{ _id=value;}        
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private string parentesco;

        public string Parentesco
        {
            get { return parentesco; }
            set { parentesco = value; }
        }
        private Usuario _usuario;

        public Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
    }
}
