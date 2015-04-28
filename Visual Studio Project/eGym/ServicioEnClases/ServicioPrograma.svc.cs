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
    [ServiceContract(Namespace = "Programas")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioPrograma
    {
        GestorProgramas objGestorPrograma = new GestorProgramas();
        [WebGet()]
        [OperationContract]
        public string obtenerProgramas()
        {
            List<Programa> listaProgramas = new List<Programa>();
            listaProgramas = objGestorPrograma.ListarProgramas();
            return new JavaScriptSerializer().Serialize(listaProgramas);
        }

        [OperationContract]
        public void generarPrograma(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int idUsuario = int.Parse(dictionary["pidUsuario"]);
            int tipoAcondicionamiento = int.Parse(dictionary["ptipoAcondicionamiento"]);

            objGestorPrograma.AgregarPrograma(idUsuario, tipoAcondicionamiento);          

        }

        [OperationContract]
        public void modificarPrograma(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["pid"]);
            int idUsuario = int.Parse(dictionary["pidUsuario"]);
            int tipoAcondicionamiento = int.Parse(dictionary["ptipoAcondicionamiento"]);
            int estado = int.Parse(dictionary["pestado"]);

            objGestorPrograma.ModificarPrograma(id, idUsuario, tipoAcondicionamiento, estado);

        }

        // Add more operations here and mark them with [OperationContract]
    }
}
