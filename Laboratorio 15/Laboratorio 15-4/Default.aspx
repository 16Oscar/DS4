<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_15_4._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Suma de dos números</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculadora de Suma</h2>
            <asp:Label ID="lblNum1" runat="server" Text="Número 1:" />
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblNum2" runat="server" Text="Número 2:" />
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
            <br /><br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado: " />
        </div>
    </form>
</body>
</html>

