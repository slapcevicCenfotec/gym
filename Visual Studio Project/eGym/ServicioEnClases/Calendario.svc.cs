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

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Calendario
    {
        GestorEventoCalendario objEvento = new GestorEventoCalendario();
        [WebGet()]
        [OperationContract]
        public string obtenerEjercicios()
        {
            List<EventoCalendario> listaEventos = new List<EventoCalendario>();
            listaEventos = objEvento.listarEventos();
            return new JavaScriptSerializer().Serialize(listaEventos);

        }
    }
}
