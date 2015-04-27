<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="ListarMusculos.aspx.vb" Inherits="UI_WEB.ListarMusculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="style-default-bright">
        <div class="section-header">
            <h2 class="text-primary">Musculos</h2>
        </div>
        <div class="section-body">
            <div class="row">
                <div class="col-md-8">
                    <article class="margin-bottom-xxl">
                        <p class="lead">Todos los musculos del sistema</p>
                    </article>
                </div>
            </div>
            <div class="row">
                <button type="button" id="btnIrAgregarMusculo" class="btn btn-primary">Agregar</button>
                <button type="button" id="btnModificarMus" class="btn btn-primary">Modificar</button>
                <button type="button" id="btnEliminarMus" class="btn btn-danger">Eliminar</button>
                <div class="col-lg-12">
                    <div class="table-responsive">
                        <table id="tblMusculos" class="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <td>ID</td>
                                    <td>Nombre</td>
                                    <td>Ubicacion</td>
                                    <td>Origen</td>
                                    <td>Inserccion</td>
                                    <td>Inervacion</td>
                                    <td>Irrigacion</td>
                                </tr>
                            </thead>
                            <tbody></tbody>
                        </table>
                    </div>
                    <!--end .table-responsive -->
                </div>
                <!--end .col -->
            </div>
            <!--end .row -->
            <!-- END DATATABLE 1 -->
        </div>
    </section>
    <div>
        <form action="/" method="post" runat="server">
            <asp:ScriptManager runat="server">
                <Services>
                    <asp:ServiceReference Path=" http://localhost:85/eGym/ServicioProyecto.svc" />
                </Services>
            </asp:ScriptManager>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/musculos.js")%>"></script>
    <script>
        $(document).ready(function () {
            buscarMusculos();
        });
    </script>
</asp:Content>
