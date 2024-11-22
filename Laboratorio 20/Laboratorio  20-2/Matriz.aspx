<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Matriz.aspx.cs" Inherits="Laboratorio__20_2.Matriz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Generador de Matriz NxN con Diagonal Inversa</h2>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el valor de N: "></asp:Label>
            <asp:TextBox ID="txtDimension" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Matriz" OnClick="btnGenerar_Click" />
            
            <hr />

            <asp:Table ID="TableMatriz" runat="server" BorderWidth="1" CellPadding="5" CellSpacing="0"></asp:Table>
        </div>
    </form>
</body>
</html>
