<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="ServicioEnClases.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>eGym - Iniciar Sesión</title>
    
    <link href="Style/jquery.dataTables.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" /> 
    <script type="text/javascript" src="localScripts/inicioSesion.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="~/ServicioProyecto.svc" />
            </Services>
        </asp:ScriptManager>
    <div>
    
    </div>
    </form>
</body>
</html>
