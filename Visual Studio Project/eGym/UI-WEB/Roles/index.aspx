<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%> />
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%> />
    <link type="text/css" rel="stylesheet" href=<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%> />
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
                        <p class="lead">Todos los Roles del sistema</p>
                    </article>
                </div>
            </div>
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
                </div>
            </div>
            <p><button type="button" class="btn ink-reaction btn-flat btn-primary" id="btnAgregarRol">Agregar Rol</button>
            </p>
            <p><button type="button" class="btn ink-reaction btn-flat btn-primary" id="btnModificarRol" >Modificar Rol</button>
            </p>
            <p><button type="button" class="btn ink-reaction btn-flat btn-primary" id="btnEliminiarRol" >Eliminar Rol</button>
            </p>

        </div>
        <!--end .section-body -->


    </section>
        <form id="Form1" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                    <Services>
                        <asp:ServiceReference Path="http://localhost:60166/ServicioRol.svc" />
                    </Services>
                </asp:ScriptManager>
       </form>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server"> 

    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/Rol.js")%>"></script>
</asp:Content>
