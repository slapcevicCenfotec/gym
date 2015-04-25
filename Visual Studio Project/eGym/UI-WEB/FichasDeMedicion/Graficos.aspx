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

        <div class="col-md-2">
			<div class="card">
                <div class="card-body">
                    <div class="form-group floating-label">
                        <div class="form-group floating-label">
                            <label for="cmbDesde">Desde</label>
                            <select id="cmbDesde" name="cmbDesde" class="form-control" required>
                                <option value="">&nbsp;</option>
                            </select>
                        </div>                
                        <div class="form-group floating-label">
                            <label for="cmbHasta">Hasta</label>
                            <select id="cmbHasta" name="cmbHasta" class="form-control" required>
                                <option value="">&nbsp;</option>
                            </select>
                        </div>
                        <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnGenerar">Generar</button>
                    </div>
                </div> 
			</div><!--end .card -->
		</div><!--end .card -->

        <div class="col-md-10">
			<div class="card">
				<div class="card-body">
					<form class="form" role="form">
                        <!-- BEGIN MORRIS - AREA CHART -->
						<div class="row">
							<div class="col-lg-12">
								<h2 class="text-primary">Morris charts</h2>
							</div><!--end .col -->
							<div class="col-lg-12">
								<h4>Area chart</h4>
							</div><!--end .col -->
							<div class="col-lg-offset-1 col-md-10">
								<div class="card">
									<div class="card-body">
										<div id="grafico" class="height-5" data-colors="#0aa89e"></div>
									</div><!--end .card-body -->
								</div><!--end .card -->
								<em class="text-caption">Gráfico de evolución</em>
							</div><!--end .col -->
						</div><!--end .row -->
						<!-- END MORRIS - AREA CHART -->
					</form>
				</div><!--end .card-body -->
			</div><!--end .card -->
		</div><!--end .card -->
	</div><!--end .card -->
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
