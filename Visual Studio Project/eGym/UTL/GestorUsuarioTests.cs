using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GestorUsuario.Tests
{
    [TestClass()]
    public class GestorUsuarioTest
    {

        [TestMethod()]
        public void assertTodos(EL.Usuario compara, EL.Usuario actual)
        {
            Assert.AreEqual(compara.Alias, actual.Alias, "Prueba pasada:ALIAS");
            Assert.AreEqual(compara.Apellido, actual.Apellido, "Prueba pasada:APELLIDO");
            Assert.AreEqual(compara.Contrasena, actual.Contrasena, "Prueba pasada:CONTRASENA");
            Assert.AreEqual(compara.CorreoElectronico, actual.CorreoElectronico, "Prueba pasada:CORREO_ELECTRONICO");
            Assert.AreEqual(compara.FechaIngreso, actual.FechaIngreso, "Prueba pasada:FECHA_INGRESO");
            Assert.AreEqual(compara.FechaNacimiento, actual.FechaNacimiento, "Prueba pasada:FECHA_NACIMIENTO");
            Assert.AreEqual(compara.Habilitado, actual.Habilitado, "Prueba pasada:HABILITADO");
            Assert.AreEqual(compara.Id, actual.Id, "Prueba pasada:ID");
            Assert.AreEqual(compara.Identificacion, actual.Identificacion, "Prueba pasada:IDENTIFICACION");
            Assert.AreEqual(compara.IdGenero, actual.IdGenero, "Prueba pasada:ID_GENERO");
            Assert.AreEqual(compara.IdTipoIdentificacion, actual.IdTipoIdentificacion, "Prueba pasada:TIPO_IDENTIFICACION");
            Assert.AreEqual(compara.Nombre, actual.Nombre, "Prueba pasada:NOMBRE");
            Assert.AreEqual(compara.NumeroCelular, actual.NumeroCelular, "Prueba pasada:CELULAR");
            Assert.AreEqual(compara.NumeroTelefono, actual.NumeroTelefono, "Prueba pasada:TELEFONO");
            Assert.AreEqual(compara.Rol, actual.Rol, "Prueba pasada:ROL");
            Assert.AreEqual(compara.SegundoApellido, actual.SegundoApellido, "Prueba pasada:SEGUNDO_APELLIDO");
            Assert.AreEqual(compara.SegundoNombre, actual.SegundoNombre, "Prueba pasada:SEGUNDO_NOMBRE");
        }
        public void assertLista(IEnumerable<EL.Usuario> compara, IEnumerable<EL.Usuario> actual)
        {
            Assert.AreSame(compara, actual, "Prueba pasada:Lista");
        }
        [TestMethod()]
        public void listarUsuariosTest()
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
        public void insertarUsuarioTest()
        {
            BLL.Gestor gestor = new BLL.Gestor();
            gestor.AgregarUsuario("1", "nombre 1", "segundo nombre 1", "apellido 1", "segundo apellido 1", "alias", DateTime.Now,
                "correo1", "contrasena", null, DateTime.Now, "numero", "celular", 1, 1, 1);

        }

        [TestMethod()]
        public void modificarTipoDePagoTest()
        {
            BLL.Gestor gestor = new BLL.Gestor();
            EL.Usuario copia = gestor.ObtenerUsuario(1);
            gestor.ModificarUsuario(1, "1", "nombre 1", "segundo nombre 1", "apellido 1", "segundo apellido 1", "alias", DateTime.Now,
                "correo1", "contrasena", null, DateTime.Now, "numero", "celular", 1, 1, 1);
            EL.Usuario actual = new EL.Usuario() { 
                Id = 1, 
                Identificacion = "1", 
                Nombre = "nombre 1", 
                SegundoNombre = "segundo nombre 1",
                Apellido = "apellido 1",
                SegundoApellido = "segundo apellido 1",
                Alias = "alias",
                FechaNacimiento = DateTime.Now,
                CorreoElectronico = "correo1",
                Contrasena = "contrasena",
                Fotografia = null,
                FechaIngreso = DateTime.Now,
                NumeroTelefono = "numero",
                NumeroCelular = "celular",
                };
            EL.Usuario compara = gestor.ObtenerUsuario(1);
            this.assertTodos(compara, actual);
            //gestor.modificarTipoDePago(copia.Id, copia.Nombre, copia.Monto, copia.Duracion, copia.Habilitado);
        }

        [TestMethod()]
        public void eliminarTipoDePagoTest()
        {
            BLL.Gestor gestor = new BLL.Gestor();
            EL.Usuario actual = gestor.ObtenerUsuario(1);
            gestor.EliminarUsuario(actual);
            EL.Usuario compara = gestor.ObtenerUsuario(1);
            actual.Habilitado = false;
            this.assertTodos(compara, actual);
            //gestor.EliminarUsuario(1);

        }
    }
}
