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
                    <ul class="card-head nav nav-tabs text-center" data-toggle="tabs">
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
                        <li><a href="#third"><i class="fa fa-lg fa-calendar"></i>
                            <br />
                            <h4>Horario<br />
                                <small>De atencion</small></h4>
                        </a></li>
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
                                                <option value="1">Tipo 1</option>
                                                <option value="2">Tipo 2</option>
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
                                                <option value="2">Femenico</option>
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
                                            <img src="http://empregovirtual.blog.br/wp-content/uploads/2013/09/perfil-profissional.jpg" style="position: center; height: 216px" id="imgFoto"/>
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
                            <div class="card-actionbar">
                                <div class="card-actionbar-row" data-toggle="tabs">
                                    <a href="#second" class="btn btn-flat btn-primary">Siguiente</a>
                                    <button type="button" onclick="ingresarUsuario()" class="btn btn-flat btn-primary">Registrar</button>
                                    <button type="submit" class="btn btn-flat btn-primary">Validate</button>
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
                                                <input type="text" class="form-control">
                                                <label>Nombre</label>
                                            </div>
                                            <div class="form-group">
                                                <input type="text" class="form-control">
                                                <label>Parentesco</label>
                                            </div>
                                            <div class="form-group">
                                                <input type="text" class="form-control">
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
                                                <input type="text" class="form-control">
                                                <label>Nombre</label>
                                            </div>
                                            <div class="form-group">
                                                <input type="text" class="form-control">
                                                <label>Parentesco</label>
                                            </div>
                                            <div class="form-group">
                                                <input type="text" class="form-control">
                                                <label>Número</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="card-actionbar">
                                <div class="card-actionbar-row" data-toggle="tabs">
                                    <a href="#third" class="btn btn-flat btn-primary ink-reaction">Siguiente</a>
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
                                                        <input type="text" class="form-control">
                                                        <label>Lunes</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <label>Martes</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <label>Mirércoles</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
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
                                                        <input type="text" class="form-control">
                                                        <label>Jueves</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <label>Viernes</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
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
                                                        <input type="text" class="form-control">
                                                        <label>Sábado</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-daterange input-group">
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <label>Domingo</label>
                                                    </div>
                                                    <span class="input-group-addon">-</span>
                                                    <div class="input-group-content">
                                                        <input type="text" class="form-control">
                                                        <div class="form-control-line"></div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="card-actionbar">
                                <div class="card-actionbar-row" data-toggle="tabs">
                                    <a href="#third" class="btn btn-flat btn-primary ink-reaction">Siguiente</a>
                                </div>
                            </div>
                        </div>


                        <asp:ScriptManager runat="server">
                            <Services>
                                <asp:ServiceReference Path="http://localhost/ServicioUsuario.svc" />
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
