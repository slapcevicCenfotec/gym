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
    public class ServiciosMaquinas
    {
        GestorMaquina objGestorMaquinas = new GestorMaquina();
        [WebGet()]
        [OperationContract]
        public string obtenerMaquinas()
        {
            List<Maquina> listaMaquinas = new List<Maquina>();
            listaMaquinas = objGestorMaquinas.listarMaquinasServices();
            return new JavaScriptSerializer().Serialize(listaMaquinas);
        }

        [WebGet()]
        [OperationContract]
        public string obtenerMaquinaById(string pid)
        {
            Maquina maquina = new Maquina();
            maquina = objGestorMaquinas.GetMaquinaById(Convert.ToInt32(pid));
            return new JavaScriptSerializer().Serialize(maquina);
        }

        [OperationContract]
        public void insertarMaquina(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            string numeroActivo = dictionary["pnumeroActivo"];
            string numeroMaquina = dictionary["pnumeroMaquina"];
            int tipoMaquina = int.Parse(dictionary["ptipoMaquina"]);

            objGestorMaquinas.insertarMaquina(numeroActivo, numeroMaquina, tipoMaquina);

        }

        [OperationContract]
        public void modificarMaquina(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["pid"]);
            string numeroActivo = dictionary["pnumeroActivo"];
            string numeroMaquina = dictionary["pnumeroMaquina"];
            Boolean habilitado = Boolean.Parse(dictionary["phabilitado"]);
            int tipoMaquina = int.Parse(dictionary["ptipoMaquina"]);

            objGestorMaquinas.modificarMaquina(id, numeroActivo, numeroMaquina, habilitado, tipoMaquina);

        }

        [OperationContract]
        public void eliminarMaquina(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["pid"]);
            string numeroActivo = dictionary["pnumeroActivo"];
            string numeroMaquina = dictionary["pnumeroMaquina"];
            Boolean habilitado = Boolean.Parse(dictionary["phabilitado"]);
            int tipoMaquina = int.Parse(dictionary["ptipoMaquina"]);

            Maquina maquinaPorEliminar = new Maquina(id, numeroActivo, numeroMaquina, habilitado, tipoMaquina);

            objGestorMaquinas.eliminarMaquina(maquinaPorEliminar);

        }

        // Add more operations here and mark them with [OperationContract]
    }
}
