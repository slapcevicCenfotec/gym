<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="ModificarMusculo.aspx.vb" Inherits="UI_WEB.ModificarMusculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section-body">
        <div class="section-header">
            <h2 class="text-primary">Modificar ejercicio</h2>
        </div>
    </div>
    <div class="section-body">
        <div class="row">
            <div class="col-md-8">
                <article class="margin-bottom-xxl">
                    <p class="lead"></p>
                </article>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <%--id="frmInsertarEjercicio" method="post" runat="server"--%>
                <div class="form-horizontal">
                    <fieldset>
                        <legend></legend>
                        <div class="form-group">
                            <label for="name" class="col-sm-2 control-label">Nombre:</label>
                            <div class="col-sm-7">
                                <input type="text" name="name" id="txtnombreMusculo" class="form-control" placeholder="Nombre?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="ubicacion" class="col-sm-2 control-label">Ubicacion:</label>
                            <div class="col-sm-7">
                                <input type="text" name="ubicacion" id="txtubicacionMusculo" class="form-control" placeholder="Ubicacion?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origen" class="col-sm-2 control-label">Origen:</label>
                            <div class="col-sm-7">
                                <input type="text" name="origen" id="txtorigenMusculo" class="form-control" placeholder="Origen?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="insercccion" class="col-sm-2 control-label">Insercccion:</label>
                            <div class="col-sm-7">
                                <input type="text" name="insercccion" id="txtinserccionMusculo" class="form-control" placeholder="Insercccion?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="inervacion" class="col-sm-2 control-label">Inervacion:</label>
                            <div class="col-sm-7">
                                <input type="text" name="inervacion" id="txtinervacionMusculo" class="form-control" placeholder="Inervacion?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="irrigacion" class="col-sm-2 control-label">Irrigacion:</label>
                            <div class="col-sm-7">
                                <input type="text" name="irrigacion" id="txtirrigacionMusculo" class="form-control" placeholder="Irrigacion?">
                            </div>
                            <div class="col-sm-3">
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <input type="submit" id="btnAgregarMusculo" class="btn btn-primary" value="Guardar" />
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7/jquery.js"></script>
    <script src="http://malsup.github.com/jquery.form.js"></script>
    <script src="../Scripts/jquery.validate.min.js"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/musculos.js")%>"></script>
</asp:Content>
