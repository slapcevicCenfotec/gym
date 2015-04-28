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
    public class ServicioPago
    {
        GestorPago objGestorPago = new GestorPago();
        [WebGet()]
        [OperationContract]
        public string getAllPago()
        {
            List<Pago> listaPagos = new List<Pago>();
            listaPagos = objGestorPago.listarPagos();
            return new JavaScriptSerializer().Serialize(listaPagos);
        }
        [WebGet()]
        [OperationContract]
        public string getPagoPorUsuario(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);
            int idUsuario = int.Parse(dictionary["id"]);

            List<Pago> listaPagos = new List<Pago>();
            listaPagos = objGestorPago.listarPagosPorUsuario(idUsuario);
            return new JavaScriptSerializer().Serialize(listaPagos);
        }

        [WebGet()]
        [OperationContract]
        public string getPagoById(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["id"]);
            Pago auxPago = new Pago();
            return new JavaScriptSerializer().Serialize(auxPago);
        }


        [WebMethod]
        [OperationContract]
        public void insertarPago(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            string factura = dictionary["factura"]; 
            double monto = Convert.ToDouble(dictionary["monto"]);
            int tipo = int.Parse(dictionary["tipo"]);
            DateTime hasta = Convert.ToDateTime(dictionary["hasta"]);
            DateTime desde = Convert.ToDateTime(dictionary["desde"]);
            DateTime fecha = Convert.ToDateTime(dictionary["fecha"]);
            int usuario = int.Parse(dictionary["usuario"]);

            objGestorPago.insertarPago(factura, monto, tipo, hasta, desde, usuario);
        }
    }
}
