using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GestorTipoDePago.Tests
{
    [TestClass()]
    public class GestorTipoDePagoTests
    {

        [TestMethod()]
        public void assertTodos(EL.TipoDePago compara, EL.TipoDePago actual)
        {
            Assert.AreEqual(compara.Id, actual.Id, "Prueba pasada:ID");
            Assert.AreEqual(compara.Nombre, actual.Nombre, "Prueba pasada:NOMBRE");
            Assert.AreEqual(compara.Monto, actual.Monto, "Prueba pasada:MONTO");
            Assert.AreEqual(compara.Duracion, actual.Duracion, "Prueba pasada:DURACION");
            Assert.AreEqual(compara.Habilitado, actual.Habilitado, "Prueba pasada:HABILITADO");
        }
        public void assertLista(IEnumerable<EL.TipoDePago> compara, IEnumerable<EL.TipoDePago> actual)
        {
            Assert.AreSame(compara, actual, "Prueba pasada:Lista");
        }
        [TestMethod()]
        public void listarTiposDePagoTest()
        {
            //BLL.GestorTipoDePago gestor = new BLL.GestorTipoDePago();
            //IEnumerable<EL.TipoDePago> actual = gestor.listarTiposDePago();
            //List<EL.TipoDePago> compara = new   List<EL.TipoDePago>();
            //for (int i = 1; i < 11; i++)
            //{
            //    EL.TipoDePago aux = new EL.TipoDePago(i, "Prueba", 1.1, 1, false);
            //    compara.Add(aux);
            //}
            //assertLista(compara, actual.ToList());
        }

        [TestMethod()]
        public void insertarTipoDePagoTest()
        {
            BLL.GestorTipoDePago gestor = new BLL.GestorTipoDePago();
            gestor.insertarTipoDePago("Prueba", 2.2, 9);

            //TipoDePago auxPago = gestor.tipoDePagoPorId();


        }

        [TestMethod()]
        public void modificarTipoDePagoTest()
        {
            BLL.GestorTipoDePago gestor = new BLL.GestorTipoDePago();
            EL.TipoDePago copia = gestor.tipoDePagoPorId(1);            
            gestor.modificarTipoDePago(1, "Prueba", 1.1, 1, false);
            EL.TipoDePago actual = new EL.TipoDePago(1, "Prueba", 1.1, 1, false);
            EL.TipoDePago compara = gestor.tipoDePagoPorId(1);
            this.assertTodos(compara, actual);
            gestor.modificarTipoDePago(copia.Id, copia.Nombre, copia.Monto, copia.Duracion, copia.Habilitado);
        }

        [TestMethod()]
        public void eliminarTipoDePagoTest()
        {
            BLL.GestorTipoDePago gestor = new BLL.GestorTipoDePago();
            EL.TipoDePago actual = gestor.tipoDePagoPorId(1);
            gestor.eliminarTipoDePago(1);
            EL.TipoDePago compara = gestor.tipoDePagoPorId(1);
            actual.Habilitado = false;
            this.assertTodos(compara, actual);
            gestor.habilitarTipoDePago(actual);

        }
    }
}
