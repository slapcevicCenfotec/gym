<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="PruebaResistencia.aspx.vb" Inherits="UI_WEB.PruebaResistencia" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%> />
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%> />
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%> />



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
            <form id="form1" runat="server">
    <div id="prbResistencia">

    </div>
<div class="col-lg-12">
<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;border-color:#999;}
.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:#999;color:#444;background-color:#F7FDFA;}
.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:#999;color:#fff;background-color:#26ADE4;}
.tg .tg-rd2y{font-size:16px}
.tg .tg-9vto{font-family:Verdana, Geneva, sans-serif !important;}
</style>
<table class="tg" id="tblPruebas">
  <tr>
    <th class="tg-031e">Evaluacion</th>
    <th class="tg-031e" colspan="4">RM#</th>
    <th class="tg-031e" colspan="3">Porcentajes</th>
  </tr>
  <tr>
    <td class="tg-031e">Ejercicio</td>
    <td class="tg-031e">Serie</td>
    <td class="tg-031e">Repeticiones</td>
    <td class="tg-031e">Peso</td>
    <td class="tg-031e">1 RM<br></td>
    <td class="tg-031e">60%</td>
    <td class="tg-031e">70%</td>
    <td class="tg-031e">80%</td>
  </tr>
</table>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="http://localhost:60166/ServicioPruebasResistencia.svc" />
            </Services>
        </asp:ScriptManager>

        </form>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server"> 

    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/PruebasResistencia.js")%>"></script>
</asp:Content>
