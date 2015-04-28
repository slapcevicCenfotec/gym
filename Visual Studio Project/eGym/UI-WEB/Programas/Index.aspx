<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Index.aspx.vb" Inherits="UI_WEB.IndexProgramas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <section class="style-default-bright">
        <div class="section-header">
            <h2 class="text-primary">Usuarios</h2>
        </div>
        <div class="section-body">
            <div class="row">
                <div class="col-md-8">
                    <article class="margin-bottom-xxl">
                        <p class="lead">Todos los usuarios del sistema</p>
                    </article>
                </div>
            </div>
            <div class="row">
                <!--end .col -->
                <div class="col-lg-12">
                    <div class="table-responsive">
                        <table id="tblUsuarios" class="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <th>Identificacion</th>
                                    <th>Nombre</th>
                                    <th>Alias</th>
                                    <th>Ingreso</th>
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
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioUsuario.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/usuarios.js")%>"></script>
    <script>
        $(document).ready(function () {
            search();
        });
    </script>
</asp:Content>