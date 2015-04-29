<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="assets/theme-default/libs/fullcalendar/fullcalendar.css">
    <link rel="stylesheet" href="css/modal.css">
    <link href="../css/calendar/fullcalendar.css" rel="stylesheet" />
    <%--<link type="text/css" rel="stylesheet" href="http://www.codecovers.eu/assets/css/modules/materialadmin/css/theme-default/libs/fullcalendar/fullcalendar.css?1422823368">--%>
    <style>
        #txtIdM {
            display: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="col-md-12">
        <div class="card tabs-left style-default-light">
            <div class="col-md-12 col-md-offset-1">
                <!-- BEGIN CALENDAR -->
							<div class="col-sm-9">
								<div class="card">
									<div class="card-head style-primary">
										<header>
											<span class="selected-day">&nbsp;</span> &nbsp;<small class="selected-date">&nbsp;</small>
										</header>
										<div class="tools">
											<div class="btn-group">
												<a id="calender-prev" class="btn btn-icon-toggle ink-reaction"><i class="fa fa-angle-left"></i></a>
												<a id="calender-next" class="btn btn-icon-toggle ink-reaction"><i class="fa fa-angle-right"></i></a>
                </div>
											<div class="btn-group pull-right">
											</div>
										</div>
										<ul class="nav nav-tabs tabs-text-contrast tabs-accent" data-toggle="tabs">
											<li data-mode="month" class="active"><a href="#">Month</a></li>
											<li data-mode="agendaWeek"><a href="#">Week</a></li>
											<li data-mode="agendaDay"><a href="#">Day</a></li>
										</ul>
									</div><!--end .card-head -->
									<div class="card-body no-padding">
										<div id="calendar"></div>
									</div><!--end .card-body -->
								</div><!--end .card -->
							</div><!--end .col -->
							<!-- END CALENDAR -->
                <%--<a class="btn btn-raised ink-reaction btn-default-bright" data-toggle="offcanvas" href="#offcanvas-demo-size3">Prueba</a>--%>
                <div class="offcanvas">
                    <div class="offcanvas-pane width-10" id="offcanvas-demo-size3" style="">
                        <div class="offcanvas-head">

                            <header>Nuevo evento</header>
                            <div class="offcanvas-tools">
                                <a data-dismiss="offcanvas" class="btn btn-icon-toggle btn-default-light pull-right">
                                    <i class="md md-close"></i>
                                </a>
                            </div>
                        </div>
                        <div class="nano has-scrollbar" style="height: 339.083px;">
                            <div class="nano-content" tabindex="0" style="right: -17px;">
                                <div class="offcanvas-body">
                                    <form role="form" class="form">
                                        <div class="form-group">
									        <select class="form-control" name="select1" id="select1">
									        </select>
									        <label for="select1">Usuario</label>
								        </div>
                                        <div class="form-group floating-label">
                                            <input type="text" id="txtTitulo" class="form-control">
                                            <label for="regular2">Titulo</label>
                                        </div>
                                        <div class="form-group floating-label">
                                            <input type="text" id="txtAsunto" class="form-control">
                                            <label for="regular2">Asunto</label>
                                        </div>
                                        <div class="form-group floating-label">
                                            <input type="text" id="txtHoraInicio" class="form-control time-mask">
                                            <label>Hora inicial</label>
                                            <p class="help-block">Formato: 24h</p>
                                        </div>
                                        <div class="form-group floating-label">
                                            <input type="text" id="txtHoraFinal" class="form-control">
                                            <label>Hora final</label>
                                            <p class="help-block">Formato: 24h</p>
                                        </div>
                                        <div class="card-actionbar">
                                            <div data-toggle="tabs" class="card-actionbar-row">
                                                <button class="btn btn-flat btn-primary ink-reaction" id="btnSubmit" type="button">Registrar</button>
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <div class="nano-pane" style="display: block;">
                                <div class="nano-slider" style="height: 249px; transform: translate(0px, 89.1509px);"></div>
                            </div>
                        </div>
                    </div>

                    <div class="offcanvas-pane width-10" id="offcanvas-demo-size4" style="">
                        <div class="offcanvas-head">
                            <header>Nuevo evento</header>
                            <div class="offcanvas-tools">
                                <a data-dismiss="offcanvas" class="btn btn-icon-toggle btn-default-light pull-right">
                                    <i class="md md-close"></i>
                                </a>
                            </div>
                        </div>

                        <div class="nano has-scrollbar" style="height: 339.083px;">
                            <div class="nano-content" tabindex="0" style="right: -17px;">
                                <div class="offcanvas-body">
                                    <form role="form" class="form">
                                        <div class="form-group">
									        <select class="form-control" name="select1" id="select1">
									        </select>
									        <label for="select1">Usuario</label>
								        </div>
                                        <div class="form-group floating-label">
                                            <input type="text" id="txtIdM" class="form-control">
                                            <input type="text" id="txtTituloM" class="form-control">
                                            <%--  <label for="regular2">Titulo</label>--%>
                                        </div>
                                        <div class="form-group floating-label">
                                            <input type="text" id="txtAsuntoM" class="form-control">
                                            <%--<label for="regular2">Asunto</label>--%>
                                        </div>
                                        <div class="form-group floating-label">
                                            <input type="text" id="txtHoraInicioM" class="form-control time-mask">
                                            <label>Hora inicial</label>
                                            <p class="help-block">Formato: 24h</p>
                                        </div>
                                        <div class="form-group floating-label">
                                            <input type="text" id="txtHoraFinalM" class="form-control time-mask">
                                            <label>Hora final</label>
                                            <p class="help-block">Formato: 24h</p>
                                            <%--<label for="regular2">Hora final</label>--%>
                                        </div>
                                        <div class="card-actionbar">
                                            <div data-toggle="tabs" class="card-actionbar-row">
                                                <button class="btn btn-flat btn-primary ink-reaction" id="btnSubmitM" type="button">Modificar</button>
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <div class="nano-pane" style="display: block;">
                                <div class="nano-slider" style="height: 249px; transform: translate(0px, 89.1509px);"></div>
                            </div>
                        </div>
                    </div>

                </div>


            </div>
        </div>
        <form runat="server">
            <asp:ScriptManager ID="ScriptManager2" runat="server">
                <Services>
                    <asp:ServiceReference Path="http://localhost/egymServices/ServicioEventoCalendario.svc" />
                </Services>

            </asp:ScriptManager>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

    <script src="assets/js/libs/moment/moment.min.js"></script>
    <script src="assets/js/libs/fullcalendar/fullcalendar.min.js"></script>

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
    <script src="<%= Page.ResolveUrl("~/js/local/calendar/fullcalendar.js")%>"></script>
    
    <script src="../js/local/calendar/jquery.simplemodal.js"></script>
    <script src="../js/local/agenda.js"></script>
   <script src="../js/local/calendar/calendar.js"></script>
</asp:Content>
