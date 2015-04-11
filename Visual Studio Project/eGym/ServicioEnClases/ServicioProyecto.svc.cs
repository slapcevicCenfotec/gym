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
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Web.Script.Services.ScriptService]
    public class ServicioProyecto
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        GestorMusculo objGestorMusculo = new GestorMusculo();
        [WebGet()]
        [OperationContract]
        public string obtenerMusculos()
        {
            List<Musculo> listaMusculos = new List<Musculo>();
            listaMusculos = objGestorMusculo.listarMusculos();
            return new JavaScriptSerializer().Serialize(listaMusculos);
 
        }
        [WebGet()]
        [OperationContract]
        public void modificarMusculo(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id =int.Parse(dictionary["pid"]);
            string pnombre = dictionary["ppnombre"];
            string ubicacion = dictionary["pubicacion"];
            string origen = dictionary["porigen"];
            string inserccion = dictionary["pinserccion"];
            string inervacion = dictionary["pinervacion"];
            string irrigacion = dictionary["pirrigacion"];

            objGestorMusculo.modificarMusculo(id, pnombre, ubicacion, origen, inserccion, inervacion, irrigacion);           

        }
        [WebGet()]
        [OperationContract]
        public void eliminarMusculo(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            var id = Convert.ToInt32(dictionary["pid"]);

            Musculo objmusculo = new Musculo(id,"");
            
            objGestorMusculo.eliminarMusculo(objmusculo);

        }

        [WebMethod]
        [OperationContract]
        public void insertarMusculo(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            string nombre = dictionary["pnombre"];
            string ubicacion = dictionary["pubicacion"];
            string origen = dictionary["porigen"];
            string inserccion = dictionary["pinserccion"];
            string inervacion = dictionary["pinervacion"];
            string irrigacion = dictionary["pirrigacion"];

            objGestorMusculo.agregarMusculo(nombre, ubicacion, origen, inserccion, inervacion, irrigacion);
            
        }


        // Add more operations here and mark them with [OperationContract]
    }
}
