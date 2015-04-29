<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Modificar.aspx.vb" Inherits="UI_WEB.Modificar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/local/FichaMedicion.css")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Modificar tipo de máquina</h1>
                <label id="txtIdTipoMaquina" style="display:none"></label>
                <label id="txtHabilitado" style="display:none"></label>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Modifique el formulario con la información del tipo de máquina
                    </p>                    
                    <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnGuardar">Guardar</button>
                    <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnCancelar">Cancelar</button>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="col-md-6">
			<div class="card">
				<div class="card-body">
					<form class="form form-validate" role="form" id="modificarTipoMaquinaForm">
						<div class="form-group floating-label">
                            <input type="text" class="form-control" id="txtNombreTipoDeMaquina" required/>
							<label for="txtNombreTipoDeMaquina">Nombre del tipo de máquina</label>
						</div>
						<div class="form-group floating-label">
							<textarea class="form-control control-4-rows" id="txtDescripcion" rows="1" required></textarea>
							<label for="txtDescripcion">Descripción</label>
						</div>
					</form>
				</div><!--end .card-body -->
			</div><!--end .card -->
		</div><!--end .card -->

        <div class="col-md-6">
			<div class="card">
				<div class="card-body">
					<form class="form" role="form">
						<div style="width: 100%; height: 216px; overflow: hidden; position: relative" class="picture">
                            <img src="" id="imgFoto"/>
                            <input type="file" id="imagen">
                            <canvas id="myCanvas"></canvas>
                        </div>
					</form>
				</div><!--end .card-body -->
			</div><!--end .card -->
		</div><!--end .card -->
	</div><!--end .card -->
    <form runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServiciosTiposDeMaquinas.svc"/>
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/localScripts/ModificarTiposDeMaquina.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/raphael/raphael-min.js")%>"></script>
</asp:Content>
