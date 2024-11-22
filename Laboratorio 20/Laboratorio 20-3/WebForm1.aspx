<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_20_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <h2>Gestión de Laptops</h2>

            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Enabled="false" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" Enabled="false" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Enabled="false" />
            &nbsp;&nbsp;&nbsp;

            <asp:Label ID="LabelBuscarId" runat="server" Text="Buscar por ID:" AssociatedControlID="txtBuscarId"></asp:Label>
            <asp:TextBox ID="txtBuscarId" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />

            <br />

            <asp:Label ID="LabelId" runat="server" Text="ID:" AssociatedControlID="txtId"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" Enabled="false"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="LabelNombre" runat="server" Text="Nombre:" AssociatedControlID="txtNombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />

            <br />

            <asp:Label ID="LabelPrecio" runat="server" Text="Precio:" AssociatedControlID="txtPrecio"></asp:Label>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="LabelStock" runat="server" Text="Stock:" AssociatedControlID="txtStock"></asp:Label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            <br /><br />

        </div>
    </form>
</body>
</html>
