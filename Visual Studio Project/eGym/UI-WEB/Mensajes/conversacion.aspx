<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="conversacion.aspx.vb" Inherits="UI_WEB.conversacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-1/libs/toastr/toastr.css")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Conversación</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <% If (Session("_MESSAGETYPE") = "user") Then%>
                    <p class="lead">
                        Esta es la conversación entre usted y el gimnasio
                    </p>
                    <% Else%>
                        
                    <p class="lead">
                        Esta es la conversación entre usted y [Cliente #]
                    </p>
                    <% End If%>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="row style-default">
            <div class="row">
                <ul class="timeline collapse-md" id="conver">
                    <li>
                        <div class="timeline-circ"></div>
                        <div class="timeline-entry">
                            <div class="card style-default-light">
                                <div class="card-body small-padding">
                                    <p>
                                        <img class="img-circle img-responsive pull-left width-1" src="http://misdeberes.es/img/avatars/65-ON.png" alt="">
                                        <span class="text-medium"><a class="text-primary">Yo</a> ahora mismo</span><br>
                                    </p>
                                    <div class="floating-label">
                                        <div class="form-group">
                                            <textarea id="txtmensaje" class="form-control" rows="2" placeholder=""></textarea>
                                            <label>Mensaje</label>
                                        </div>
                                        <div class="card-actionbar-row">
                                            <a id="btnEnviar" class="btn btn-flat btn-primary">Responder</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!--end .card -->
                        </div>
                        <!--end .timeline-entry -->
                    </li>
                </ul>
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
    <script src="<%= Page.ResolveUrl("~/js/localScripts/mensajes.js")%>"></script>
    <script>
        $(document).ready(function () {
            if ('<%=Session("_MESSAGETYPE")%>' == 'user') {
                conversacion('<%=Session("_USERID")%>');
                // Cargos los mensajes con el id de sesion
            } else {
                // Cargo los mensajes con el id del url
            }
        });

        $('#btnEnviar').click(function () {
            // VALIDACION

            // INSTANCIAR SERVICIO

            var servicio = new ServicioEnClases.ServicioMensaje();

            // INSERTAR USUARIO

            var remitente = '<%= Session("_USERID") %>';
            var mensaje = $('#txtMensaje').val();

            // HACER EL JSON

            var datos = JSON.stringify({
                pRemitenteId: remitente,
                pMensaje: mensaje
            });

            var respuesta = servicio.insertarMensaje(datos, onSuccessAgregarMensaje, errorMessageAgregarMensaje);

        })

        function onSuccessAgregarMensaje(result) {
            window.location = 'index.aspx';
        }

        function errorMessageAgregarMensaje(result) {
            toastr.error('Error al enviar mensaje');
        }
       
    </script>
</asp:Content>
