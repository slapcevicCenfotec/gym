<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="PruebaResistencia.aspx.vb" Inherits="UI_WEB.PruebaResistencia" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%> />
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%> />
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%> />



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
            <form id="form1" runat="server">

<div class="col-lg-12">
<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;border-color:#999;}
.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:#999;color:#444;background-color:#F7FDFA;}
.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:#999;color:#fff;background-color:#26ADE4;}
.tg .tg-rd2y{font-size:16px}
.tg .tg-9vto{font-family:Verdana, Geneva, sans-serif !important;}
</style>
<div class="section-body contain-lg">

            <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Prueba de Resistencia</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl" id="prbResistencia">
                    <p class="lead">
                        Informacion de la prueba de resistencia del cliente
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
            <div class="row">
                <div class="col-md-4">
                        <a class="btn btn-raised btn-primary ink-reaction pull-right"  id="btnModificarPruebaResistencia">Modificar prueba de resistencia</a>
                </div>
                <div class="row"></div>
            </div>
<div class="card">
<div class="card-body">
    <table class="table table-striped no-margin" id="tblPruebas">
      <thead>
        <tr>
        <th class="tg-031e">Evaluacion</th>
        <th class="tg-031e" colspan="4">RM#</th>
        <th class="tg-031e" colspan="3">Porcentajes</th>
      </tr>
      <tr>
        <th class="tg-031e">Ejercicio</th>
        <th class="tg-031e">Serie</th>
        <th class="tg-031e">Repeticiones</th>
        <th class="tg-031e">Peso</th>
        <th class="tg-031e">1 RM<br></th>
        <th class="tg-031e">60%</th>
        <th class="tg-031e">70%</th>
        <th class="tg-031e">80%</th>
      </tr>
    </thead>
    </table>
</div>
</div>
</div>
 </div>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioPruebasResistencia.svc" />
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
