<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PruebaWebAplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>esto es una prueba</h1>
        </div>

        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
        <asp:Button ID="btn444" runat="server" Text="Button" OnClick="btn444_Click" />
        <asp:Label ID="L1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
