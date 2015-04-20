<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Modificar.aspx.vb" Inherits="UI_WEB.Modificar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Modificar tipo de máquina</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Modifique el formulario con la información del tipo de máquina
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="col-md-8">
            <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnGuardar">Guardar</button>
            <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnCancelar">Cancelar</button>
			<div class="card">
				<div class="card-body">
					<form class="form" role="form">
						<div class="form-group floating-label">
                            <input type="text" class="form-control" id="txtNombreTipoDeMaquina"/>
							<label for="txtNombreTipoDeMaquina">Nombre del tipo de máquina</label>
						</div>
						<div class="form-group floating-label">
							<textarea class="form-control" id="txtDescripcion" rows="1"></textarea>
							<label for="txtDescripcion">Descripción</label>
						</div>
						<div class="form-group ">
                            <input type="file" class="form-control" id="fotoFile"/>
                            <br />
							<label for="fotoFile">Foto del tipo de máquina</label>
                            <img id="foto" style="max-width:500px">
						</div>
					</form>
				</div><!--end .card-body -->
			</div><!--end .card -->
		</div><!--end .card -->
	</div><!--end .card -->
    <form runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServiciosTiposDeMaquinas.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
</asp:Content>
