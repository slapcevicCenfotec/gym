using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GestorMaquinaTest
{
    [TestClass()]
    public class GestorTipoDeMaquinaTests
    {
        [TestMethod()]
        public void assertTodos(EL.TipoDeMaquina compara, EL.TipoDeMaquina actual)
        {
            Assert.AreEqual(compara.Id, actual.Id, "Prueba pasada:ID");
            Assert.AreEqual(compara.Nombre, actual.Nombre, "Prueba pasada:NOMBRE");
            Assert.AreEqual(compara.Descripcion, actual.Descripcion, "Prueba pasada:DESCRPCION");
            Assert.AreEqual(compara.Habilitado, actual.Habilitado, "Prueba pasada:HABILITADO");
        }
        [TestMethod()]
        public void listarTiposMaquinasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTipoDeMaquinaByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void insertarTipoDeMaquinaTest()
        {
            BLL.GestorTipoDeMaquina gestor = new BLL.GestorTipoDeMaquina();
            gestor.insertarTipoDeMaquina(null, "Nombre test","Descripcion test");
        }

        [TestMethod()]
        public void modificarTipoDeMaquinaTest()
        {
            BLL.GestorTipoDeMaquina gestor = new BLL.GestorTipoDeMaquina();
            EL.TipoDeMaquina copia = gestor.GetTipoDeMaquinaById(1);
            gestor.modificarTipoDeMaquina(1, null, "NOMBRE MAQUINA TEST", "DESCRIPCION TEST", true);
            EL.TipoDeMaquina actual = new EL.TipoDeMaquina(1, null, "NOMBRE MAQUINA TEST", "DESCRIPCION TEST", true);
            EL.TipoDeMaquina compara = gestor.GetTipoDeMaquinaById(1);
            this.assertTodos(compara, actual);
            gestor.modificarTipoDeMaquina(copia.Id, copia.Foto, copia.Nombre, copia.Descripcion, copia.Habilitado);
            Assert.Fail();
        }

        [TestMethod()]
        public void eliminarMaquinaTest()
        {
            BLL.GestorMaquina gestor = new BLL.GestorMaquina();
            EL.Maquina copia = gestor.GetMaquinaById(1);
            EL.Maquina actual = gestor.GetMaquinaById(1);
            gestor.eliminarMaquina(actual);
            EL.Maquina compara = gestor.GetMaquinaById(1);
            actual.Habilitado = false;
            this.assertTodos(compara, actual);
            gestor.modificarMaquina(copia.Id, copia.NumeroMaquina, copia.NumeroMaquina, copia.Habilitado, copia.TipoDeMaquina);
        }
    }
}
