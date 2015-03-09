using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
   public class Permiso
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
        #endregion atributos

        #region Constructores

        public Permiso(int pid,String pnombre)
        {
            Id = pid;
            Nombre = pnombre;
        }
        public Permiso()
        {
            Id = 0;
            Nombre = "Usuario";
        }

        #endregion Constructores

    }
}
