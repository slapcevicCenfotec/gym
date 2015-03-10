using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Ejercicio:IEntity
    {
        #region Attributes
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;
        public string Nombre 
        {
            get { return _nombre; }
            set{_nombre=value;}
        }

        private string _alias;
        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        private string _posicionInicial;
        public string PosicionInicial
        {
            get { return _posicionInicial; }
            set { _posicionInicial = value; }
        }

        private byte[] _posicionInicialImg;
        public byte[] PosicionInicialImg
        {
            get { return _posicionInicialImg; }
            set { _posicionInicialImg = value; }
        }

        private string _posicionFinal;
        public string PosicionFinal
        {
            get { return _posicionFinal; }
            set { _posicionFinal = value; }
        }

        private byte[] _posicionFinalImg;
        public byte[] PosicionFinalImg
        {
            get { return _posicionFinalImg; }
            set { _posicionFinalImg = value; }
        }

        private string _erroresComunes;
        public string ErroresComunes
        {
            get { return _erroresComunes; }
            set { _erroresComunes = value; }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        #endregion

        #region Contructors

        public Ejercicio(int pid,string pnombre,string palias,string pposicionInicial,string pposicionFinal
            , string perroresComunes,string pdescripcion)
        {
            Id = pid;
            Nombre = pnombre;
            Alias = palias;
            PosicionInicial = pposicionInicial;
            PosicionFinal = pposicionFinal;
            ErroresComunes = perroresComunes;
            Descripcion = pdescripcion;
        }
        public Ejercicio() { }

        public Ejercicio(byte[] pfoto) 
        {
            PosicionInicialImg = pfoto;
        }

        #endregion
    }
}
