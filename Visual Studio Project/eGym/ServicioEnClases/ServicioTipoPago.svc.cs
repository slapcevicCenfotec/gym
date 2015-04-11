﻿using System;
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
    public class ServicioTipoPago
    {
        GestorTipoDePago objGestorTipoPago = new GestorTipoDePago();
        [WebGet()]
        [OperationContract]
        public string getAllTipoDePago()
        {
            List<TipoDePago> listaTipoPagos = new List<TipoDePago>();
            listaTipoPagos = objGestorTipoPago.listarTiposDePago();
            return new JavaScriptSerializer().Serialize(listaTipoPagos);
        }

        [WebGet()]
        [OperationContract]
        public string getTipoDePagoById(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["id"]);
            TipoDePago auxTipoPago = new TipoDePago();
            auxTipoPago = objGestorTipoPago.tipoDePagoPorId(id);
            return new JavaScriptSerializer().Serialize(auxTipoPago);
        }


        [WebMethod]
        [OperationContract]
        public void insertarTipoDePago(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            string nombre = dictionary["nombre"];
            double monto = Convert.ToDouble(dictionary["monto"]);
            int duracion = int.Parse(dictionary["duracion"]);
            objGestorTipoPago.insertarTipoDePago(nombre, monto, duracion);

        }

        [WebGet()]
        [OperationContract]
        public void modificarTipoDePago(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["id"]);
            string nombre = dictionary["nombre"];
            double monto = Convert.ToDouble(dictionary["monto"]);
            int duracion = int.Parse(dictionary["duracion"]);
            bool habilitado = Convert.ToBoolean(dictionary["habilitado"]);

            objGestorTipoPago.modificarTipoDePago(id, nombre, monto, duracion,habilitado);
        }

        [WebGet()]
        [OperationContract]
        public void eliminarTipoDePago(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            var id = Convert.ToInt32(dictionary["pid"]);

            objGestorTipoPago.eliminarTipoDePago(id);
        }
    }
}
