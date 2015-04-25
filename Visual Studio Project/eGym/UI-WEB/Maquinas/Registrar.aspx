<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Registrar.aspx.vb" Inherits="UI_WEB.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Nueva máquina</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Rellene el formulario con la información de la máquina
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="col-md-8">
            <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnGuardar">Guardar</button>
            <button type="submit" class="btn btn-default btn btn-primary ink-reaction" id="btnCancelar">Cancelar</button>
			<div class="card">
				<div class="card-body">
					<form class="form form-validate" role="form" id="maquinasForm">
						<div class="form-group floating-label">
							<select id="cmbTiposDeMaquinas" name="cmbTiposDeMaquinas" class="form-control" required>
								<option value="">&nbsp;</option>
                            </select>
                            <label for="cmbTiposDeMaquinas">Tipo de máquina</label>
						</div>
						<div class="form-group floating-label">
                            <input type="text" class="form-control" id="txtNumeroActivo" required/>
							<label for="txtNumeroActivo">Número de activo</label>
						</div>
						<div class="form-group floating-label">
							<input type="text" class="form-control" id="txtNumeroMaquina" required/>
							<label for="txtNumeroMaquina">Número de máquina</label>
						</div>
					</form>
				</div><!--end .card-body -->
			</div><!--end .card -->
		</div><!--end .card -->
	</div><!--end .card -->
    <form runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServiciosMaquinas.svc" />
                <asp:ServiceReference Path="http://localhost/egymServices/ServiciosTiposDeMaquinas.svc"/>
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/localScripts/RegistrarMaquinas.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    <script>
        $(document).ready(function () {
            search();
        });
    </script>
</asp:Content>
