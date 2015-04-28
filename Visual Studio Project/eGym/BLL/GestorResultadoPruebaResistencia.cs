using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;
using Exceptions.CustomExceptions;
using System.Data.SqlClient;

namespace BLL
{
    public class GestorResultadoPruebaResistencia
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void insertarResultadoPrueba(int pidEjercicio, int pseries, int prepeticiones, Double ppeso, Double prm1,int pidPrueba)
        {

            ResultadoPruebaResistencia objPrueba = null;
            objPrueba = new ResultadoPruebaResistencia();
            objPrueba.IdEjericio = pidEjercicio;
            objPrueba.Series = pseries;
            objPrueba.Repeticiones = prepeticiones;
            objPrueba.Peso = ppeso;
            objPrueba.Rm1 = prm1;
            objPrueba.IdPrueba = pidPrueba;
            UoW.ResultadoPruebaResistencia.Insert(objPrueba);
            UoW.ResultadoPruebaResistencia.Save();


        }

    }
}
