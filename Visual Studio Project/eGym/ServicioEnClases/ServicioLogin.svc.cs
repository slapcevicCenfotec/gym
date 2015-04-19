using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using EL;
using BLL;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "ServicioLogin")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Web.Script.Services.ScriptService]   
    public class ServicioLogin
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";

        GestorSesion objGestorSesion = new GestorSesion();
        [WebMethod]
        [OperationContract]
        public void iniciarSesion(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            string correo = dictionary["pcorreo"];
            string contrasena = dictionary["pcontrasena"];

            Usuario usuario =  objGestorSesion.iniciarSesion(correo, contrasena);

        }
    }
}
