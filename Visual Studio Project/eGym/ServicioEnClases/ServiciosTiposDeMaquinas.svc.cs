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
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
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

        [OperationContract]
        public void insertarTiposDeMaquina(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            string nombre = dictionary["pnombre"];
            string descripcion = dictionary["pdescripcion"];
            byte[] foto = System.Convert.FromBase64String(dictionary["pfoto"]);

            //objGestorTiposMaquinas.insertarTipoDeMaquina(foto, nombre, descripcion);

        }

        public static string FixBase64ForImage(string image)
        {
            StringBuilder sbText = new StringBuilder(image, image.Length);
            sbText.Replace("\r\n", String.Empty);
            sbText.Replace(" ", String.Empty);
            return sbText.ToString();
        }
    }
}
