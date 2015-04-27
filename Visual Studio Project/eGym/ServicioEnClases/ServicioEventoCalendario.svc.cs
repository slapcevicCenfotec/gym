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
using System.Globalization;

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioEventoCalendario
    {
        GestorEventoCalendario objEvento = new GestorEventoCalendario();
        [WebGet()]
        [OperationContract]
        public string getAllEventoCalendario()
        {
            List<EventoCalendario> listaEventos = new List<EventoCalendario>();
            listaEventos = objEvento.listarEventos();
            return new JavaScriptSerializer().Serialize(listaEventos);
        }
        [WebMethod]
        [OperationContract]
        public void insertarEventoCalendario(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

           int usuario = int.Parse(dictionary["USUARIO"]);
            int tipo = int.Parse(dictionary["TIPO"]);
            String titulo = dictionary["TITULO"];
            String descripcion = dictionary["DESCRIPCION"];
            DateTime fechaInicial = DateTime.ParseExact(dictionary["FECHA_INICIAL"], "yyyy-MM-dd'T'hh:mm:ss", CultureInfo.InvariantCulture,
                                       DateTimeStyles.AssumeUniversal |
                                       DateTimeStyles.AdjustToUniversal);
            DateTime fechaFinal = DateTime.ParseExact(dictionary["FECHA_FINAL"], "yyyy-MM-dd'T'hh:mm:ss", CultureInfo.InvariantCulture,
                                       DateTimeStyles.AssumeUniversal |
                                       DateTimeStyles.AdjustToUniversal);
                //Convert.ToDateTime(dictionary["FECHA_FINAL"]);

            objEvento.insertarEvento(usuario,tipo,titulo,descripcion,fechaInicial,fechaFinal);
        }
        [WebGet()]
        [OperationContract]
        public void modificarEventoCalendario(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["ID"]);
            int usuario = int.Parse(dictionary["USUARIO"]);
            int tipo = int.Parse(dictionary["TIPO"]);
            String titulo = dictionary["TITULO"];
            String descripcion = dictionary["DESCRIPCION"];
            DateTime fechaInicial = Convert.ToDateTime(dictionary["FECHA_INICIAL"]);
            DateTime fechaFinal = Convert.ToDateTime(dictionary["FECHA_FINAL"]);

            objEvento.modificarEvento(id,usuario, tipo, titulo, descripcion, fechaInicial, fechaFinal);
        }
        [WebGet()]
        [OperationContract]
        public void eliminarEventoCalendario(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            var id = Convert.ToInt32(dictionary["ID"]);

            objEvento.eliminarEvento(id);
        }
    }
}
