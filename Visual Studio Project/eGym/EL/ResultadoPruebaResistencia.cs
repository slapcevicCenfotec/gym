using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ResultadoPruebaResistencia : IEntity
    {
        #region Atributos
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _idEjericio;
        
        public int IdEjericio
        {
            get { return _idEjericio; }
            set { _idEjericio = value; }
        }

        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _series;

        public int Series
        {
            get { return _series; }
            set { _series = value; }
        }
        private int _repeticiones;

        public int Repeticiones
        {
            get { return _repeticiones; }
            set { _repeticiones = value; }
        }

        private Double _peso;

        public Double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        private Double _prc1;

        public Double Prc1
        {
            get { return _prc1; }
            set { _prc1 = value; }
        }

        private Double _prc2;

        public Double Prc2
        {
            get { return _prc2; }
            set { _prc2 = value; }
        }

        private Double _prc3;

        public Double Prc3
        {
            get { return _prc3; }
            set { _prc3 = value; }
        }

        private Double _1Rm;

        public Double Rm1
        {
            get { return _1Rm; }
            set { _1Rm = value; }
        }
        private int _idPrueba;

        public int IdPrueba
        {
            get { return _idPrueba; }
            set { _idPrueba = value; }
        }
        #endregion
         #region Constructores

        public ResultadoPruebaResistencia(int pid, int pidEjercicio, int pseries, int prepeticiones, double p1Rm, int pidPrueba, Double ppeso, Double pprc1, Double pprc2, Double pprc3)
        {
            Id = pid;
            IdEjericio = pidEjercicio;
            Series = pseries;
            Repeticiones = prepeticiones;
            Rm1 = p1Rm;
            IdPrueba = pidPrueba;
            Peso = ppeso;
            Prc1 = pprc1;
            Prc2 = pprc2;
            Prc3 = pprc3;
        }
                 public ResultadoPruebaResistencia()
        {
           
        }
                #endregion Constructores
    }
}
