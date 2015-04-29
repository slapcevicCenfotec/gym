<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="modificar.aspx.vb" Inherits="UI_WEB.modificar5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/select2/select2.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/multi-select/multi-select.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-datepicker/datepicker3.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/jquery-ui/jquery-ui-theme.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-colorpicker/bootstrap-colorpicker.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-tagsinput/bootstrap-tagsinput.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/typeahead/typeahead.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/dropzone/dropzone-theme.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/local/usuarios.css")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Nuevo usuario</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Rellene el formulario con la información del usuario
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
                    <ul class="card-head nav nav-tabs text-center" data-toggle="tabs" id="tabsMenu">
                        <li class="active"><a href="#first"><i class="fa fa-lg fa-user"></i>
                            <br />
                            <h4>Perfil<br />
                                <small>Información Personal</small></h4>
                        </a></li>
                        <li><a href="#second"><i class="fa fa-lg fa-phone"></i>
                            <br />
                            <h4>Contactos<br />
                                <small>De emergencia</small></h4>
                        </a></li>
                        <li>
                            <a href="#third">
                                <i class="fa fa-lg fa-calendar"></i><br />
                                <h4>
                                    Horario<br />
                                    <small>De atencion</small>
                                </h4>
                            </a>
                        </li>
                    </ul>
                    <form runat="server" class="card-body tab-content style-default-bright form-validate">
                        <div class="tab-pane active" id="first">
                            <div class="form">
                                <div class="card-head style-primary">
                                    <header>Perfil</header>
                                </div>
                                <div class="card-body horizontal">
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtIdentificacion">
                                            <label>Identificación</label>
                                        </div>
                                        <div class="form-group">
                                            <select name="select1" class="form-control" id="txtTipoIdentificacion" required>
                                                <option value="">&nbsp;</option>
                                                <option value="1">Nacional</option>
                                                <option value="2">Extranjero</option>
                                            </select>
                                            <label for="select1">Tipo de identificación</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtPrimerNombre">
                                            <label>Primer nombre</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtSegundoNombre" required>
                                            <label>Segundo nombre</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtPrimerApellido" required>
                                            <label>Primer apellido</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtSegundoApellido">
                                            <label>Segundo apellido</label>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtAlias" required>
                                            <label>Alias</label>
                                        </div>
                                        <div class="form-group">
                                            <select class="form-control" id="txtGenero" required>
                                                <option value="">&nbsp;</option>
                                                <option value="1">Masculino</option>
                                                <option value="2">Femenino</option>
                                                <option value="3">Otro</option>
                                            </select>
                                            <label for="select1">Género</label>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group date" id="demo-date">
                                                <div class="input-group-content">
                                                    <input type="text" class="form-control" id="txtFechaNacimiento">
                                                    <label>Nacimiento</label>
                                                </div>
                                                <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                            </div>
                                        </div>
                                        <!--end .form-group -->
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtCorreoElectronico">
                                            <label>Correo electrónico</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtNumeroTelefono">
                                            <label>Teléfono</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtNumeroCelular">
                                            <label>Celular</label>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div style="width: 100%; height: 216px; overflow: hidden; position: relative" class="picture">
                                            <img src="" style="position: center; height: 216px" id="imgFoto">
                                            <input type="file" id="imagen">
                                        </div>
                                        <div class="form-group">
                                            <select class="form-control" id="txtRol">
                                                <option value="">&nbsp;</option>
                                            </select>
                                            <label>Rol</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="password" class="form-control" id="txtContrasena">
                                            <label>Contraseña</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="password" class="form-control" id="txtRepetirContrasena">
                                            <label>Repetir contraseña</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="second">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form">
                                        <div class="card-head style-primary">
                                            <header>Contacto #1</header>
                                        </div>
                                        <div class="card-body horizontal">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txtNombreContacto1">
                                                <label>Nombre</label>
                                            </div>
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txtParentescoContacto1">
                                                <label>Parentesco</label>
                                            </div>
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txtNumeroContacto1">
                                                <label>Número</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form">
                                        <div class="card-head style-primary">
                                            <header>Contacto #2</header>
                                        </div>
                                        <div class="card-body horizontal">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txtNombreContacto2">
                                                <label>Nombre</label>
                                            </div>
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txtParentescoContacto2">
                                                <label>Parentesco</label>
                                            </div>
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txtNumeroContacto2">
                                                <label>Número</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="third">
                            <div class="form">
                                <div class="card-head style-primary">
                                    <header>Horario</header>
                                </div>
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="card-body horizontal">
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtLunes1">
                                                        <label>Lunes</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtLunes2">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtMartes1">
                                                        <label>Martes</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtMartes2">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtMiercoles1">
                                                        <label>Mirércoles</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtMiercoles2">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="card-body horizontal">
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtJueves1">
                                                        <label>Jueves</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtJueves2">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtViernes1">
                                                        <label>Viernes</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtViernes2">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="card-body horizontal">
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtSabado1">
                                                        <label>Sábado</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtSabado2">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtDomingo1">
                                                        <label>Domingo</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control" id="txtDomingo2">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <a class="btn" onclick="ingresarUsuario()">Agregar</a>
                        <asp:ScriptManager runat="server">
                            <Services>
                                <asp:ServiceReference Path="http://localhost/egymServices/ServicioUsuario.svc" />
                            </Services>
                        </asp:ScriptManager>
                    </form>
                </div>
            </div>
        </div>
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
    <script src="<%= Page.ResolveUrl("~/js/local/modificarUsuario.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    
    <script>
        $('#demo-date').datepicker({ autoclose: true, todayHighlight: true });
        $('txtTipoIdentificacion').select2();
        $('txtGenero').select2();
        $('txtRol').select2();

        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#imgFoto').attr('src', e.target.result).fadeIn('slow');
                }
                reader.readAsDataURL(input.files[0]);
            }
        }


    </script>
</asp:Content>
