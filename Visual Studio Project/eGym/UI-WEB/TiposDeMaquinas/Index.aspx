<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="style-default-bright">
        <div class="section-header">
            <h2 class="text-primary">Tipos de máquinas</h2>
        </div>
        <div class="section-body">
            <div class="row">
                <div class="col-md-8">
                    <article class="margin-bottom-xxl">
                        <p class="lead">Tipos de máquina</p>
                    </article>
                        <button type="button" class="btn btn-default btn btn-primary ink-reaction">Agregar</button>
                        <button type="button" class="btn btn-default btn btn-primary ink-reaction">Modificar</button>
                        <button type="button" class="btn btn-default btn btn-primary ink-reaction">Eliminar</button>
                </div>
            </div>
            <div class="row">
                <!--end .col -->
                <div class="col-lg-12">
                    <div class="table-responsive">
                        <table id="tblTiposDeMaquinas" class="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <th>Nombre</th>
                                    <th>Descripción</th>
                                    <th>Cantidad de máquinas</th>
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
            <!--end .row -->
            <!-- END DATATABLE 1 -->

        </div>
        <!--end .section-body -->
    </section>
    <form runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost/eGymServices/ServiciosTiposDeMaquinas.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/ListarTiposDeMaquinas.js")%>"></script>
</asp:Content>