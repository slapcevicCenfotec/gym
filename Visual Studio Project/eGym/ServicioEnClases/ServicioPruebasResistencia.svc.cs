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

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Web.Script.Services.ScriptService]
    public class ServicioPruebasResistencia
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        GestorPruebaResistencia objGestorPrueba = new GestorPruebaResistencia();

        [WebGet()]
        [OperationContract]
        public string obtenerPruebasResistencia()
        {

            List<PruebaResistencia> listaPruebasResistencia = new List<PruebaResistencia>();
            listaPruebasResistencia = objGestorPrueba.listarPruebasResistencia().ToList();
            return new JavaScriptSerializer().Serialize(listaPruebasResistencia);

        }

        [WebGet()]
        [OperationContract]
        public string obtenerTipoPruebasResistencia()
        {
            GestorTipoPruebaResistencia objGestorTipoPrueba = new GestorTipoPruebaResistencia();
            List<TipoPruebaResistencia> listaTipoPruebas = new List<TipoPruebaResistencia>();
            listaTipoPruebas = objGestorTipoPrueba.listarTipoPrueba().ToList();
            return new JavaScriptSerializer().Serialize(listaTipoPruebas);

        }
        [WebGet()]
        [OperationContract]
        public string comprobarPruebaResistencia(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);
            string id = dictionary["pId"].ToString();


            List<PruebaResistencia> listaPruebas = new List<PruebaResistencia>();
            listaPruebas = objGestorPrueba.obtenerPruebaResistencia(Convert.ToInt32(id));
            Boolean PruebaRealizada = false;
            if ((listaPruebas[0].ListaPruebas) == null)
            {
                PruebaRealizada = false;
            }
            else {
                PruebaRealizada = true;
            }

            return new JavaScriptSerializer().Serialize(PruebaRealizada);

        }

        [WebGet()]
        [OperationContract]
        public string ObtenerPruebaPorId(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);
            string id = dictionary["pid"].ToString();


            List<PruebaResistencia> listaPruebas = new List<PruebaResistencia>();
            listaPruebas = objGestorPrueba.obtenerPruebaResistencia(Convert.ToInt32(id));
            return new JavaScriptSerializer().Serialize(listaPruebas);

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
