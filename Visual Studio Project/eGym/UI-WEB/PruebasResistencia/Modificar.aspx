<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Modificar.aspx.vb" Inherits="UI_WEB.Modificar6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Modificar Prueba</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Modifique el formulario con la información de la prueba
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="col-md-8">
            <button type="button" class="btn btn-default btn btn-primary ink-reaction"  id="btnGuardar" ">Guardar</button>
            <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnCancelar" >Cancelar</button>
			<div class="card">
				<div class="card-body">
					<form class="form-horizontal" role="form" id="PruebasForm">
					</form>
                    <div class="card-body no-padding">
            <button type="button" class="btn btn-default btn btn-primary ink-reaction"  id="AgregarEjercicios" ">Agregar Ejercicios</button>
            <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="ModificarEjejrcicios" >Modificar Ejercicios</button>
                    <div class="card-body">
                    <div class="table-responsive">
                        <table id="tblPruebas" class="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <th style="display:none">Id</th>
                                    <th>Ejercicio</th>
                                    <th>Serie</th>
                                    <th>Repeticiones</th>
                                    <th>Peso</th>
                                    <th>1 RM<br></th>
                                    <th>60%</th>
                                    <th>70%</th>
                                    <th>80%</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                        </div>
                    </DIV>
				</div><!--end .card-body -->
			</div><!--end .card -->
		</div><!--end .card -->
	</div><!--end .card -->
    <form id="Form2" runat="server">
        <asp:ScriptManager ID="ScriptManager2" runat="server" >
                    <Services>
                        <asp:ServiceReference Path="http://localhost/egymServices/ServicioPruebasResistencia.svc" />
                    </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/localScripts/PruebasResistencia.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
</asp:Content>
