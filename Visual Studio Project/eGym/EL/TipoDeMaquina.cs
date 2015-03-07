using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EL
{
    public class TipoDeMaquina : IEntity
    {
        #region variables

        private int _id;
        private byte[] _foto;
        private string _nombre;
        private string _descripcion;
        private Boolean _habilitado;

        #endregion

        #region propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public byte[] Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Boolean Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        #endregion

        public TipoDeMaquina(int pid, byte[] pfoto, string pnombre, string pdescripcion, Boolean phabilitado)
        {
            Id = pid;
            Foto = pfoto;
            Nombre = pnombre;
            Descripcion = pdescripcion;
            Habilitado = phabilitado;
        }

        public TipoDeMaquina(byte[] pfoto, string pnombre, string pdescripcion, Boolean phabilitado)
        {
            Foto = pfoto;
            Nombre = pnombre;
            Descripcion = pdescripcion;
            Habilitado = phabilitado;
        }

        public TipoDeMaquina()
        {
            Foto = null;
            Nombre = "";
            Descripcion = "";
            Habilitado = true;
        }
    }
}
