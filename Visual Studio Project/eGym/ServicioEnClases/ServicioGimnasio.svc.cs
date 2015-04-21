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
    public class ServicioGimnasio
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";

        GestorGimnasio objGestorGimnasio = new GestorGimnasio();
        [WebGet()]
        [OperationContract]
        public string obtenerGimnasioPorId()
        {

            List<Gimnasio>  listaGimnasio= new List<Gimnasio>();
            listaGimnasio = objGestorGimnasio.listarGimnasios().ToList();
            int idGimnasio = listaGimnasio[0].Id;
            listaGimnasio = objGestorGimnasio.obtenerGimnasio(idGimnasio);
            return new JavaScriptSerializer().Serialize(listaGimnasio);

        }

        [WebMethod]
        [OperationContract]
        public void ModificarGimnasio(string datosSerializados)
        {


            var jss = new JavaScriptSerializer();
            //var dictionary = jss.Deserialize<Dictionary<string, string,>>(datosSerializados);
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);
            int id = Convert.ToInt32(dictionary["pId"].ToString());
            string nombre = dictionary["pnombre"].ToString();
            string ubicacion = dictionary["pubicacion"].ToString();
            string telefono = dictionary["ptelefono"].ToString();
            string fax = dictionary["pfax"].ToString();
            string cedula = dictionary["pcedula"].ToString();

            //{
            //    dato.GetType();
            //}
            objGestorGimnasio.ModificarGimnasio(id, nombre, ubicacion, telefono, fax, cedula);
        }


        [OperationContract]
        public void DoWork()
        {
            // Add your operation implementation here
            return;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
