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

        [WebGet()]
        [OperationContract]
        public string obtenerEjercicioByID(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = Convert.ToInt32(dictionary["pid"]);
            
            Ejercicio objEjercicio = new Ejercicio();
            objEjercicio = objGestorEjercicio.getEjercicio(id);
            return new JavaScriptSerializer().Serialize(objEjercicio);

        }
        [WebGet()]
        [OperationContract]
        public string obtenerMusculosSecundarios(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = Convert.ToInt32(dictionary["pid"]);

            List<Musculo> objEjercicio = new List<Musculo>();
            objEjercicio = objGestorEjercicio.getMusculoSecundarios(id);
            return new JavaScriptSerializer().Serialize(objEjercicio);

        }


        [WebMethod]
        [OperationContract]
        public void insertarEjercicio(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            string nombre = dictionary["pnombre"];
            string alias = dictionary["palias"];
            string descripcion = dictionary["pdescripcion"];
            string erroresComunes = dictionary["perroresComunes"];
            string posInicial = dictionary["pposInicial"];
            string posFinal = dictionary["pposFinal"];
            int musculoPrincipal= Convert.ToInt32(dictionary["pmusculoPrincipal"]);
            string musculosSecundarios= dictionary["pmusculosSecundarios"];;
       
            Byte[] image = Convert.FromBase64String(dictionary["pimagen"]);
            Byte[] image2 = Convert.FromBase64String(dictionary["pimagen2"]);

            objGestorEjercicio.insertarEjercicio(nombre, alias, posInicial, image, posFinal, image2, erroresComunes, descripcion, musculoPrincipal, musculosSecundarios);
        
        }

        [WebMethod]
        [OperationContract]
        public void modificarEjercicio(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = Convert.ToInt32(dictionary["pid"]);
            string nombre = dictionary["pnombre"];
            string alias = dictionary["palias"];
            string descripcion = dictionary["pdescripcion"];
            string erroresComunes = dictionary["perroresComunes"];
            string posInicial = dictionary["pposInicial"];
            string posFinal = dictionary["pposFinal"];
            int musculoPrincipal = Convert.ToInt32(dictionary["pposFinal"]);
            string musculosSecundarios = dictionary["pmusculosSecundarios"]; ;

            Byte[] image = Convert.FromBase64String(dictionary["pimagen"]);
            Byte[] image2 = Convert.FromBase64String(dictionary["pimagen2"]);

            objGestorEjercicio.modificarEjercicio(id, nombre, alias, posInicial, image, posFinal, image2, erroresComunes, descripcion, musculoPrincipal, musculosSecundarios);

        }

        [WebMethod]
        [OperationContract]
        public void eliminarEjercicio(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = Convert.ToInt32(dictionary["pid"]);
            Ejercicio objEjercicio = new Ejercicio();
            objEjercicio.Id = id;

            objGestorEjercicio.eliminarEjercicio(objEjercicio);

        }

    }
}
