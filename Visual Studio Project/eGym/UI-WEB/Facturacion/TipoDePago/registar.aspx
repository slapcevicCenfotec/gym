<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="registar.aspx.vb" Inherits="UI_WEB.agregar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/select2/select2.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/multi-select/multi-select.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-datepicker/datepicker3.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/jquery-ui/jquery-ui-theme.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-colorpicker/bootstrap-colorpicker.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-tagsinput/bootstrap-tagsinput.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/typeahead/typeahead.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/dropzone/dropzone-theme.css")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Tipo de pago</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Agregar nuevo tipo de pago
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="row">

            <!-- BEGIN LAYOUT RIGHT SIDEBAR -->
            <div class="col-md-12">
                <div class="card tabs-left style-default-light">
                    <div class="col-md-4 col-md-offset-4 ">
                    <form role="form" class="form">
                            	<div class="form-group floating-label">
									<input type="text" id="txtNombre" class="form-control">
									<label for="regular2">Nombre</label>
								</div>
                                <div class="form-group floating-label">
									<input type="text" id="txtMonto" class="form-control">
									<label for="regular2">Monto</label>
								</div>
                                <div class="form-group floating-label">
									<input type="text" id="txtDuracion" class="form-control">
									<label for="regular2">Duracion(Dias)</label>
								</div>
                        <div class="card-actionbar">
                                <div data-toggle="tabs" class="card-actionbar-row">
                                    <a class="btn btn-flat btn-primary ink-reaction" href="index.aspx">Volver</a>
                                    <button class="btn btn-flat btn-primary ink-reaction" onclick="ingresarTipoDePago()" type="button">Registrar</button>
                                </div>
                            </div>
							</form>
                        </div>

                    
                 
                
            </div>
        </div>
    </div>
    <form runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost:60166/ServicioUsuario.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-ui/jquery-ui.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/select2/select2.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-tagsinput/bootstrap-tagsinput.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/multi-select/jquery.multi-select.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/inputmask/jquery.inputmask.bundle.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/moment/moment.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-datepicker/bootstrap-datepicker.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-colorpicker/bootstrap-colorpicker.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/typeahead/typeahead.bundle.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/dropzone/dropzone.min.js")%>"></script>   
    <script src="<%= Page.ResolveUrl("~/js/local/validaciones/validacionRegistrarTipoPago.js")%>"></script>
    
</asp:Content>
