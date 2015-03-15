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
    public class GestorMaquinaTests
    {
        [TestMethod()]
        public void assertTodos(EL.Maquina compara, EL.Maquina actual)
        {
            Assert.AreEqual(compara.Id, actual.Id, "Prueba pasada:ID");
            Assert.AreEqual(compara.NumeroActivo, actual.NumeroActivo, "Prueba pasada:NUMERO ACTIVO");
            Assert.AreEqual(compara.NumeroMaquina, actual.NumeroMaquina, "Prueba pasada:NUMERO MAQUINA");
            Assert.AreEqual(compara.TipoDeMaquina, actual.TipoDeMaquina, "Prueba pasada:TIPO DE MAQUINA");
            Assert.AreEqual(compara.Habilitado, actual.Habilitado, "Prueba pasada:HABILITADO");
        }
        [TestMethod()]
        public void listarMaquinasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMaquinaByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void insertarMaquinaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void modificarMaquinaTest()
        {
            BLL.GestorMaquina gestor = new BLL.GestorMaquina();
            EL.Maquina copia = gestor.GetMaquinaById(1);
            gestor.modificarMaquina(1, "NUMERO DE ACTIVO TEST", "NUMERO DE MAQUINA TEST", false, 1);
            EL.Maquina actual = new EL.Maquina(1, "NUMERO DE ACTIVO TEST", "NUMERO DE MAQUINA TEST", false, 1);
            EL.Maquina compara = gestor.GetMaquinaById(1);
            this.assertTodos(compara, actual);
            gestor.modificarMaquina(copia.Id, copia.NumeroActivo, copia.NumeroMaquina, copia.Habilitado, copia.TipoDeMaquina);
            Assert.Fail();
        }

        [TestMethod()]
        public void eliminarMaquinaTest()
        {
            Assert.Fail();
        }
    }
}
