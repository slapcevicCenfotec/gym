using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL
{
    public class EjercicioPrograma : IEntity
    {
        private int _id;
        private int _series;
        private int _repeticiones;
        private float _peso;
        private int _semana;
        private Ejercicio _ejercicio;
        private TipoMedida _tipoMedida;
        private int _idPrograma;

        public int IdPrograma
        {
            get { return _idPrograma; }
            set { _idPrograma = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public int Series
        {
            get { return _series; }
            set { _series = value; }
        }
       

        public int Repeticiones
        {
            get { return _repeticiones; }
            set { _repeticiones = value; }
        }
        

        public float Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
        

        public int Semana
        {
            get { return _semana; }
            set { _semana = value; }
        }
        

        public Ejercicio Ejercicio
        {
            get { return _ejercicio; }
            set { _ejercicio = value; }
        }
        

        public TipoMedida TipoMedida
        {
            get { return _tipoMedida; }
            set { _tipoMedida = value; }
        }
    }
}
