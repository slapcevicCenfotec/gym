<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Agregar.aspx.vb" Inherits="UI_WEB.Agregar4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Nueva Prueba</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Complete la informacion de la prueba
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="col-md-8">
            <button type="button" class="btn btn-default btn btn-primary ink-reaction"  id="btnGuardar" >Guardar</button>
            <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnCancelar" >Cancelar</button>
			<div class="card">
				<div class="card-body">
					<form class="form form-validate" role="form" id="PruebaEjericiosForm">
						<div class="form-group floating-label">
												<input type="text" class="form-control" id="series">
												<label for="nombre">Series</label>
						</div>
						<div class="form-group floating-label">
												<input type="text" class="form-control" id="repeticiones">
												<label for="descripcion">Repeticiones</label>
						</div>
                        <div class="form-group floating-label">
												<input type="text" class="form-control" id="peso">
												<label for="peso">Peso</label>
						</div>
                         <div class="form-group floating-label">
												<input type="text" class="form-control" id="rm1">
												<label for="rm1">Rm1</label>
						</div>
                        <div class="form-group floating-label">
												<input type="text" class="form-control" id="prc1">
												<label for="rm1">70%</label>
						</div>
                        <div class="form-group floating-label">
												<input type="text" class="form-control" id="prc2">
												<label for="rm1">80%</label>
						</div>
                                                <div class="form-group floating-label">
												<input type="text" class="form-control" id="prc3">
												<label for="rm1">90%</label>
						</div>
					</form>
				</div><!--end .card-body -->
			</div><!--end .card -->
		</div><!--end .card -->
	</div><!--end .card -->
    <form id="Form1" runat="server">
        <asp:ScriptManager ID="ScriptManager2" runat="server" >
                    <Services>
                        <asp:ServiceReference Path="http://localhost/egymServices/ServicioEjercicio.svc" />
                        <asp:ServiceReference Path="http://localhost/egymServices/ServicioPruebasResistencia.svc" />
                    </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/localScripts/PruebaEjercicios.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
</asp:Content>
