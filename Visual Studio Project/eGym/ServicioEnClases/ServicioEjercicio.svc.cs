using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using BLL;
using EL;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioEjercicio
    {
     
        GestorEjercicio objGestorEjercicio = new GestorEjercicio();
        [WebGet()]
        [OperationContract]
        public string obtenerEjercicios()
        {
            List<Ejercicio> listaEjercicios = new List<Ejercicio>();
            listaEjercicios = objGestorEjercicio.listarEjercicios();
            return new JavaScriptSerializer().Serialize(listaEjercicios);

        }

        [WebMethod]
        [OperationContract]
        public void insertarMusculo(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            Byte[] image = Convert.FromBase64String(dictionary["pnombre"]);

            objGestorEjercicio.insertarEjercicio("nombre", "Alias", "pos", image, "p", image, "p", "p", 1, "1");
            

        }


    }
}
