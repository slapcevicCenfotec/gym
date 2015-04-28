<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Agregar.aspx.vb" Inherits="UI_WEB.Agregar2" %>
<asp:Content ID="Content4" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Nuevo Rol</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Rellene el formulario con la información del Rol
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="col-md-8">
            <button type="button" class="btn btn-default btn btn-primary ink-reaction"  id="btnGuardar" onclick="ingresarRol()">Guardar</button>
            <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnCancelar" onclick="Cancelar()">Cancelar</button>
			<div class="card">
				<div class="card-body">
					<form class="form form-validate" role="form" id="RolesForm">
						<div class="form-group floating-label">
												<input type="text" class="form-control" id="nombre">
												<label for="nombre">Nombre</label>
						</div>
						<div class="form-group floating-label">
												<input type="text" class="form-control" id="descripcion">
												<label for="descripcion">Descripcion</label>
						</div>

					</form>
                    <div class="card-body no-padding">
                         <ul class="list" data-sortable="true" id="listaPermisos">
                        </ul>
                    </DIV>
				</div><!--end .card-body -->
			</div><!--end .card -->
		</div><!--end .card -->
	</div><!--end .card -->
    <form id="Form1" runat="server">
        <asp:ScriptManager ID="ScriptManager2" runat="server" >
                    <Services>
                        <asp:ServiceReference Path="http://localhost:60166/ServicioRol.svc" />
                        <asp:ServiceReference Path="http://localhost:60166/ServicioPermisos.svc" />
                    </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/localScripts/Permiso.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/Rol.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
</asp:Content>