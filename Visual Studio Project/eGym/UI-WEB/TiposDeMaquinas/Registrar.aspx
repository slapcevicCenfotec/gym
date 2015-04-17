<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Registrar.aspx.vb" Inherits="UI_WEB.Registrar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
    <form id="form1">
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="~/ServiciosTiposDeMaquinas.svc" />
            </Services>
        </asp:ScriptManager>
    <div>
        <h1>Agregar tipo de máquina</h1>
        <div class="form-group">
            <label for="">Tipo de máquina</label>
            <input type="text" class="form-control" id="txtNombreTipoDeMaquina" placeholder="Tipo de máquina"/>
        </div>
        <div class="form-group">
            <label for="">Descripción</label>
            <textarea id="txtDescripcion" class="form-control"></textarea>
        </div>
        <div class="form-group">
            <label for="">Foto</label>
            <input type="file" id="fotoFile" accept='image/*'>
            <img id="foto" style="max-width:500px">
            <label id="fotoAsByte" style="display:none"></label>
        </div>
        <button type="button" class="btn btn-default" id="btnAgregarTipoDeMaquina">Agregar tipo de máquina</button>    
        <button type="button" class="btn btn-default" id="btnTest">test</button>    
    </div>
    </form>
</body>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
</asp:Content>
