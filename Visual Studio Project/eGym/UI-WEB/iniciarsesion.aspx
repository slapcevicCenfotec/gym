nes (109 sloc)  5.934 kb
<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="iniciarsesion.aspx.vb" Inherits="UI_WEB.iniciarsesion" %>

<!DOCTYPE html>
<html lang="es">

<head runat="server">
    <title>eGym - Iniciar Sesión</title>

    <!-- BEGIN META -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Short explanation about this website">
    <!-- END META -->

    <!-- BEGIN STYLESHEETS -->
    <link href='http://fonts.googleapis.com/css?family=Roboto:300italic,400italic,300,400,500,700,900' rel='stylesheet' type='text/css' />
    <link type="text/css" rel="stylesheet" href="css/theme-default/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="css/theme-default/materialadmin.css"/>
    <link type="text/css" rel="stylesheet" href="css/theme-default/font-awesome.min.css"/>
    <!--Font Awesome Icon Font-->
    <link type="text/css" rel="stylesheet" href="css/theme-default/material-design-iconic-font.min.css"/>
    <!-- END STYLESHEETS -->

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
		<script type="text/javascript" src="../../assets/js/libs/utils/html5shiv.js?1403934957"></script>
		<script type="text/javascript" src="../../assets/js/libs/utils/respond.min.js?1403934956"></script>
		<![endif]-->

</head>

<body class="menubar-hoverable header-fixed ">

    <!-- BEGIN LOGIN SECTION -->
    <section class="section-account">
        <div class="img-backdrop" style="background-image: url('img/img16.jpg')"></div>
        <div class="spacer"></div>
        <div class="card contain-sm style-transparent">
            <div class="card-body">
                <div class="row">
                    <div class="col-sm-6">
                        <br />
                        <span class="text-lg text-bold text-primary">EGYM - NOMBRE GIMNASIO</span>
                        <br />
                        <br />
                        <form id="formLogin" class="form floating-label form-validate">
                            <div class="form-group">
                                <input type="email" class="form-control" id="txtCorreo" required>
                                <label>Correo electrónico</label>
                            </div>
                            <div class="form-group">
                                <input type="password" class="form-control" id="txtContrasena" required>
                                <label>Contraseña</label>
                                <p class="help-block">
                                    <a href="#">Olvidó su contraseña?</a>
                                </p>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-xs-6 text-left">
                                </div>
                                <!--end .col -->
                                <div class="col-xs-6 text-right">
                                    <a class="btn btn-primary btn-raised" id="bntIniciarSesion">Iniciar Sesión</a>
                                </div>
                                <!--end .col -->
                            </div>
                            <!--end .row -->
                        </form>
                    </div>
                    <!--end .col -->
                    <div class="col-sm-5 col-sm-offset-1 text-center">
                        <br>
                        <br>
                        <h3 class="text-light">No tiene cuenta aún?
                        </h3>
                        <a class="btn btn-block btn-raised btn-primary" href="#">Inscríbase aquí</a>
                        <br>
                        <br>
                    </div>
                    <!--end .col -->
                </div>
                <!--end .row -->
            </div>
            <!--end .card-body -->
        </div>
        <!--end .card -->
        <form runat="server">
            <asp:ScriptManager runat="server">
                <Services>
                    <asp:ServiceReference Path="http://localhost/egymservices/ServicioSesion.svc" />
                </Services>
            </asp:ScriptManager>
        </form>
    </section>

    <!-- END LOGIN SECTION -->

    <!-- BEGIN JAVASCRIPT -->
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery/jquery-1.11.2.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery/jquery-migrate-1.2.1.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap/bootstrap.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/spin.js/spin.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/nanoscroller/jquery.nanoscroller.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/source/App.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/source/AppNavigation.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/source/AppOffcanvas.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/source/AppCard.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/source/AppForm.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/source/AppNavSearch.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/source/AppVendor.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/demo/Demo.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/core/demo/DemoLayouts.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/inicioSesion.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <!-- END JAVASCRIPT -->
</body>

</html>
