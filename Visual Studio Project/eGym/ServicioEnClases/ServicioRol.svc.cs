using System;
using System.Collections.Generic;
using System.Collections;
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
    public class ServicioRol
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        GestorRol objGestorRol = new GestorRol();
        [WebGet()]
        [OperationContract]
        public string obtenerRoles()
        {
            List<Rol> listaRoles = new List<Rol>();
            listaRoles = objGestorRol.listarRoles().ToList();
            return new JavaScriptSerializer().Serialize(listaRoles);

        }


        [WebMethod]
        [OperationContract]
        public string obtenerRolPorId(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);
            string id = dictionary["pid"].ToString();
            
            List<Rol> listaRoles = new List<Rol>();
            listaRoles = objGestorRol.obtenerRol(Convert.ToInt32(id));
            return new JavaScriptSerializer().Serialize(listaRoles);
        }


        [WebMethod]
        [OperationContract]
        public void insertarRoles(string datosSerializados)
        {

            ArrayList listaPermisos = new ArrayList();
            List<int> idsPermisos = new List<int>();

            var jss = new JavaScriptSerializer();
            //var dictionary = jss.Deserialize<Dictionary<string, string,>>(datosSerializados);
            var dictionary = jss.Deserialize<Dictionary<String,object>>(datosSerializados);
            string nombre = dictionary["pnombre"].ToString();
            string descripcion = dictionary["pdescripcion"].ToString();
            listaPermisos = (ArrayList) dictionary["ppermisos"];

            foreach (String item in listaPermisos) {
                idsPermisos.Add(Convert.ToInt32(item));
            }
            //{
            //    dato.GetType();
            //}
            objGestorRol.insertarRol(nombre, descripcion, idsPermisos);
        }

        [WebMethod]
        [OperationContract]
        public void ModificarRoles(string datosSerializados)
        {

            ArrayList listaPermisos = new ArrayList();
            List<int> idsPermisos = new List<int>();

            var jss = new JavaScriptSerializer();
            //var dictionary = jss.Deserialize<Dictionary<string, string,>>(datosSerializados);
            var dictionary = jss.Deserialize<Dictionary<String, object>>(datosSerializados);
            int id = Convert.ToInt32(dictionary["pId"].ToString());
            string nombre = dictionary["pnombre"].ToString();
            string descripcion = dictionary["pdescripcion"].ToString();
            listaPermisos = (ArrayList)dictionary["ppermisos"];

            foreach (String item in listaPermisos)
            {
                idsPermisos.Add(Convert.ToInt32(item));
            }
            //{
            //    dato.GetType();
            //}
            objGestorRol.ModificarRol(id, nombre, descripcion, idsPermisos);
        }


        [WebMethod]
        [OperationContract]
        public void EliminarRoles(string datosSerializados)
        {


            var jss = new JavaScriptSerializer();
            //var dictionary = jss.Deserialize<Dictionary<string, string,>>(datosSerializados);
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);
            int id = Convert.ToInt32(dictionary["pId"].ToString());

            objGestorRol.EliminarRol(id,"Rol","Rol");
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
