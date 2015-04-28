<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="agregar.aspx.vb" Inherits="UI_WEB.agregar13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-1/libs/toastr/toastr.css")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Nuevo mensaje</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Rellene el formulario con la información del mensaje
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="row style-default-bright">
            <div class="form">
                <div class="card-head style-primary">
                    <header>Mensaje</header>
                </div>
                <div class="card-body floating-label">
                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group">
                                <input type="text" class="form-control" id="txtDestinatario">
                                <label>Destinatario</label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-8">
                            <div class="form-group">
                                <textarea id="txtMensaje" class="form-control" rows="3"></textarea>
                                <label>Mensaje</label>
                            </div>
                        </div>
                    </div>
                    <div class="card-actionbar">
                        <div class="card-actionbar-row">
                            <a id="btnEnviar" class="btn btn-flat btn-primary">Enviar</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioMensaje.svc" />
            </Services>
        </asp:ScriptManager>
    </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/libs/toastr/toastr.js")%>"></script>
    <script>
        $(document).ready(function () {
            $('#btnEnviar').click(function () {
                // VALIDACION

                // INSTANCIAR SERVICIO

                var servicio = new ServicioEnClases.ServicioMensaje();

                // INSERTAR USUARIO

                var remitente = '<%= Session("_USERID") %>';
                var destinatario = $('#txtDestinatario').val();
                var mensaje = $('#txtMensaje').val();

                // HACER EL JSON

                var datos = JSON.stringify({
                    pRemitenteId: remitente,
                    pDestinatarioId: destinatario,
                    pMensaje: mensaje
                });

                var respuesta = servicio.insertarMensaje(datos, onSuccessAgregarMensaje, errorMessageAgregarMensaje);

            })

            function onSuccessAgregarMensaje() {
                window.location = 'index.aspx';
            }

            function errorMessageAgregarMensaje() {
                toastr.error('Error al insertar'); 
            }
        });
    </script>
</asp:Content>
