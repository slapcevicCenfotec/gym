using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class GestorTipoPruebaResistencia
    {

        private UnitOfWork UoW = new UnitOfWork();

        /// <summary>
        /// Autor:Alexis Soto
        /// Fecha:03/15/2015
        /// Descripcion: Devuelve una lista de gimnasios.
        /// </summary>
        /// <returns>IEnumerable<Gimnasio></returns>
        public IEnumerable<TipoPruebaResistencia> listarTipoPrueba()
        {

            return UoW.TipoPruebaResistenciaRepository.GetAll();
        }
    }
}
