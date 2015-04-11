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
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioUsuario
    {
        //Gestor gestor = new Gestor();
        //[WebGet()]
        //[OperationContract]
        //public string obtenerUsuarios()
        //{
        //    //List<Usuario> usuarios = new List<Usuario>();
        //    //usuarios = gestor.ListarUsuarios();
        //    //return new JavaScriptSerializer()
        //}
    }
}
