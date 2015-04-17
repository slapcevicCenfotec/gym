<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Modificar.aspx.vb" Inherits="UI_WEB.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
    <form id="form1">
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="~/ServiciosTiposDeMaquinas.svc" />
                <asp:ServiceReference Path="~/ServiciosMaquina.svc" />
            </Services>
        </asp:ScriptManager>
    <div>
        <h1>Modificar máquina</h1>
        <div class="form-group">
            <label for="">Tipo de máquina</label>
            <select id="cmbTiposDeMaquinas">
            </select>
        </div>
        <div class="form-group">
            <label for="">Número de activo</label>
            <input type="text" class="form-control" id="txtNumeroActivo" placeholder="Número de activo">
        </div>
            <div class="form-group">
            <label for="">Número de máquina</label>
        <input type="text" class="form-control" id="txtNumeroMaquina" placeholder="Número de máquina">
        </div>
        <button type="button" class="btn btn-default" id="btnModificarMaquina">Modificar máquina</button>    
    </div>
    </form>
</body>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
</asp:Content>
