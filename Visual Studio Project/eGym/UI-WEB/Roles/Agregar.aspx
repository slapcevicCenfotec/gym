<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/shared/Site.Master" CodeBehind="Agregar.aspx.vb" Inherits="UI_WEB.Agregar2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="style-default-bright">
        <div class="section-header">
            <h2 class="text-primary">Roles</h2>
        </div>
        <div class="section-body">
            <div class="row">
                <div class="col-md-8">
                    <article class="margin-bottom-xxl">
                        <!-- BEGIN BASIC ELEMENTS -->
						<div class="row">
							<div class="col-lg-12">
								<h4>Agregar Rol</h4>
							</div><!--end .col -->

							<div class="col-lg-offset-1 col-md-4 col-sm-6">
								<div class="card">
									<div class="card-body">
										<form id="form1" runat="server">
											<div class="form-group">
												<input type="text" class="form-control" id="nombre">
												<label for="nombre">Nombre</label>
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="descripcion">
												<label for="descripcion">Descripcion</label>
											</div>
                             <div class="form-group">
                            <div class="col-lg-12">
								<h4>Permisos</h4>
							<div class="col-lg-offset-1 col-md-8">
								<div class="card">
									<div class="card-body no-padding">
										<ul class="list" id="listaPermisos" data-sortable="true">
										</ul>
									</div><!--end .card-body -->
								</div><!--end .card -->
							</div><!--end .col -->
						</div>
                                </div><!--end .row -->
 
                                               <div class="form-group">
													<div class="input-group-btn">
														<button class="btn btn-default" type="button" onclick="ingresarRol()">Guardar</button>
													</div>
                                                	<div class="input-group-btn">
														<button class="btn btn-default" type="button" id="Cancelar" onclick="Cancelar()">Cancelar</button>
 
                                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                           <Services>
                                                                <asp:ServiceReference Path="http://localhost/ServicioPermisos.svc" />
                                                                <asp:ServiceReference Path="http://localhost/ServicioRol.svc" />
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
    <script src="<%= Page.ResolveUrl("~/js/localScripts/Permiso.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/Rol.js")%>"></script>
</asp:Content>