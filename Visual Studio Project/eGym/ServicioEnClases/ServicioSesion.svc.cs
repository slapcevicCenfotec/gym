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

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioSesion
    {
        GestorSesion objGestorSesion = new GestorSesion();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [WebMethod]
        [OperationContract]
        public String iniciarSesion(string datosSerializados)
        {
            try
            {
                var jss = new JavaScriptSerializer();
                var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

                string correo = Convert.ToString(dictionary["pcorreo"]);
                string contrasena = Convert.ToString(dictionary["pcontrasena"]);

                Usuario usuario = new GestorSesion().iniciarSesion(correo, contrasena);
                return new JavaScriptSerializer().Serialize(usuario);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
