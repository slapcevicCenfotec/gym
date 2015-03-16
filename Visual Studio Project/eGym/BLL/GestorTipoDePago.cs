using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DAL;
using EL;


namespace BLL
{
    /// <summary>
    /// Autor:Alberto Arias
    /// Fecha:03/15/2015
    /// Descripcion: Esta clase se encarga de manejar los metodos de de insercion y modificacion  de los datos del tipo de pago
    /// </summary>
    public class GestorTipoDePago
    {
        private UnitOfWork UoW = new UnitOfWork();
        /// <summary>
        /// Autor:Alberto Arias
        /// Fecha:03/15/2015
        /// Descripcion: Devuelve una lista de todo los tipos de pago habilitados.
        /// </summary>
        /// <returns>IEnumerable<TipoDePago></returns>
        public IEnumerable<TipoDePago> listarTiposDePago()
        {
            return UoW.TipoDePagoRepository.GetAll();
        }
        
        /// <summary>
        /// Autor:Alberto Arias
        /// Fecha:03/15/2015
        /// Descripcion: Inserta un nuevo tipo de pago
        /// </summary>
        /// <param name="pNombre">Nombre.</param>
        /// <param name="pMonto">Monto.</param>
        /// <param name="pDuracion">Duracion.</param>
        public void insertarTipoDePago(String pNombre, double pMonto, int pDuracion)
        {
            TipoDePago tipoDePago = new TipoDePago(pNombre, pMonto, pDuracion);
            UoW.TipoDePagoRepository.Insert(tipoDePago);
            UoW.TipoDePagoRepository.Save();
        }
        /// <summary>
        /// Autor:Alberto Arias
        /// Fecha:03/15/2015
        /// Descripcion: Modifica un tipo de pago dado su id
        /// </summary>
        /// <param name="pNombre">Nombre.</param>
        /// <param name="pMonto">Monto.</param>
        /// <param name="pDuracion">Duracion.</param>
        /// /// <param name="pHabilitado">Habilitado.</param>
        public void modificarTipoDePago(int pId, String pNombre, double pMonto, int pDuracion, bool pHabilitado)
        {
            TipoDePago tipoDePago = new TipoDePago(pId, pNombre, pMonto, pDuracion, pHabilitado);
            UoW.TipoDePagoRepository.Update(tipoDePago);
            UoW.TipoDePagoRepository.Save();
        }
        /// <summary>
        /// Autor:Alberto Arias
        /// Fecha:03/15/2015
        /// Descripcion: Elimina un tipo de pago
        /// </summary>
        /// <param name="pId">Id.</param>
        public void eliminarTipoDePago(int pId) 
        {
            TipoDePago tipoDePago = new TipoDePago(pId);
            UoW.TipoDePagoRepository.Delete(tipoDePago);
            UoW.TipoDePagoRepository.Save();
        }
        /// <summary>
        /// Autor:Alberto Arias
        /// Fecha:03/15/2015
        /// Descripcion: Devuelve un tipode pago, segun su id
        /// </summary>
        /// <returns>TipoDePago</returns>
        /// <param name="pId">Id.</param>
        public TipoDePago tipoDePagoPorId(int pId){
        
            TipoDePago tipoDePago = UoW.TipoDePagoRepository.GetById(pId);
            return tipoDePago;
        }
        /// <summary>
        /// Autor:Alberto Arias
        /// Fecha:03/15/2015
        /// Descripcion: Habilita un pago dado
        /// </summary>
        /// <param name="objTipo">Objeto tipo pago.</param>
        public void habilitarTipoDePago(TipoDePago objTipo)
        {
            //TipoDePago tipoDePago = UoW.TipoDePagoRepository.Update
            objTipo.Habilitado = true;
            UoW.TipoDePagoRepository.Update(objTipo);
            UoW.TipoDePagoRepository.Save();
        }

       
    }
}
