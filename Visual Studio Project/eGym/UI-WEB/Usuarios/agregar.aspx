<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="agregar.aspx.vb" Inherits="UI_WEB.agregar" %>

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
                                <div class="card-body floating-label">
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
                                            <img src="data:image/png;base64,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" style="position: center; height: 216px" id="imgFoto">
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
                                        <div class="card-body floating-label">
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
                                        <div class="card-body floating-label">
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
                                        <div class="card-body floating-label">
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
                                        <div class="card-body floating-label">
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
                                        <div class="card-body floating-label">
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
    <script src="<%= Page.ResolveUrl("~/js/local/usuarios.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    
    <script>
        $('#demo-date').datepicker({ autoclose: true, todayHighlight: true });
        $('txtTipoIdentificacion').select2();
        $('txtGenero').select2();
        $('txtRol').select2();
        $(document).ready(function () {
            obtenerRoles();
            $("#imagen").change(function () {
                readURL(this);
            });
        });

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
