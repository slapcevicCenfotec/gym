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
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Web.Script.Services.ScriptService]
    public class ServicioUsuario
    {
        [WebGet()]
        [OperationContract]
        public string obtenerUsuarios()
        {
            return new JavaScriptSerializer().Serialize(new Gestor().ListarUsuarios());
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
