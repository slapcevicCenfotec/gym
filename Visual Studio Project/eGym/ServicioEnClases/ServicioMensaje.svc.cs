using BLL;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web.Script.Serialization;

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioMensaje
    {
        [WebGet()]
        [OperationContract]
        public string obtenerMensajes()
        {
            var gestor = new Gestor();
            var mensajes = gestor.ListarMensajes();
            var serializer = new JavaScriptSerializer();
            var result = serializer.Serialize(mensajes);
            return result;
        }

        [OperationContract]
        public void insertarMensaje(string datos)
        { 
            var serializer = new JavaScriptSerializer();
            var dictionary = serializer.Deserialize<Dictionary<string, string>>(datos);
            var destinatario = Convert.ToInt32(dictionary["pDestinatarioId"]);
            var remitente = Convert.ToInt32(dictionary["pRemitenteId"]);
            var texto = dictionary["pMensaje"];
            var gestor = new Gestor();
            gestor.AgregarMensaje(destinatario, remitente, texto);
        }

        [WebGet()]
        [OperationContract]
        public string obtenerMensajesPorUsuario(string datos)
        {
            var serializer = new JavaScriptSerializer();
            var result = "";
            try
            {
                var dictionary = serializer.Deserialize<Dictionary<string, string>>(datos);
                var destinatario = Convert.ToInt32(dictionary["pDestinatarioId"]);
                var gestor = new Gestor();
                var mensajes = gestor.ListarMensajesPorUsuario(destinatario);
                result = serializer.Serialize(mensajes);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}
