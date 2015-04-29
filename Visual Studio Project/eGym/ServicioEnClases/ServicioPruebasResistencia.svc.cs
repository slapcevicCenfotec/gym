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
    public class ServicioPruebasResistencia
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        GestorPruebaResistencia objGestorPrueba = new GestorPruebaResistencia();
        GestorResultadoPruebaResistencia objGestorPruebaEjercicio = new GestorResultadoPruebaResistencia();

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
        [WebMethod]
        [OperationContract]
        public void ModificarPrueba(string datosSerializados)
        {


            var jss = new JavaScriptSerializer();
            //var dictionary = jss.Deserialize<Dictionary<string, string,>>(datosSerializados);
            var dictionary = jss.Deserialize<Dictionary<String, object>>(datosSerializados);
            int id = Convert.ToInt32(dictionary["pId"].ToString());
            Double peso = Convert.ToDouble(dictionary["ppeso"].ToString());
            int idTipoPrueba = Convert.ToInt32(dictionary["pidTipoPrueba"].ToString());

            //{
            //    dato.GetType();
            //}
            objGestorPrueba.ModificarPrueba(id, peso, idTipoPrueba);
        }

        [WebMethod]
        [OperationContract]
        public void EliminarPrueba(string datosSerializados)
        {


            var jss = new JavaScriptSerializer();
            //var dictionary = jss.Deserialize<Dictionary<string, string,>>(datosSerializados);
            var dictionary = jss.Deserialize<Dictionary<String, object>>(datosSerializados);
            int id = Convert.ToInt32(dictionary["pId"].ToString());

            //{
            //    dato.GetType();
            //}
            objGestorPruebaEjercicio.EliminarResultadoPrueba(id);
        }

        [WebMethod]
        [OperationContract]
        public void insertarPruebasEjercicio (string datosSerializados)
        {


            var jss = new JavaScriptSerializer();
            //var dictionary = jss.Deserialize<Dictionary<string, string,>>(datosSerializados);
            var dictionary = jss.Deserialize<Dictionary<String, object>>(datosSerializados);
            int idPrueba = Convert.ToInt32(dictionary["pidPrueba"].ToString());
            int series = Convert.ToInt32(dictionary["pseries"].ToString());
            int repeticiones = Convert.ToInt32(dictionary["prepeticiones"].ToString());
            Double peso = Convert.ToDouble(dictionary["ppeso"].ToString());
            Double rm1 = Convert.ToDouble(dictionary["prm1"].ToString());
            int idEjercicio = Convert.ToInt32(dictionary["pidEjercicio"].ToString());
            Double prc1 = Convert.ToDouble(dictionary["pprc1"].ToString());
            Double prc2 = Convert.ToDouble(dictionary["pprc2"].ToString());
            Double prc3 = Convert.ToDouble(dictionary["pprc3"].ToString());


            objGestorPruebaEjercicio.insertarResultadoPrueba(idEjercicio, series, repeticiones, peso, rm1, idPrueba, prc1, prc2, prc3);
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
