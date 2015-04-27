<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Index.aspx.vb" Inherits="UI_WEB.Index5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="style-default-bright">
        <div class="section-header">
        </div>
            <h2 class="text-primary">Máquinas</h2>
        <div class="section-body">
            <div class="row">
                <div class="col-md-8">
                    <article class="margin-bottom-xxl">
                    </article>
                        <p class="lead">Todas las máquinas registradas</p>
                    <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnAgregar">Agregar</button>
                    <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnModificar">Modificar</button>
                    <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnEliminar">Eliminar</button>
                    <button type="button" class="btn btn-default btn btn-primary ink-reaction" id="btnTiposDeMaquinas">Tipos de máquina</button>
                </div>
            </div>
            <div class="row">
                <!--end .col -->
                <div class="col-lg-12">
                    <div class="table-responsive">
                        <table id="tblMaquinas" class="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <th style="display:none">Id</th>
                                    <th>Número de activo</th>
                                    <th>Número de máquina</th>
                                    <th>Tipo de máquina</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <form runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServiciosMaquinas.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">



    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/ListarMaquinas.js")%>"></script>
    <script>
        $(document).ready(function () {
            search();
        });
    </script>
</asp:Content>
