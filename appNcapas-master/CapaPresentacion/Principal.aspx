<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="CapaPresentacion.Personal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Bienvenido</h1> 
            <h3>Usuario:</h3><asp:Label ID="lblusuario" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="out" runat="server" Text="Cerrar Sesión" OnClick="out_Click" />
       
        <asp:Button ID="Button1" runat="server" Text="habitaciones" OnClick="Button1_Click" />
       
    </form>
</body>
</html>
