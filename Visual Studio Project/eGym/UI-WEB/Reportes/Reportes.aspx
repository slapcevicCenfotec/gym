<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Reportes.aspx.vb" Inherits="UI_WEB.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%> />
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%> />
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%> />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
						<!-- BEGIN TOGGLE BUTTON GROUPS -->
						<div class="row">

							<div class="col-lg-offset-1 col-md-5 col-sm-6">
                                                <div class="section-header">
            <h3 class="text-primary">Reportes</h3>
        </div>
								<div class="card">
									<div class="card-body">
										<div class="btn-group" data-toggle="buttons">
<button type="button" class="btn btn-block ink-reaction btn-flat btn-default-light" id="btnReporteExcepciones">Reporte De Excepciones</button>
<button type="button" class="btn btn-block ink-reaction btn-flat btn-default-light" id="btnReporteFuncionarios">Reporte De Funcionarios</button>
<button type="button" class="btn btn-block ink-reaction btn-flat btn-default-light" id="btnReporteHorarios">Reporte de horarios de funcionarios</button>										
<button type="button" class="btn btn-block ink-reaction btn-flat btn-default-light" id="btnMorosos">Reporte de clientes morosos</button>	
<button type="button" class="btn btn-block ink-reaction btn-flat btn-default-light" id="btnEventos">Reporte de eventos</button>	
									</div><!--end .card-body -->
								</div><!--end .card -->
							</div><!--end .col -->
						</div><!--end .row -->
						<!-- END TOGGLE BUTTON GROUPS -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
        <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/Reportes.js")%>"></script>
</asp:Content>
