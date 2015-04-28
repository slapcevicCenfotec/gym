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
        GestorFichaMedicion gestorFicha = new GestorFichaMedicion();

        [WebGet()]
        [OperationContract]
        public string obtenerFichasDeMedicion()
        {
            List<FichaMedicion> listaFichasDeMedicion = new List<FichaMedicion>();
            listaFichasDeMedicion = gestorFicha.listarFichasMedicion();
            return new JavaScriptSerializer().Serialize(listaFichasDeMedicion);
        }

        [WebGet()]
        [OperationContract]
        public string obtenerFichaById(string pid)
        {
            FichaMedicion ficha = new FichaMedicion();
            ficha = gestorFicha.GetFichaById(Convert.ToInt32(pid));
            return new JavaScriptSerializer().Serialize(ficha);
        }

        [OperationContract]
        public void insertarFichaDeMedicion(string datosSerializados)
        {
            var javaScriptSerializer = new JavaScriptSerializer();
            var diccionario = javaScriptSerializer.Deserialize<Dictionary<string, string>>(datosSerializados);

            int cliente = Convert.ToInt32(diccionario["pcliente"]);
            float peso = float.Parse(diccionario["ppeso"]);
            float altura = float.Parse(diccionario["paltura"]);
            float imc = float.Parse(diccionario["pimc"]);
            string clasificacionIMC = diccionario["pclasificacionIMC"];
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

            gestorFicha.insertarFichaMedicion(cliente, peso, altura, imc, clasificacionIMC, porcentajeGrasa,
            porcentajeMasa, pesoGraso, cintura, cadera, abdomen, pecho, espalda, musloIzquierdo, musloDerecho,
            bicepsIzquierdo, bicepsDerecho, bicepIzquierdoContr, bicepDerechoContr, pantorrillaIzquierda,
            pantorrillaDerecha, abdominalIzquierdo, abdominalDerecho, pliegueMusloIzquierdo, pliegueMusloDerecho,
            pantorrillaIzquierda, pantorrillaDerecha, tricepsIzquierdo, tricepsDerecho, subescapularIzquierdo,
            subescapularDerecho, supraespinalIzquierdo, supraespinalDerecho);
        }

        [OperationContract]
        public void modificarFichaDeMedicion(string datosSerializados)
        {
            var javaScriptSerializer = new JavaScriptSerializer();
            var diccionario = javaScriptSerializer.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = Convert.ToInt32(diccionario["pid"]);
            int cliente = Convert.ToInt32(diccionario["pcliente"]);
            float peso = float.Parse(diccionario["ppeso"]);
            float altura = float.Parse(diccionario["paltura"]);
            float imc = float.Parse(diccionario["pimc"]);
            string clasificacionIMC = diccionario["pclasificacionIMC"];
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
            Boolean habilitado = Boolean.Parse(diccionario["phabilitado"]);

            gestorFicha.modificarFichaMedicion(id, cliente, peso, altura, imc, clasificacionIMC,
                            porcentajeGrasa, porcentajeMasa, pesoGraso, bicepsIzquierdo,
                            bicepsDerecho, bicepIzquierdoContr, bicepDerechoContr, pantorrillaIzquierda,
                            pantorrillaDerecha, musloIzquierdo, musloDerecho, cintura, abdomen,
                            cadera, pecho, espalda, tricepsIzquierdo, tricepsDerecho,
                            subescapularIzquierdo, subescapularDerecho, supraespinalIzquierdo, supraespinalDerecho,
                            abdominalIzquierdo, abdominalDerecho, pliegueMusloIzquierdo, pliegueMusloDerecho,
                            plieguePantorrillaIzquierda, plieguePantorrillaDerecha, habilitado);

        }

        [OperationContract]
        public void eliminarFichaMedicion(string datosSerializados)
        {
            var jss = new JavaScriptSerializer();
            var dictionary = jss.Deserialize<Dictionary<string, string>>(datosSerializados);

            int id = int.Parse(dictionary["pidFicha"]);

            FichaMedicion fichaPorEliminar = new FichaMedicion(id);

            gestorFicha.eliminarFichaMedicion(fichaPorEliminar);

        }

        [WebGet()]
        [OperationContract]
        public string obtenerFichasPorCliente(string pcliente)
        {
            List<FichaMedicion> listaFichasDeMedicionPorCliente = new List<FichaMedicion>();
            listaFichasDeMedicionPorCliente = gestorFicha.listarFichasMedicionPorCliente(Convert.ToInt32(pcliente));
            return new JavaScriptSerializer().Serialize(listaFichasDeMedicionPorCliente);
        }
    }
}
