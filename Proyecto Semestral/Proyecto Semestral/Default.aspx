<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_Semestral.Default" %>

   <!DOCTYPE html>
<html>
<head runat="server">
    <title>Seguimiento de Ejercicio</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Bienvenido al Seguimiento de Ejercicio</h1>
        <asp:HyperLink ID="hlExercises" runat="server" NavigateUrl="Exercises.aspx">Gestión de Ejercicios</asp:HyperLink><br />
        <asp:HyperLink ID="hlRoutines" runat="server" NavigateUrl="Routines.aspx">Gestión de Rutinas</asp:HyperLink><br />
        <asp:HyperLink ID="hlProgress" runat="server" NavigateUrl="Progress.aspx">Seguimiento de Progreso</asp:HyperLink><br />
        <asp:HyperLink ID="hlReports" runat="server" NavigateUrl="Reports.aspx">Módulo de Reportes</asp:HyperLink>
    </form>
</body>
</html>



