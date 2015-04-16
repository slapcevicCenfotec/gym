<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="ListarEjercicios.aspx.vb" Inherits="UI_WEB.ListarEjercicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="http://localhost:85/eGym/ServicioEjercicio.svc" />
        </Services>
    </asp:ScriptManager>

   <%--  <input type="button" id="btnBuscarMusculos" onclick="insertImage()" value="insert image" />--%>
        <form method="post" enctype="multipart/form-data">
            <label for="file">Choose File</label>
            <input type="file"/>
            <input type="submit" value="sent" />
        </form>

    <canvas id="miCanvas" width="450" height="350">Su navegador no soporta Canvas.</canvas>

 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
   
     <script>
         $(document).ready(function () {
             //buscarEjercicios();
             //dibujarCanvas();
         });


    function dibujarCanvas() {
        var canvas = document.getElementById('miCanvas');
        var contexto = canvas.getContext('2d');
        // imagen
        var imagen = new Image();
        imagen.onload = function () {
            contexto.drawImage(imagen, 0, 0);  // imagen completa en la posición (0,0) 
            contexto.drawImage(imagen, 285, 0, 150, 107); // escalado
            contexto.drawImage(imagen, 130, 85, 80, 60, 285, 205, 150, 107); // escalado de una porción
            contexto.strokeStyle = 'yellow';
            contexto.strokeRect(130, 85, 80, 60); // rectángulo amarillo
        }
        imagen.src = 'http://www.aulaclic.es/articulos/graficos/cabeza_pato.png';
    }
    </script>

</asp:Content>
