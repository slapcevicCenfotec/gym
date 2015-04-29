<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="registrar.aspx.vb" Inherits="UI_WEB.registrarPago" %>

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



    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%>' />

        <link href="../css/theme-1/libs/toastr/toastr.css" rel="stylesheet" />



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
                            <h4>Cliente<br />
                                <small></small></h4>
                        </a></li>
                         <li><a href="#second"><i class="fa fa-lg fa-phone"></i>
                            <br />
                            <h4>Informacion<br />
                                <small>del pago</small></h4>
                        </a></li>
                        
                    </ul>
                    <form runat="server" class="card-body tab-content style-default-bright form-validate">
                        
                        <div class="tab-pane  active" id="first">
                            <div class="row">
                                <div class="col-md-12">
                                  <table id="tblUsuarios" class="table table-striped table-hover">
                                    <thead>
                                        <tr>
                                            <th style="display:none">Id</th>
                                            <th>Identificacion</th>
                                            <th>Nombre</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>
                                </div>
                                
                            </div>
                        </div>
                        <div class="tab-pane" id="second">
                            <div class="form">
                                <div class="card-head style-primary">
                                    <header>Perfil</header>
                                </div>
                                <div class="card-body floating-label">
                                    <div class="col-md-4">
                                      
                                    </div>
                                    <div class="col-md-4">
                                        
                                        <div class="form-group">
                                            <select class="form-control" id="txtTipo" required>
                                                <option value="0" selected="selected"></option>
                                            </select>
                                            <label for="select1">Tipo</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtMonto" required>
                                            <label>Monto</label>
                                        </div>
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txtFactura" required>
                                            <label>Numero de factura</label>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group date" id="demo-date">
                                                <div class="input-group-content">
                                                    <input type="text" class="form-control" id="txtDesde">
                                                    <label>Desde</label>
                                                </div>
                                                <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                            </div>
                                        </div>


                                        <div class="form-group">
                                            <div class="input-group date" id="demo-date2">
                                                <div class="input-group-content">
                                                    <input type="text" class="form-control" id="txtHasta">
                                                    <label>Hasta</label>
                                                </div>
                                                <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                            </div>
                                        </div>
                                        <div class="card-actionbar">
                                            <div class="card-actionbar-row" data-toggle="tabs">
                                                <button id="btnRegistrarPago" type="button" onclick="" class="btn btn-flat btn-primary ink-reaction pull-right">Registrar</button>
                                                <button id="regresarButton" type="button" onclick="volverIndex()" class="btn btn-flat btn-primary ink-reaction pull-right">Volver</button>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        
                                    </div>
                                </div>
                            </div>

                        </div>

                        
                        <asp:ScriptManager runat="server">
                            <Services>
                                <asp:ServiceReference Path="http://localhost/egymServices/ServicioTipoPago.svc" />
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
    <script src="<%= Page.ResolveUrl("~/js/local/facturacion.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>

    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>

    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/validaciones/validacionRegistrarPago.js")%>"></script>


    <script>
        $('#demo-date').datepicker({ autoclose: true, todayHighlight: true });
        $('#demo-date2').datepicker({ autoclose: true, todayHighlight: true });
        getAllTipoDePagoSelect();
        getAllUsers();
       

            
        
       


    </script>
</asp:Content>
