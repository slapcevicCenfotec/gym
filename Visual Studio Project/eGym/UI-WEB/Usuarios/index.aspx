<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section-body contain-lg">
        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Usuarios</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Lista de usuarios del sistema
                    </p>
                </article>
            </div>
            <div class="col-md-4">
                <button type="button" class="btn btn-default btn btn-primary ink-reaction pull-right" id="btnEliminar">Eliminar</button>
                <button type="button" class="btn btn-default btn btn-primary ink-reaction pull-right" id="btnModificar">Modificar</button>
                    <button type="button" class="btn btn-default btn btn-primary ink-reaction pull-right" id="btnAgregar">Agregar</button>
                    
                    
               </div> 
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->
        <div class="row">
            <!-- BEGIN LAYOUT RIGHT SIDEBAR -->
            <div class="col-md-12">
                <div class="card tabs-left style-default-light">
                    <div class="table-responsive">
                        <table id="tblUsuarios" class="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <th style="display:none">Id</th>
                                    <th>Identificacion</th>
                                    <th>Nombre</th>
                                    <th>Alias</th>
                                    <th>Ingreso</th>
                                    <th style="display:none">Género</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table></div>
                </div>
            </div>
        </div>
    </div>
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
