<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Modificar.aspx.vb" Inherits="UI_WEB.Modificar" %>
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
                <h1 class="text-primary">Modificar fichas de medición</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Llene el formulario con la información del usuario
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
            <form class="form form-validate" role="form" id="modificarFichasForm">
                <div class="card tabs-left style-default-light">
                    <ul class="card-head nav nav-tabs text-center" data-toggle="tabs">
                        <li class="active"><a href="#first"><i class="fa fa-lg fa-user"></i>
                            <br />
                            <h4>Medidas<br />
                                <small>generales</small></h4>
                        </a></li>
                        <li><a href="#second"><i class="fa fa-lg fa-pencil-square"></i>
                            <br />
                            <h4>Perímetros<br />
                                <small>corporales</small></h4>
                        </a></li>
                        <li><a href="#third"><i class="fa fa-lg fa-pencil-square-o"></i>
                            <br />
                            <h4>Pliegues<br />
                                <small>corporales</small></h4>
                        </a></li>
                        <li>
                            <a><i class="fa fa-lg fa-check-circle"></i>
                                <br />
                                <button class="btn btn-default" type="button" id="btnGuardar">Guardar</button>
                                
						        <label id="idFichaModificar" style="display:none"></label>
						        <label id="clienteModificar" style="display:none"></label>
						        <label id="fechaCreacionModificar" style="display:none"></label>
						        <label id="habilitadoModificar" style="display:none"></label>
                            </a>
                        </li>
                    </ul>
                    <div class="card-body tab-content style-default-bright">
                        <div class="tab-pane active" id="first">
                            <div class="form">
                                <div class="card-head style-primary">
                                    <header>Medidas generales</header>
                                </div>
                                <div class="card-body floating-label">
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <div class="input-group">
	                                            <div class="input-group-content">
		                                            <input type="text" class="form-control soloNumeros" id="txtPeso" required/>
		                                            <label for="txtPeso">Peso</label>
	                                            </div>
	                                            <span class="input-group-addon">kg</span>
                                            </div>
                                        </div>
                                        <div class="form-group">
	                                        <div class="input-group-content">
                                                <input type="text" class="form-control soloNumeros" id="txtAltura" required/>
                                                <label for="txtAltura">Altura</label>
	                                        </div>
	                                        <span class="input-group-addon">cm</span>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group-btn">
                                                <button class="btn btn-default" type="button" id="btnCalcular">Calcular</button>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <div class="input-group">
	                                            <div class="input-group-content">
                                                    <input type="text" class="form-control readOnly" id="txtIMC" required/>
								                    <label for="txtIMC">IMC</label>
	                                            </div>
	                                            <span class="input-group-addon"></span>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group">
	                                            <div class="input-group-content">
                                                    <input type="text" class="form-control readOnly" id="txtClasificacionIMC" required/>
								                    <label for="txtClasificacionIMC">Clasificación IMC</label>
	                                            </div>
	                                            <span class="input-group-addon"></span>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group">
	                                            <div class="input-group-content">
                                                    <input type="text" class="form-control readOnly" id="txtPorcGrasa" required/>
								                    <label for="txtPorcGrasa">Porcentaje de grasa corporal</label>
	                                            </div>
	                                            <span class="input-group-addon">%</span>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group">
	                                            <div class="input-group-content">
                                                    <input type="text" class="form-control readOnly" id="txtPorcMasaMuscular" required/>
								                    <label for="txtPorcMasaMuscular">Porcentaje de masa muscular</label>
	                                            </div>
	                                            <span class="input-group-addon">%</span>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group">
	                                            <div class="input-group-content">
                                                    <input type="text" class="form-control readOnly" id="txtPesoGraso" required/>
								                    <label for="txtPesoGraso">Peso graso</label>
	                                            </div>
	                                            <span class="input-group-addon">kg</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="card-actionbar">
                                <div class="card-actionbar-row" data-toggle="tabs">
                                    <a href="#second" class="btn btn-flat btn-primary ink-reaction">Siguiente</a>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="second">
                            <div class="card-head style-primary">
                                <header>Perímetros corporales</header>
                            </div>
                            <div class="row">`
                                <div class="col-md-6">
                                    <div class="form">
                                        <div class="card-body floating-label">
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtCintura" required/>
                                                        <label for="txtCintura">Cintura</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtCadera" required/>
                                                        <label for="txtCadera">Cadera</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtAbdomen" required/>
                                                        <label for="txtAbdomen">Abdomen</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtPecho" required/>
                                                        <label for="txtPecho">Pecho</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtEspalda" required/>
                                                        <label for="txtEspalda">Espalda</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtMusloIzquierdo" required/>
                                                        <label for="txtMusloIzquierdo">Muslo izquierdo</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtMusloDerecho" required/>
                                                        <label for="txtMusloDerecho">Muslo derecho</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form">
                                        <div class="card-body floating-label">
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtBicepIzquierdo" required/>
								                        <label for="txtBicepIzquierdo">Bíceps izquierdo</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtBicepDerecho" required/>
								                        <label for="txtBicepDerecho">Bíceps derecho</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtBicepIzquierdoContr" required/>
								                        <label for="txtBicepIzquierdoContr">Bíceps izquierdo contraído</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtBicepDerechoContr" required/>
								                        <label for="txtBicepDerechoContr">Bíceps derecho contraído</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtPantorrillaIzquierda" required/>
								                        <label for="txtPantorrillaIzquierda">Pantorrilla izquierda</label>
	                                                </div>
	                                                <span class="input-group-addon">cm</span>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
	                                                <div class="input-group-content">
                                                        <input type="text" class="form-control soloNumeros" id="txtPantorrillaDerecha" required/>
								                        <label for="txtPantorrillaDerecha">Pantorrilla derecha</label>
	                                                </div>
	                                                <span class="input-group-addon">cm`</span>
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
                        <div class="tab-pane" id="third">
                            <div class="form">
                                <div class="card-head style-primary">
                                    <header>Pliegues corporales</header>
                                </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form">
                                                <div class="card-body floating-label">
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtAbdominalIzquierdo" required/>
                                                                <label for="txtAbdominalIzquierdo">Abdominal izquierdo</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtAbdominalDerecho" required/>
                                                                <label for="txtAbdominalDerecho">Abdominal derecho</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtPliegueMusloIzquierdo" required/>
                                                                <label for="txtPliegueMusloIzquierdo">Muslo izquierdo</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtPliegueMusloDerecho" required/>
                                                                <label for="txtPliegueMusloDerecho">Muslo derecho</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtPlieguePantorrillaIzquierda" required/>
                                                                <label for="txtPlieguePantorrillaIzquierda">Pantorrilla izquierda</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtPlieguePantorrillaDerecha" required/>
                                                                <label for="txtPlieguePantorrillaDerecha">Pantorrilla derecha</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form">
                                                <div class="card-body floating-label">
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtTricepsIzquierdo" required/>
                                                                <label for="txtTricepsIzquierdo">Tríceps izquierdo</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtTricepsDerecho" required/>
                                                                <label for="txtTricepsDerecho">Tríceps derecho</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtSubescapularIzquierdo" required/>
                                                                <label for="txtSubescapularIzquierdo">Subescapular izquierdo</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtSubescapularDerecho" required/>
                                                                <label for="txtSubescapularDerecho">Subescapular derecho</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtSupraespinalIzquierdo" required/>
                                                                <label for="txtSupraespinalIzquierdo">Supraespinal izquierdo</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
	                                                        <div class="input-group-content">
                                                                <input type="text" class="form-control soloNumeros" id="txtSupraespinalDerecho" required/>
                                                                <label for="txtSupraespinalDerecho">Supraespinal derecho</label>
	                                                        </div>
	                                                        <span class="input-group-addon">mm</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                <div class="card-actionbar">
                                    <div class="card-actionbar-row" data-toggle="tabs">
                                        <a href="#first" class="btn btn-flat btn-primary ink-reaction">Siguiente</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
			</form>
            </div>
        </div>
    </div>
    <form runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost/eGymServices/ServicioFichasDeMedicion.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-ui/jquery-ui.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/select2/select2.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-tagsinput/bootstrap-tagsinput.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/multi-select/jquery.multi-select.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/moment/moment.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-colorpicker/bootstrap-colorpicker.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/typeahead/typeahead.bundle.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/ModificarFichasDeMedicion.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    <script>
    </script>
</asp:Content>
