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
    [ServiceContract(Namespace = "ServicioLogin")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioSesion
    {
        GestorSesion objGestorSesion = new GestorSesion();


        [WebGet()]
        [OperationContract]
        public String iniciarSesion(string datosSerializados)
        {
            try
            {
                var jss = new JavaScriptSerializer();
                var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

                string correo = dictionary["pcorreo"];
                string contrasena = dictionary["pcontrasena"];

                Usuario usuario = objGestorSesion.iniciarSesion(correo, contrasena);
                return new JavaScriptSerializer().Serialize(usuario);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
