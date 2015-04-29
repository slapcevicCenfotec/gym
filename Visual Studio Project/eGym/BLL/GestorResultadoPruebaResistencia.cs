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

        public void insertarResultadoPrueba(int pidEjercicio, int pseries, int prepeticiones, Double ppeso, Double prm1,int pidPrueba,Double pprc1,Double pprc2,Double pprc3)
        {

            ResultadoPruebaResistencia objPrueba = null;
            objPrueba = new ResultadoPruebaResistencia();
            objPrueba.IdEjericio = pidEjercicio;
            objPrueba.Series = pseries;
            objPrueba.Repeticiones = prepeticiones;
            objPrueba.Peso = ppeso;
            objPrueba.Rm1 = prm1;
            objPrueba.IdPrueba = pidPrueba;
            objPrueba.Prc1 = pprc1;
            objPrueba.Prc2 = pprc2;
            objPrueba.Prc3 = pprc3;
            UoW.ResultadoPruebaResistencia.Insert(objPrueba);
            UoW.ResultadoPruebaResistencia.Save();


        }

        public void EliminarResultadoPrueba(int pid)
        {

            ResultadoPruebaResistencia objPrueba = null;
            objPrueba = new ResultadoPruebaResistencia();
            objPrueba.Id = pid;

            UoW.ResultadoPruebaResistencia.Delete(objPrueba);
            UoW.ResultadoPruebaResistencia.Save();


        }

    }
}
