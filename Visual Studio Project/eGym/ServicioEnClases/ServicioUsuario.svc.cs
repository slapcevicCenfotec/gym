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

        [WebMethod]
        [OperationContract]
        public String InsertarUsuario(string datos)
        {
            var serializer = new JavaScriptSerializer();
            try
            {
                var javaScriptSerializer = new JavaScriptSerializer();
                var diccionario = javaScriptSerializer.Deserialize<Dictionary<string, string>>(datos);
                var gestor = new Gestor();

                string pIdentificacion = Convert.ToString(diccionario["pIdentificacion"]);
                string pPrimerNombre = Convert.ToString(diccionario["pPrimerNombre"]);
                string pSegundoNombre = Convert.ToString(diccionario["pSegundoNombre"]);
                string pPrimerApellido = Convert.ToString(diccionario["pPrimerApellido"]);
               // string pSegundoApellido = Convert.ToString(diccionario["pSegundoApellido"]);
                string pAlias = Convert.ToString(diccionario["pAlias"]);
               // DateTime pFechaNacimiento = Convert.ToDateTime(diccionario["pFechaNacimiento"]);
                string pCorreoElectronico = Convert.ToString(diccionario["pCorreoElectronico"]);
                string pContrasena = Convert.ToString(diccionario["pContrasena"]);
               // byte[] pFotografia = ConvertToByteArray(diccionario["pFotografia"]);
               // DateTime pFechaIngreso = Convert.ToDateTime(diccionario["pFechaIngreso"]);
                string pNumeroTelefono = Convert.ToString(diccionario["pNumeroTelefono"]);
                string pNumeroCelular = Convert.ToString(diccionario["pNumeroCelular"]);
                //int pIdRol = Convert.ToInt32(diccionario["pIdRol"]);
                //int pIdGenero = Convert.ToInt32(diccionario["pIdGenero"]);
                //int pTipoIdentificacion = Convert.ToInt32(diccionario["pTipoIdentificacion"]);

                //gestor.AgregarUsuario(pIdentificacion, pPrimerNombre, pSegundoNombre, 
                //    pPrimerApellido, pSegundoApellido, pAlias, pFechaNacimiento, 
                //    pCorreoElectronico, pContrasena, pFotografia, pFechaIngreso, pNumeroTelefono, 
                //    pNumeroCelular, pIdRol, pIdGenero, pTipoIdentificacion);

                return new JavaScriptSerializer().Serialize("Todo bien");
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
