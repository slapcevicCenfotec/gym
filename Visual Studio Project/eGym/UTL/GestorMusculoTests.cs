using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GestorMusculoTests
{


    [TestClass()]
    public class GestorMusculoTests
    {

        [TestMethod()]
        public void agregarMusculoTest()
        {
            BLL.GestorMusculo gestor = new BLL.GestorMusculo();
            gestor.agregarMusculo("Prueba", "UbicacionPrueba", "OrigenPrueba", "InserccionPrueba", "InervacionPrueba", "IrrigacionPrueba");
        }
        
        [TestMethod()]
        public void assertTodos(EL.Musculo compara, EL.Musculo actual)
        {
            Assert.AreEqual(compara.Id, actual.Id, "Prueba pasada:ID");
            Assert.AreEqual(compara.Nombre, actual.Nombre, "Prueba pasada:NOMBRE");
            Assert.AreEqual(compara.Ubicacion, actual.Ubicacion, "Prueba pasada:MONTO");
            Assert.AreEqual(compara.Origen, actual.Origen, "Prueba pasada:DURACION");
            Assert.AreEqual(compara.Inserccion, actual.Inserccion, "Prueba pasada:HABILITADO");
            Assert.AreEqual(compara.Inervacion, actual.Inervacion, "Prueba pasada:HABILITADO");
            Assert.AreEqual(compara.Irrigacion, actual.Irrigacion, "Prueba pasada:HABILITADO");
        }

        [TestMethod()]
        public void modificarMusculoTest()
        {
            BLL.GestorMusculo gestor = new BLL.GestorMusculo();
            EL.Musculo copia = gestor.musculoPorId(1);
            gestor.modificarMusculo(1, "PruebaNombre", "UbicacionPrueba", "OrigenPrueba", "InserccionPrueba", "InervacionPrueba","IrrigacionPrueba");
            EL.Musculo actual = new EL.Musculo(1, "PruebaNombre", "UbicacionPrueba", "OrigenPrueba", "InserccionPrueba", "InervacionPrueba", "IrrigacionPrueba");
            EL.Musculo compara = gestor.musculoPorId(1);
            this.assertTodos(compara, actual);
            gestor.modificarMusculo(copia.Id,copia.Nombre,copia.Ubicacion,copia.Origen,copia.Inserccion,copia.Inervacion,copia.Irrigacion);
        }

         //BLL.GestorTipoDePago gestor = new BLL.GestorTipoDePago();
         //   EL.TipoDePago actual = gestor.tipoDePagoPorId(1);
         //   gestor.eliminarTipoDePago(1);
         //   EL.TipoDePago compara = gestor.tipoDePagoPorId(1);
         //   actual.Habilitado = false;
         //   this.assertTodos(compara, actual);
         //   gestor.habilitarTipoDePago(1);
        [TestMethod()]
        public void eliminarMusculoTest()
        {
            BLL.GestorMusculo gestor = new BLL.GestorMusculo();
            EL.Musculo actual = gestor.musculoPorId(1);
            gestor.eliminarMusculo(actual);
            EL.Musculo compara = gestor.musculoPorId(1);
            actual.Habilitado = false;
            this.assertTodos(compara, actual);
        }
    }
}
