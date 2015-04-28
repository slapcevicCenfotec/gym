﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServicioEnClases.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


    <link href="Style/jquery.dataTables.css" rel="stylesheet" />


    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="Scripts/jquery-1.10.1.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="js/jquery.js">
    </script>
    <script type="text/javascript" src="localScripts/buscarMusculos.js">
    </script>

    <%-- <script>
        $(document).ready(function () {
            //    var servicio1 = new ServicioEnClases.ServicioEventoCalendario();
            //    servicio1.getAllEventoCalendario(onsucess, null, null);
            //});
            //function onsucess(resul) {
            //    alert(resul);
            //}
        });
    </script>--%>
</head>
<body>
    <button type="button" class="btn btn-default" onclick="ingresarMusculo()">Submit</button>

    <script>
        //$(document).ready(function () {

        //    onSuccess();

        //});

        //function onSuccess() {
        //    var servicio1 = ServicioEnClases.ServicioEventoCalendario();
        //    servicio1.getAllEventoCalendario(null, null, null);
        //}


        //function dibujarCanvas() {
        //    var canvas = document.getElementById('miCanvas');
        //    var contexto = canvas.getContext('2d');
        //    // imagen
        //    var imagen = new Image();
        //    imagen.onload = function () {
        //        contexto.drawImage(imagen, 0, 0);  // imagen completa en la posición (0,0) 
        //        contexto.drawImage(imagen, 285, 0, 150, 107); // escalado
        //        contexto.drawImage(imagen, 130, 85, 80, 60, 285, 205, 150, 107); // escalado de una porción
        //        contexto.strokeStyle = 'yellow';
        //        contexto.strokeRect(130, 85, 80, 60); // rectángulo amarillo
        //    }
        //    imagen.src = 'http://www.aulaclic.es/articulos/graficos/cabeza_pato.png';
        //}
    </script>

    <canvas id="miCanvas" width="450" height="350">Su navegador no soporta Canvas.</canvas>

    <br />
    <br />
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <%--<asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="~/ServicioEventoCalendario.svc" />
            </Services>
        </asp:ScriptManager>--%>
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="http://localhost:85/eGym/ServicioEjercicio.svc" />
            </Services>
            <Services>
                <asp:ServiceReference Path=" http://localhost:85/eGym/ServicioProyecto.svc" />
            </Services>
        </asp:ScriptManager>

        <input type="button" id="btnBuscarMusculos" onclick="buscarMusculos()" value="Buscar Musculos" />

        <input type="button" id="btnModificarMusculo" onclick="modificarMusculo()" value="Modificar" />

        <input type="button" id="btnEliminarMusculo" onclick="eliminarMusculo()" value="Eliminar" />

        <table id="tblDioses" class="display">
            <thead>
                <tr>
                    <td>ID</td>
                    <td>Nombre</td>
                    <td>Ubicacion</td>
                    <td>Origen</td>
                    <td>Inserccion</td>
                    <td>Inervacion</td>
                    <td>Irrigacion</td>
                </tr>
            </thead>
            <tbody></tbody>

        </table>

        <br />
    </form>
    <%-- <div class="form-group">
    <label for="">Nombre</label>
    <input type="text" class="form-control" id="txtnombreMusculo" placeholder="Enter nombre">
  </div>
  <div class="form-group">
    <label for="">Ubicacion</label>
    <input type="text" class="form-control" id="txtubicacionMusculo" placeholder="Ubicacion">
  </div>
  <div class="form-group">
     <label for="">Origen</label>
    <input type="text" class="form-control" id="txtorigenMusculo" placeholder="Origen">
  </div>
     <div class="form-group">
     <label for="">Insercccion</label>
    <input type="text" class="form-control" id="txtinserccionMusculo" placeholder="Inserccion">
  </div>
  <div class="form-group">
     <label for="">Inervacion</label>
    <input type="text" class="form-control" id="txtinervacionMusculo" placeholder="Inervacion">
  </div>
   <div class="form-group">
     <label for="">Irrigacion</label>
    <input type="text" class="form-control" id="txtirrigacionMusculo" placeholder="Irrigacion">
  </div>
  <button type="button" class="btn btn-default" onclick="ingresarMusculo()">Submit</button>
    </div>
    </form>--%>
</body>
</html>
