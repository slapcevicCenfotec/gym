<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/shared/Site.Master" CodeBehind="Modificar.aspx.vb" Inherits="UI_WEB.Modificar4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="../css/theme-1/libs/toastr/toastr.css" rel="stylesheet" />
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
								<h4>Modificar Datos del Gimnasio</h4>
							</div><!--end .col -->

							<div class="col-lg-offset-1 col-md-4 col-sm-6">
								<div class="card">
									<div class="card-body">
										<form id="form1" runat="server">
                             <div class="form-group">
                            <div class="col-lg-12">
								<h4>Datos del Gimnasio</h4>
						</div>
                                </div><!--end .row -->
 
                                               <div class="form-group">
													<div class="input-group-btn">
														<button class="btn btn-default" type="button" onclick="ModificarGimnasio()">Guardar</button>
													</div>
                                                	<div class="input-group-btn">
														<button class="btn btn-default" type="button" id="Cancelar" onclick="Cancelar()">Cancelar</button>
 
                                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                           <Services>
                                                                <asp:ServiceReference Path="http://localhost/ServicioGimnasio.svc" />
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
    <script src="<%= Page.ResolveUrl("~/js/localScripts/Gimnasio.js")%>"></script>
    
        <script src="../js/libs/toastr/toastr.js"></script>
</asp:Content>