<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Graficos.aspx.vb" Inherits="UI_WEB.Graficos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/morris/morris.core.css")%>' />
    <%--<link href="../css/theme-default/libs/morris/morris.core.css" rel="stylesheet" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Gráficos de evolución del cliente</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Seleccione un rango de fechas
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
            <form class="form form-validate" role="form" id="fichasForm">
                <div class="card tabs-left style-default-light">
                    <ul class="card-head nav nav-tabs text-center" data-toggle="tabs">
                        <li class="col-sm-12">
                            <div class="form-group horizontal">
                                <select id="cmbDesde" name="cmbDesde" class="form-control" required>
                                    <option value="">&nbsp;</option>
                                </select>
                                <label for="cmbDesde">Desde</label>
                            </div>
                            <div class="form-group horizontal">
                                <select id="cmbHasta" name="cmbHasta" class="form-control text-sm" required>
                                    <option value="">&nbsp;</option>
                                </select>
                                <label for="cmbHasta">Hasta</label>
                            </div>
                        </li>
                        <li class="GenerarGraficoPeso"><a href="#first"><i class="fa fa-lg fa-user"></i>
                            <br />
                            <h6>Peso</h6>
                        </a></li>
                        <li class="GenerarGraficoIMC"><a href="#second"><i class="fa fa-lg fa-pencil-square"></i>
                            <br />
                            <h6>IMC</h6>
                        </a></li>
                        <li class="GenerarGraficoPorcGrasa"><a href="#third"><i class="fa fa-lg fa-pencil-square-o"></i>
                            <br />
                            <h6>Porcentaje de grasa</h6>
                        </a></li>
                        <li class="GenerarGraficoPorcMasa"><a href="#fourth"><i class="fa fa-lg fa-pencil-square-o"></i>
                            <br />
                            <h6>Porcentaje de masa</h6>
                        </a></li>
                        <li class="GenerarGraficoPesoGraso"><a href="#fifth"><i class="fa fa-lg fa-pencil-square-o"></i>
                            <br />
                            <h6>Peso graso</h6>
                        </a></li>
                    </ul>
                    <div class="card-body tab-content style-default-bright">
                        <div class="tab-pane active" id="first">
                            <div class="form">
                                <!-- BEGIN MORRIS - AREA CHART -->
						        <div class="row">
							        <div class="col-lg-12">
								        <h2 class="text-primary">Peso</h2>
							        </div><!--end .col -->
							        <div class="col-lg-12">
								        <h4 id="subtitulo"></h4>
							        </div><!--end .col -->
							        <div class="col-lg-offset-1 col-md-10">
								        <div class="card">
									        <div class="card-body">
										        <div id="graficoPeso" class="height-5" data-colors="#0aa89e"></div>
									        </div><!--end .card-body -->
								        </div><!--end .card -->
								        <em class="text-caption">Progreso del cliente</em>
							        </div><!--end .col -->
						        </div><!--end .row -->
						        <!-- END MORRIS - AREA CHART -->
                            </div>
                            <div class="card-actionbar GenerarGraficoIMC">
                                <div class="card-actionbar-row" data-toggle="tabs">
                                    <a href="#second" class="btn btn-flat btn-primary ink-reaction">Siguiente</a>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="second">
                            <div class="form">                                        
                                <!-- BEGIN MORRIS - AREA CHART -->
						        <div class="row">
							        <div class="col-lg-12">
								        <h2 class="text-primary">Indice de masa corporal</h2>
							        </div><!--end .col -->
							        <div class="col-lg-12">
								        <h4 id="subtitulo"></h4>
							        </div><!--end .col -->
							        <div class="col-lg-offset-1 col-md-10">
								        <div class="card">
									        <div class="card-body">
										        <div id="graficoImc" class="height-5" data-colors="#0aa89e"></div>
									        </div><!--end .card-body -->
								        </div><!--end .card -->
								        <em class="text-caption">Progreso del cliente</em>
							        </div><!--end .col -->
						        </div><!--end .row -->
						        <!-- END MORRIS - AREA CHART -->
                            </div>
                            <div class="card-actionbar GenerarGraficoPorcGrasa">
                                <div class="card-actionbar-row" data-toggle="tabs">
                                    <a href="#third" class="btn btn-flat btn-primary ink-reaction">Siguiente</a>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="third">
                            <div class="form">
                                <div class="form">                                                
                                    <!-- BEGIN MORRIS - AREA CHART -->
						            <div class="row">
							            <div class="col-lg-12">
								            <h2 class="text-primary">Porcentaje de grasa corporal</h2>
							            </div><!--end .col -->
							            <div class="col-lg-12">
								            <h4 id="subtitulo"></h4>
							            </div><!--end .col -->
							            <div class="col-lg-offset-1 col-md-10">
								            <div class="card">
									            <div class="card-body">
										            <div id="graficoPorcGrasa" class="height-5" data-colors="#0aa89e"></div>
									            </div><!--end .card-body -->
								            </div><!--end .card -->
								            <em class="text-caption">Progreso del cliente</em>
							            </div><!--end .col -->
						            </div><!--end .row -->
						            <!-- END MORRIS - AREA CHART -->
                                </div>
                                <div class="card-actionbar GenerarGraficoPorcMasa">
                                    <div class="card-actionbar-row" data-toggle="tabs">
                                        <a href="#fourth" class="btn btn-flat btn-primary ink-reaction">Siguiente</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="fourth">
                            <div class="form">
                                <div class="form">                                                
                                    <!-- BEGIN MORRIS - AREA CHART -->
						            <div class="row">
							            <div class="col-lg-12">
								            <h2 class="text-primary">Porcentaje de masa corporal</h2>
							            </div><!--end .col -->
							            <div class="col-lg-12">
								            <h4 id="subtitulo"></h4>
							            </div><!--end .col -->
							            <div class="col-lg-offset-1 col-md-10">
								            <div class="card">
									            <div class="card-body">
										            <div id="graficoPorcMasa" class="height-5" data-colors="#0aa89e"></div>
									            </div><!--end .card-body -->
								            </div><!--end .card -->
								            <em class="text-caption">Progreso del cliente</em>
							            </div><!--end .col -->
						            </div><!--end .row -->
						            <!-- END MORRIS - AREA CHART -->
                                </div>
                                <div class="card-actionbar GenerarGraficoPesoGraso">
                                    <div class="card-actionbar-row" data-toggle="tabs">
                                        <a href="#fifth" class="btn btn-flat btn-primary ink-reaction">Siguiente</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="fifth">
                            <div class="form">
                                <div class="form">                                                
                                    <!-- BEGIN MORRIS - AREA CHART -->
						            <div class="row">
							            <div class="col-lg-12">
								            <h2 class="text-primary">Peso graso</h2>
							            </div><!--end .col -->
							            <div class="col-lg-12">
								            <h4 id="subtitulo"></h4>
							            </div><!--end .col -->
							            <div class="col-lg-offset-1 col-md-10">
								            <div class="card">
									            <div class="card-body">
										            <div id="graficoPesoGraso" class="height-5" data-colors="#0aa89e"></div>
									            </div><!--end .card-body -->
								            </div><!--end .card -->
								            <em class="text-caption">Progreso del cliente</em>
							            </div><!--end .col -->
						            </div><!--end .row -->
						            <!-- END MORRIS - AREA CHART -->
                                </div>
                                <div class="card-actionbar GenerarGraficoPeso">
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
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioFichasDeMedicion.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/libs/morris.js/morris.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/libs/morris.js/morris.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/raphael/raphael-min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/Graficos.js")%>"></script>
</asp:Content>
