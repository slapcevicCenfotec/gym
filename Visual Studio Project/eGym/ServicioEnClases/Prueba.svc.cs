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
    public class Prueba
    {
        GestorMaquina objGestorMaquinas = new GestorMaquina();

        [WebGet()]
        [OperationContract]
        public string obtenerMaquinas()
        {
            List<Maquina> listaMaquinas = new List<Maquina>();
            listaMaquinas = objGestorMaquinas.listarMaquinas();
            return new JavaScriptSerializer().Serialize(listaMaquinas);
            
        }
    }
}
