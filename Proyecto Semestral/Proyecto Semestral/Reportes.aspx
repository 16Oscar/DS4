<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="Proyecto_Semestral.Reportes" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <title>Reportes de Ejercicio</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" />
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f8f9fa;
            margin: 0;
            padding: 0;
        }

        .header {
            background-color: #007bff;
            color: white;
            padding: 20px 0;
            display: flex;
            align-items: center;
            justify-content: space-between;
        }

        .header .title {
            font-size: 32px;
            font-weight: bold;
            margin-left: 20px;
        }

        .header .nav-links {
            font-size: 20px;
            margin-right: 20px;
        }

        .header .nav-links a {
            color: white;
            margin-left: 30px;
            text-decoration: none;
        }

        .header .nav-links a:hover {
            text-decoration: underline;
        }

        .content {
            padding: 40px;
        }

        .content h2 {
            font-size: 36px;
            color: #007bff;
            margin-bottom: 20px;
        }

        .content p {
            font-size: 20px;
            margin-bottom: 40px;
        }

        .btn {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 15px;
            margin: 5px 0;
            border-radius: 5px;
        }

        .btn:hover {
            background-color: #0056b3;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            font-size: 18px;
            margin-bottom: 10px;
        }

        .grid-view {
            width: 100%;
            margin-top: 20px;
            border: 1px solid #ddd;
            border-radius: 5px;
            overflow: hidden;
        }

        .grid-view th {
            background-color: #007bff;
            color: white;
            text-align: left;
            padding: 10px;
        }

        .grid-view td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }

        .grid-view tr:last-child td {
            border-bottom: none;
        }

        @media (max-width: 768px) {
            .header .title {
                font-size: 24px;
            }

            .header .nav-links {
                font-size: 16px;
            }
        }
    </style>
</head>
<body>
    <div class="header">
        <div class="title">Plan FitMe</div>
        <div class="nav-links">
            <a href="Home.aspx">Inicio</a>
            <a href="Ejercicios.aspx">Ejercicios</a>
            <a href="Rutinas.aspx">Rutinas</a>
            <a href="Progreso.aspx">Progreso</a>
        </div>
    </div>

    <form id="form1" runat="server">
        <div class="content">
            <h2>Reportes de Ejercicio</h2>
            <p>
                En esta sección podrás generar reportes detallados de tu progreso en los ejercicios. Selecciona el rango de fechas, el ejercicio y la rutina para obtener el reporte específico de tu actividad física.
            </p>

            <h3>Generar Reporte</h3>
            <div class="form-group">
                <label for="fechaInicio">Fecha Inicio:</label>
                <asp:TextBox ID="fechaInicio1" runat="server" TextMode="Date" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="fechaFin">Fecha Fin:</label>
                <asp:TextBox ID="fechaFin1" runat="server" TextMode="Date" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="ejercicio">Ejercicio:</label>
                <asp:DropDownList ID="ddlEjercicio" runat="server" CssClass="form-select">
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="rutina">Rutina:</label>
                <asp:DropDownList ID="ddlRutina" runat="server" CssClass="form-select">
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Button ID="btnGenerarReporte" runat="server" Text="Generar Reporte" CssClass="btn" OnClick="btnGenerarReporte_Click" />
            </div>

            <h3>Progreso del Usuario</h3>
            <asp:GridView ID="gvProgreso" runat="server" AutoGenerateColumns="True" CssClass="grid-view"></asp:GridView>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>

