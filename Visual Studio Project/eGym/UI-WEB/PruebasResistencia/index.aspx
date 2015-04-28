<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index12" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/theme-1/libs/toastr/toastr.css" rel="stylesheet" />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%>' />
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
                        <div class="col-md-4">
                        <a class="btn btn-raised btn-primary ink-reaction pull-right"  id="btnPruebaResistencia">Prueba de resistencia</a>
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
    <form id="Form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioUsuario.svc" />
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioPruebasResistencia.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

    <script src="../js/libs/toastr/toastr.js"></script>

    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/usuarios.js")%>"></script>
    <script>
        $(document).ready(function () {

            if (window.location.href.indexOf("agregado") > -1) {
                toastr.success('El ejercicio ha sido agregado');
            }
            if (window.location.href.indexOf("modificado") > -1) {
                toastr.success('El ejercicio ha sido modificado');
            }


            search();
        });


        $('#btnPruebaResistencia').click(function () {
            var rows = $('tr.selected');
            var table = $('#tblUsuarios').DataTable();
            var rowData = table.rows(rows).data();
            var id = rowData[0][0];
            var cells = table.cells().nodes();
            var datos = JSON.stringify({ pId: id });
            var servicePruebas = new ServicioEnClases.ServicioPruebasResistencia();
            servicePruebas.comprobarPruebaResistencia(datos,onSuccessComprobarPruebas, null, null);
            //serviceRol.EliminarRoles(datos, onSuccesEliminar, errorMessage, null, null);
        });

        function onSuccessComprobarPruebas(result) {
            var objeto = $.parseJSON(result);

            var rows = $('tr.selected');
            var table = $('#tblUsuarios').DataTable();
            var rowData = table.rows(rows).data();
            var id = rowData[0][0];


            if (objeto == true) {
                alert("Prueba Realizada");
                window.location = "PruebaResistencia.aspx?id=" + id;

            } else {
                alert("Prueba No relizada");
                if (confirm('Este Cliente no ha realizado la prueba de resistencia. Desea aplicar la prueba?')) {
                    window.location = "PruebaResistencia.aspx";
                } else {
                    // Do nothing!
                }

            }
        }


    </script>
</asp:Content>
