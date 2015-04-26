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

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Web.Script.Services.ScriptService]
    public class ServiciosTiposDeMaquinas
    {
        GestorTipoDeMaquina objGestorTiposMaquinas = new GestorTipoDeMaquina();

        [WebGet()]
        [OperationContract]
        public string obtenerTiposDeMaquinas()
        {
            List<TipoDeMaquina> listaTiposMaquinas = new List<TipoDeMaquina>();
            listaTiposMaquinas = objGestorTiposMaquinas.listarTiposDeMaquinasServices();
            return new JavaScriptSerializer().Serialize(listaTiposMaquinas);
        }

        [WebGet()]
        [OperationContract]
        public string obtenerTipoDeMaquinaById(string pid)
        {
            TipoDeMaquina tipoMaquina = new TipoDeMaquina();
            tipoMaquina = objGestorTiposMaquinas.GetTipoDeMaquinaById(Convert.ToInt32(pid));
            return new JavaScriptSerializer().Serialize(tipoMaquina);
        }

        [OperationContract]
        public void insertarTiposDeMaquina(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            string nombre = dictionary["pnombre"];
            string descripcion = dictionary["pdescripcion"];
            byte[] foto = System.Convert.FromBase64String(dictionary["pfoto"]);

            objGestorTiposMaquinas.insertarTipoDeMaquina(foto, nombre, descripcion);

        }

        [OperationContract]
        public void modificarTiposDeMaquina(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = Convert.ToInt32(dictionary["pid"]);
            string nombre = dictionary["pnombre"];
            string descripcion = dictionary["pdescripcion"];
            Boolean habilitado = Convert.ToBoolean(dictionary["phabilitado"]);
            byte[] foto = System.Convert.FromBase64String(dictionary["pfoto"]);

            objGestorTiposMaquinas.modificarTipoDeMaquina(id, foto, nombre, descripcion, habilitado);

        }

        [OperationContract]
        public void eliminarTipoDeMaquina(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["pidTipoMaquina"]);

            TipoDeMaquina tipoMaquinaPorEliminar = new TipoDeMaquina(id);

            objGestorTiposMaquinas.eliminarTipoDeMaquina(tipoMaquinaPorEliminar);

        }
    }
}
