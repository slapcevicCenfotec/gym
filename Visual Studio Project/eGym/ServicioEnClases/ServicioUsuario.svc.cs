using BLL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
//using System.Web.Http;
using System.Web.Script.Serialization;
using System.Web.Services;


namespace ServicioEnClases
{
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Web.Script.Services.ScriptService]
    public class ServicioUsuario
    {
        [WebGet()]
        [OperationContract]
        public string ObtenerUsuarios()
        {
            var gestor = new Gestor();
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(gestor.ListarUsuarios());
        }

        [WebGet()]
        [OperationContract]
        public string ObtenerRoles()
        {
            var gestor = new GestorRol();
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(gestor.listarRoles());
        }

        [WebGet()]
        [OperationContract]
        public string ObtenerUsuario(string id)
        {
            var gestor = new Gestor();
            var idInt = Convert.ToInt32(id);
            var serializer = new JavaScriptSerializer();
            try
            {
                return serializer.Serialize(gestor.ObtenerUsuario(idInt));
            }
            catch(Exception ex)
            {
                return new JavaScriptSerializer().Serialize(ex.Message);
            }
        }

        [WebMethod]
        [OperationContract]
        public String InsertarUsuario(string datos)
        {
            var serializer = new JavaScriptSerializer();
            try
            {
                var diccionario = serializer.Deserialize<Dictionary<string, string>>(datos);
                var gestor = new Gestor();

                string pIdentificacion = Convert.ToString(diccionario["pIdentificacion"]);
                string pPrimerNombre = Convert.ToString(diccionario["pPrimerNombre"]);
                string pSegundoNombre = Convert.ToString(diccionario["pSegundoNombre"]);
                string pPrimerApellido = Convert.ToString(diccionario["pPrimerApellido"]);
                string pSegundoApellido = Convert.ToString(diccionario["pSegundoApellido"]);
                string pAlias = Convert.ToString(diccionario["pAlias"]);
                DateTime pFechaNacimiento = DateTime.ParseExact(diccionario["pFechaNacimiento"], "dd/MM/yyyy", null);
                string pCorreoElectronico = Convert.ToString(diccionario["pCorreoElectronico"]);
                string pContrasena = Convert.ToString(diccionario["pContrasena"]);
                string pFotografia = diccionario["pFoto"];
                //byte[] pFotografia = ConvertToByteArray(diccionario["pFotografia"]);
                //byte[] pFotografia = null;

                DateTime pFechaIngreso = DateTime.Now;
                string pNumeroTelefono = Convert.ToString(diccionario["pNumeroTelefono"]);
                string pNumeroCelular = Convert.ToString(diccionario["pNumeroCelular"]);
                int pIdRol = Convert.ToInt32(diccionario["pIdRol"]);
                int pIdGenero = Convert.ToInt32(diccionario["pIdGenero"]);
                int pTipoIdentificacion = Convert.ToInt32(diccionario["pTipoIdentificacion"]);

                gestor.AgregarUsuario(pIdentificacion, pPrimerNombre, pSegundoNombre, 
                    pPrimerApellido, pSegundoApellido, pAlias, pFechaNacimiento, 
                    pCorreoElectronico, pContrasena, System.Convert.FromBase64String(pFotografia.Split(',')[1]), pFechaIngreso, pNumeroTelefono, 
                    pNumeroCelular, pIdRol, pIdGenero, pTipoIdentificacion);

                return serializer.Serialize(string.Empty);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Metodo web que permite ingresar un contacto en la base de datos
        /// </summary>
        /// <param name="datos">JSON: pNombre, pParentesco, pNumero</param>
        [WebMethod]
        [OperationContract]
        public String InsertarContacto(string datos)
        {
            var serializer = new JavaScriptSerializer();

            try
            {
                var diccionario = serializer.Deserialize<Dictionary<string, string>>(datos);
                var gestor = new Gestor();
                string pNombre = Convert.ToString(diccionario["pNombre"]);
                string pParentesco = Convert.ToString(diccionario["pParentesco"]);
                string pNumero = Convert.ToString(diccionario["pNumero"]);
                gestor.AgregarContacto(pNombre, pNumero, pParentesco, 0);

                return serializer.Serialize(string.Empty);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        [OperationContract]
        public String InsertarHorario(string datos)
        {
            var serializer = new JavaScriptSerializer();

            try
            {
                var diccionario = serializer.Deserialize<Dictionary<string, string>>(datos);
                var gestor = new Gestor();
                DateTime pHoraEntrada = DateTime.ParseExact(diccionario["pHoraEntrada"], "dd/MM/yyyy", null);
                DateTime pHoraSalida = DateTime.ParseExact(diccionario["pHoraSalida"], "dd/MM/yyyy", null);
                int pDiaSemana = Convert.ToInt32(diccionario["pDiaSemana"]);
                gestor.AgregarHorario(pHoraEntrada, pHoraSalida, pDiaSemana, 0);

                return serializer.Serialize(string.Empty);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        static byte[] ConvertToByteArray(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
