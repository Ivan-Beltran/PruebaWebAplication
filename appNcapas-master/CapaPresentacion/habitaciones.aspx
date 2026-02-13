<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="habitaciones.aspx.cs" Inherits="CapaPresentacion.habitaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>aqui estan las habitacines</h1>
            <asp:Label ID="lblnumero" runat="server" Text="numero de habitaciones"></asp:Label>
            <asp:TextBox ID="txtnumero" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbldescripcion" runat="server" Text="descripcion"></asp:Label>
            <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblcant" runat="server" Text="cantidad de huespedes permitidos"></asp:Label>
            <asp:TextBox ID="txtcant" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnguardar" runat="server" Text="Button" OnClick="btnguardar_Click" />
            <br />
            <br />
        </div>
        
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" BackColor="#6699FF" Width="464px"
            DatakeyNames="id_habitaciones" OnRowEditing="GridView1_RowEditing"
            OnRowUpdating="GridView1_RowUpdating"
            OnRowCancelingEdit="GridView1_RowCancelingEdit"
            OnRowDeleting="GridView1_RowDeleting"
            >
            <Columns>
                <asp:BoundField DataField="id_habitaciones" HeaderText="ID" />
                <asp:BoundField DataField="numero" HeaderText="#" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="cant_huespedes" HeaderText="Max-personas" />
                <asp:CommandField ShowEditButton="true" EditText="editar" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="eliminar" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
