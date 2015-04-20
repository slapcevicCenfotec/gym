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
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Web.Script.Services.ScriptService]
    public class ServicioFichasDeMedicion
    {
        GestorFichaMedicion gestor = new GestorFichaMedicion();

        [WebGet()]
        [OperationContract]
        public string obtenerFichasDeMedicion()
        {
            List<FichaMedicion> listaFichasDeMedicion = new List<FichaMedicion>();
            listaFichasDeMedicion = gestor.listarFichasMedicion();
            return new JavaScriptSerializer().Serialize(listaFichasDeMedicion);
        }

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
                float peso = float.Parse(diccionario["ppeso"]);
                float altura = float.Parse(diccionario["paltura"]);
                float imc = float.Parse(diccionario["pimc"]);
                string clasificacionIMC = Convert.ToString(diccionario["pclasificacionIMC"]);
                float porcentajeGrasa = float.Parse(diccionario["pporcentajeGrasa"]);
                float porcentajeMasa = float.Parse(diccionario["pporcentajeMasa"]);
                float pesoGraso = float.Parse(diccionario["ppesoGraso"]);
                float cintura = float.Parse(diccionario["pcintura"]);
                float cadera = float.Parse(diccionario["pcadera"]);
                float abdomen = float.Parse(diccionario["pabdomen"]);
                float pecho = float.Parse(diccionario["ppecho"]);
                float espalda = float.Parse(diccionario["pespalda"]);
                float musloIzquierdo = float.Parse(diccionario["pmusloIzquierdo"]);
                float musloDerecho = float.Parse(diccionario["pmusloDerecho"]);
                float bicepsIzquierdo = float.Parse(diccionario["pbicepsIzquierdo"]);
                float bicepsDerecho = float.Parse(diccionario["pbicepsDerecho"]);
                float bicepIzquierdoContr = float.Parse(diccionario["pbicepIzquierdoContr"]);
                float bicepDerechoContr = float.Parse(diccionario["pbicepDerechoContr"]);
                float pantorrillaIzquierda = float.Parse(diccionario["ppantorrillaIzquierda"]);
                float pantorrillaDerecha = float.Parse(diccionario["ppantorrillaDerecha"]);
                float abdominalIzquierdo = float.Parse(diccionario["pabdominalIzquierdo"]);
                float abdominalDerecho = float.Parse(diccionario["pabdominalDerecho"]);
                float pliegueMusloIzquierdo = float.Parse(diccionario["ppliegueMusloIzquierdo"]);
                float pliegueMusloDerecho = float.Parse(diccionario["ppliegueMusloDerecho"]);
                float plieguePantorrillaIzquierda = float.Parse(diccionario["pplieguePantorrillaIzquierda"]);
                float plieguePantorrillaDerecha = float.Parse(diccionario["pplieguePantorrillaDerecha"]);
                float tricepsIzquierdo = float.Parse(diccionario["ptricepsIzquierdo"]);
                float tricepsDerecho = float.Parse(diccionario["ptricepsDerecho"]);
                float subescapularIzquierdo = float.Parse(diccionario["psubescapularIzquierdo"]);
                float subescapularDerecho = float.Parse(diccionario["psubescapularDerecho"]);
                float supraespinalIzquierdo = float.Parse(diccionario["psupraespinalIzquierdo"]);
                float supraespinalDerecho = float.Parse(diccionario["psupraespinalDerecho"]);

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
