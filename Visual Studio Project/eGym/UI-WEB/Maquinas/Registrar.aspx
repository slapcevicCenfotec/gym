﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Registrar.aspx.vb" Inherits="UI_WEB.Registrar" %>
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
            <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnCancelar">Cancelar</button>
			<div class="card">
				<div class="card-body">
					<form class="form" role="form">
						<div class="form-group floating-label">
							<select id="cmbTiposDeMaquinas" name="cmbTiposDeMaquinas" class="form-control">
								<option value="">&nbsp;</option>
                            </select>
                            <label for="cmbTiposDeMaquinas">Tipo de máquina</label>
						</div>
						<div class="form-group floating-label">
                            <input type="text" class="form-control" id="txtNumeroActivo"/>
							<label for="txtNumeroActivo">Número de activo</label>
						</div>
						<div class="form-group floating-label">
							<input type="text" class="form-control" id="txtNumeroMaquina">
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
                <asp:ServiceReference Path="http://localhost:60166/ServicioUsuario.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
</asp:Content>
