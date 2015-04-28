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

          public ResultadoPruebaResistencia(int pid,int pidEjercicio,int pseries,int prepeticiones, double p1Rm,int pidPrueba)
        {
            Id = pid;
            IdEjericio = pidEjercicio;
            Series = pseries;
            Repeticiones = prepeticiones;
            Rm1 = p1Rm;
            IdPrueba = pidPrueba;
        }
                 public ResultadoPruebaResistencia()
        {
           
        }
                #endregion Constructores
    }
}
