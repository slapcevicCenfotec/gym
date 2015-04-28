﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/jquery.dataTables.css?1423553989")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.colVis.css?1423553990")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/DataTables/extensions/dataTables.tableTools.css?1423553990")%>' />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section-body contain-lg">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Mensajes</h1>
            </div>
            <div class="col-lg-10">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Estos son los mensajes que han enviado los clientes a la administración, escoja uno para visualizar.
                    </p>
                </article>
            </div>
            <div class="col-lg-2">
                <div class="btn-group pull-right">
                    <a class="btn btn-raised btn-primary" id="btnLeer">Leer</a>
                    <a class="btn btn-raised btn-primary" href="agregar.aspx">Nuevo</a>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="card tabs-left style-default-light">
                    <div class="card-body tab-content style-default-bright form-validate">
                        <div class="col-lg-12">
                            <div class="table-responsive">
                                <table id="tblMensajes" class="table table-striped table-hover">
                                    <thead>
                                        <tr>
                                            <th style="display:none">Id</th>
                                            <th>Remitente</th>
                                            <th>Mensaje</th>
                                            <th>Fecha</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioMensaje.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/jquery.dataTables.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/ColVis/js/dataTables.colVis.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/DataTables/extensions/TableTools/js/dataTables.tableTools.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/localScripts/mensajes.js")%>"></script>
    <script>
        $(document).ready(function () {
            search();
        });
    </script>

</asp:Content>
