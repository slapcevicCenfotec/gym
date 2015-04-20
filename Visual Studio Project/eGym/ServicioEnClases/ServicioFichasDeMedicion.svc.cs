using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.Services;
using EL;
using BLL;

namespace ServicioEnClases
{
    [ServiceContract(Namespace = "ServicioEnClases")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Web.Script.Services.ScriptService]
    public class ServicioFichasDeMedicion
    {
        GestorFichaMedicion gestor = new GestorFichaMedicion();

        [OperationContract]
        public void InsertarFichaDeMedicion(string datos)
        {
            var serializer = new JavaScriptSerializer();
            try
            {
                var javaScriptSerializer = new JavaScriptSerializer();
                var diccionario = javaScriptSerializer.Deserialize<Dictionary<string, string>>(datos);

                int cliente = Convert.ToInt32(diccionario["pcliente"]);
                DateTime fecha = Convert.ToDateTime(diccionario["pfecha"]);
                decimal peso = Convert.ToDecimal(diccionario["ppeso"]);
                decimal altura = Convert.ToDecimal(diccionario["paltura"]);
                decimal imc = Convert.ToDecimal(diccionario["pimc"]);
                string clasificacionIMC = Convert.ToString(diccionario["pclasificacionIMC"]);
                decimal porcentajeGrasa = Convert.ToDecimal(diccionario["pporcentajeGrasa"]);
                decimal porcentajeMasa = Convert.ToDecimal(diccionario["pporcentajeMasa"]);
                decimal pesoGraso = Convert.ToDecimal(diccionario["ppesoGraso"]);
                decimal cintura = Convert.ToDecimal(diccionario["pcintura"]);
                decimal cadera = Convert.ToDecimal(diccionario["pcadera"]);
                decimal abdomen = Convert.ToDecimal(diccionario["pabdomen"]);
                decimal pecho = Convert.ToDecimal(diccionario["ppecho"]);
                decimal espalda = Convert.ToDecimal(diccionario["pespalda"]);
                decimal musloIzquierdo = Convert.ToDecimal(diccionario["pmusloIzquierdo"]);
                decimal musloDerecho = Convert.ToDecimal(diccionario["pmusloDerecho"]);
                decimal bicepsIzquierdo = Convert.ToDecimal(diccionario["pbicepsIzquierdo"]);
                decimal bicepsDerecho = Convert.ToDecimal(diccionario["pbicepsDerecho"]);
                decimal bicepIzquierdoContr = Convert.ToDecimal(diccionario["pbicepIzquierdoContr"]);
                decimal bicepDerechoContr = Convert.ToDecimal(diccionario["pbicepDerechoContr"]);
                decimal pantorrillaIzquierda = Convert.ToDecimal(diccionario["ppantorrillaIzquierda"]);
                decimal pantorrillaDerecha = Convert.ToDecimal(diccionario["ppantorrillaDerecha"]);
                decimal abdominalIzquierdo = Convert.ToDecimal(diccionario["pabdominalIzquierdo"]);
                decimal abdominalDerecho = Convert.ToDecimal(diccionario["pabdominalDerecho"]);
                decimal pliegueMusloIzquierdo = Convert.ToDecimal(diccionario["ppliegueMusloIzquierdo"]);
                decimal pliegueMusloDerecho = Convert.ToDecimal(diccionario["ppliegueMusloDerecho"]);
                decimal plieguePantorrillaIzquierda = Convert.ToDecimal(diccionario["pplieguePantorrillaIzquierda"]);
                decimal plieguePantorrillaDerecha = Convert.ToDecimal(diccionario["pplieguePantorrillaDerecha"]);
                decimal tricepsIzquierdo = Convert.ToDecimal(diccionario["ptricepsIzquierdo"]);
                decimal tricepsDerecho = Convert.ToDecimal(diccionario["ptricepsDerecho"]);
                decimal subescapularIzquierdo = Convert.ToDecimal(diccionario["psubescapularIzquierdo"]);
                decimal subescapularDerecho = Convert.ToDecimal(diccionario["psubescapularDerecho"]);
                decimal supraespinalIzquierdo = Convert.ToDecimal(diccionario["psupraespinalIzquierdo"]);
                decimal supraespinalDerecho = Convert.ToDecimal(diccionario["psupraespinalDerecho"]);

                gestor.insertarFichaMedicion(cliente, fecha, peso, altura, imc, clasificacionIMC, porcentajeGrasa, porcentajeMasa,
                pesoGraso,cintura,cadera,abdomen,pecho,espalda,musloIzquierdo,musloDerecho,bicepsIzquierdo,
                bicepsDerecho,bicepIzquierdoContr,bicepDerechoContr,pantorrillaIzquierda,pantorrillaDerecha,
                abdominalIzquierdo,abdominalDerecho,pliegueMusloIzquierdo,pliegueMusloDerecho,
                plieguePantorrillaIzquierda, plieguePantorrillaDerecha,tricepsIzquierdo,tricepsDerecho,
                subescapularIzquierdo, subescapularDerecho, supraespinalIzquierdo,supraespinalDerecho);
            }
            catch (Exception ex){

            }
        }
    }
}
