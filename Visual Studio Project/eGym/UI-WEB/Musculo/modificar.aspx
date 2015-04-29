<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="modificar.aspx.vb" Inherits="UI_WEB.ModificarMusculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/theme-1/libs/toastr/toastr.css" rel="stylesheet" />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/select2/select2.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/multi-select/multi-select.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/jquery-ui/jquery-ui-theme.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-colorpicker/bootstrap-colorpicker.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-tagsinput/bootstrap-tagsinput.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/typeahead/typeahead.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/dropzone/dropzone-theme.css")%>' />
    <style>
        #txtIdMusculo {
            display: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">
        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Modificar músculo</h1>
            </div>
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Rellene el formulario con la información del músculo
                    </p>
                </article>
            </div>
        </div>

        <div class="row">
            <!-- BEGIN LAYOUT RIGHT SIDEBAR -->
            <div class="col-md-12">
                <div class="card tabs-left style-default-light">
                    <form runat="server" id="frmModificarMusculo" class="card-body tab-content style-default-bright form-validate">
                        <div class="form">
                            <div class="card-head style-primary">
                                <header>Músculo</header>
                            </div>
                            <div class="card-body floating-label">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <input type="text" name="name" id="txtIdMusculo">
                                        <input type="text" name="name" id="txtnombreMusculo" class="form-control" required>
                                        <label>Nombre</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="ubicacion" id="txtubicacionMusculo" class="form-control" required>
                                        <label>Ubicación</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="origen" id="txtorigenMusculo" class="form-control" required>
                                        <label>Origen</label>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <input type="text" name="insercccion" id="txtinserccionMusculo" class="form-control" required>
                                        <label>Insercción</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="inervacion" id="txtinervacionMusculo" class="form-control" required>
                                        <label>Inervación</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="irrigacion" id="txtirrigacionMusculo" class="form-control" required>
                                        <label>Inervación</label>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-sm-offset-2 col-sm-10">
                                            <input type="button" id="btnModificarMusculo" class="btn btn-flat btn-primary" value="Guardar" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <asp:ScriptManager runat="server">
                            <Services>
                                 <asp:ServiceReference Path="http://localhost/egymServices/ServicioProyecto.svc" />
                            </Services>
                        </asp:ScriptManager>
                    </form>
                </div>
            </div>
        </div>



        <%--<div class="section-body">
        <div class="section-header">
            <h2 class="text-primary">Modificar ejercicio</h2>
        </div>
    </div>
    <div class="section-body">
        <div class="row">
            <div class="col-md-8">
                <article class="margin-bottom-xxl">
                    <p class="lead"></p>
                </article>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">--%>
        <%--id="frmInsertarEjercicio" method="post" runat="server"--%>
        <%-- <div class="form-horizontal">
                    <fieldset>
                        <legend></legend>
                        <div class="form-group">
                            <label for="name" class="col-sm-2 control-label">Nombre:</label>
                            <div class="col-sm-7">
                                 <input type="text" name="name" id="txtIdMusculo">
                                <input type="text" name="name" id="txtnombreMusculo" class="form-control" placeholder="Nombre?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="ubicacion" class="col-sm-2 control-label">Ubicacion:</label>
                            <div class="col-sm-7">
                                <input type="text" name="ubicacion" id="txtubicacionMusculo" class="form-control" placeholder="Ubicacion?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origen" class="col-sm-2 control-label">Origen:</label>
                            <div class="col-sm-7">
                                <input type="text" name="origen" id="txtorigenMusculo" class="form-control" placeholder="Origen?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="insercccion" class="col-sm-2 control-label">Insercccion:</label>
                            <div class="col-sm-7">
                                <input type="text" name="insercccion" id="txtinserccionMusculo" class="form-control" placeholder="Insercccion?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="inervacion" class="col-sm-2 control-label">Inervacion:</label>
                            <div class="col-sm-7">
                                <input type="text" name="inervacion" id="txtinervacionMusculo" class="form-control" placeholder="Inervacion?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="irrigacion" class="col-sm-2 control-label">Irrigacion:</label>
                            <div class="col-sm-7">
                                <input type="text" name="irrigacion" id="txtirrigacionMusculo" class="form-control" placeholder="Irrigacion?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <input type="submit" id="btnModificarMusculo" class="btn btn-primary" value="Guardar" />
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
         <form action="/" method="post" runat="server">
            <asp:ScriptManager runat="server">
                <Services>
                    <asp:ServiceReference Path=" http://localhost:85/eGym/ServicioProyecto.svc" />
                </Services>
            </asp:ScriptManager>
        </form>
    </div>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7/jquery.js"></script>
    <script src="http://malsup.github.com/jquery.form.js"></script>
    <%--<script src="../Scripts/jquery.validate.min.js"></script>--%>
     <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/musculos.js")%>"></script>
    <script src="../js/libs/toastr/toastr.js"></script>
    <script>
        $(document).ready(function () {

            //alert($('form').serialize());
            //$(':text').val('foo');

            var idMusculo = getQueryVariable('id');

            //alert(idMusculo)

            var service5 = new ServicioEnClases.ServicioProyecto();
            var datos = JSON.stringify({ pid: idMusculo });

            service5.obtenerMusculoByID(datos, onSuccess, errorMessage, null, null);

        });

        function onSuccess(result) {
            //alert(result);
            var objeto = $.parseJSON(result);
            $('#txtIdMusculo').val(objeto.Id);
            $('#txtnombreMusculo').val(objeto.Nombre);
            $('#txtubicacionMusculo').val(objeto.Ubicacion);
            $('#txtorigenMusculo').val(objeto.Origen);
            $('#txtinserccionMusculo').val(objeto.Inserccion);
            $('#txtinervacionMusculo').val(objeto.Inervacion);
            $('#txtirrigacionMusculo').val(objeto.Irrigacion);

        }
        function errorMessage(resul) {
            alert(resul.get_message());
        }

        function getQueryVariable(variable) {
            var query = window.location.search.substring(1);
            var vars = query.split('&');
            for (var i = 0; i < vars.length; i++) {
                var pair = vars[i].split('=');
                if (pair[0] == variable) { return pair[1]; }
            }
            return (false);
        }
    </script>

</asp:Content>
