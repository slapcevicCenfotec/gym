<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Agregar.aspx.vb" Inherits="UI_WEB.Agregar3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="style-default-bright">
        <div class="section-header">
            <h2 class="text-primary">Prueba de Resistencia</h2>
        </div>
        <div class="section-body">
            <div class="row">
                <div class="col-md-8">
                    <article class="margin-bottom-xxl">
                        <!-- BEGIN BASIC ELEMENTS -->
						<div class="row">
							<div class="col-lg-12">
								<h4>Generar Prueba de resistencia</h4>
							</div><!--end .col -->

							<div class="col-lg-offset-1 col-md-4 col-sm-6">
								<div class="card">
									<div class="card-body">
										<form id="form1" runat="server">
											<div class="form-group">
												<input type="text" class="form-control" id="nombre">
												<label for="nombre">Peso</label>
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="descripcion">
												<label for="descripcion">Descripcion</label>
											</div>
                                            
									<div class="form-group">
										<label for="select13" class="col-sm-2 control-label">Select</label>
										<div class="col-sm-10">
											<select id="select13" name="select13" class="form-control">

											</select>
										</div>
									</div
             <div class="row">
                <!--end .col -->
                <div class="col-lg-12">
                    <div class="table-responsive">
                        <table id="tblRoles" class="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <td>ID</td>
                                    <td>Nombre</td>
                                    <td>Descripcion</td>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                    <!--end .table-responsive -->
                </div>
                <!--end .col -->
            </div>
                                               <div class="form-group">
													<div class="input-group-btn">
														<button class="btn btn-default" type="button" onclick="ingresarRol()">Agregar Prueba</button>
													</div>
                                                	<div class="input-group-btn">
														<button class="btn btn-default" type="button" id="Cancelar" onclick="Cancelar()">Cancelar</button>
 
                                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                           <Services>
                                                                    <asp:ServiceReference Path="http://localhost/egymServices/ServicioPruebasResistencia.svc" />
                                                                </Services>
                                            </asp:ScriptManager>
													</div>
									        </div>
                                         </form>
									</div><!--end .card-body -->
								</div><!--end .card -->
							</div><!--end .col -->
						</div><!--end .row -->
						<!-- END BASIC ELEMENTS -->
                    </article>
                </div>
            </div>
            <!--end .row -->
            <!-- END DATATABLE 1 -->

        </div>
        <!--end .section-body -->
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/PruebasResistencia.js")%>"></script>
</asp:Content>