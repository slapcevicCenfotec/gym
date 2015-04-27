using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class GestorPruebaResistencia
    {
        private UnitOfWork UoW = new UnitOfWork();
        //<summary>
        // Autor:Alexis Soto
        // Fecha:03/15/2015
        // Descripcion: Devuelve una lista de gimnasios.
        // </summary>
        // <returns>IEnumerable<Gimnasio></returns>
        public IEnumerable<PruebaResistencia> listarPruebasResistencia()
        {
            return UoW.PruebaResistenciaRepository.GetAll();
        }

        public List<PruebaResistencia> obtenerPruebaResistencia(int id)
        {
            List<PruebaResistencia> listaPruebas = new List<PruebaResistencia>();
            listaPruebas.Add(UoW.PruebaResistenciaRepository.GetById(id));
            return listaPruebas;
        }
    }



    }

