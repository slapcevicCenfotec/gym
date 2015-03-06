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
        //private Image _foto;
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

        //public Image Foto
        //{
        //    get { return _foto; }
        //    set { _foto = value; }
        //}

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

        //public TipoDeMaquina(string pnombre, string pdescripcion, Image pfoto)
        //{
         //   Nombre = pnombre;
           // Descripcion = pdescripcion;
           // Foto = pfoto;
        //}

        //public TipoDeMaquina()
        //{
        //    Nombre = "";
        //    Descripcion = "";
        //    Foto = null;
        //}
    }
}
