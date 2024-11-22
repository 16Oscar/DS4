<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Introduzca un texto"></asp:Label>
        <p>
            <asp:TextBox ID="txtMensaje" runat="server"></asp:TextBox>
            <asp:Button ID="txtSaludo" runat="server" OnClick="txtSaludo_Click" Text="Enviar Saludo!" />
        </p>
    </form>
</body>
</html>
