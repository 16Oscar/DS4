<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Progreso.aspx.cs" Inherits="Proyecto_Semestral.Progreso" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <title>Seguimiento de Progreso</title>
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

        .dropdown {
            width: 100%;
            padding: 8px;
            margin-bottom: 10px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        .info {
            font-size: 18px;
            color: #007bff;
            margin-bottom: 20px;
            display: block;
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
            <a href="Reportes.aspx">Reportes</a>
        </div>
    </div>

    <form id="form1" runat="server">
        <div class="content">
            <h2>Seguimiento de Progreso</h2>
            <p>
                En esta sección puedes realizar un seguimiento detallado de tu progreso en las rutinas. Selecciona una rutina para visualizar los ejercicios asignados, registrar tu progreso y consultar los registros anteriores para evaluar tu evolución.
            </p>

            <h3>Seleccionar Rutina</h3>
            <div class="mb-3">
                <asp:DropDownList ID="ddlRutinas" runat="server" CssClass="form-select dropdown" AutoPostBack="true" OnSelectedIndexChanged="ddlRutinas_SelectedIndexChanged">
                    <asp:ListItem Text="Selecciona una rutina" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <h3 class="mt-4">Ejercicios de la Rutina</h3>
            <asp:GridView ID="gvRutinaEjercicios" runat="server" AutoGenerateColumns="False" DataKeyNames="RutinaEjercicioID" 
                OnSelectedIndexChanged="gvRutinaEjercicios_SelectedIndexChanged" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="EjercicioNombre" HeaderText="Ejercicio" SortExpression="EjercicioNombre" />
                    <asp:BoundField DataField="Repeticiones" HeaderText="Repeticiones" SortExpression="Repeticiones" />
                    <asp:BoundField DataField="Series" HeaderText="Series" SortExpression="Series" />
                    <asp:BoundField DataField="Peso" HeaderText="Peso" SortExpression="Peso" />
                    <asp:ButtonField Text="Ver Progreso" CommandName="Select" />
                </Columns>
            </asp:GridView>

            <h3 class="mt-4">Registrar Progreso</h3>
            <div class="mb-3">
                <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control" Placeholder="Repeticiones" />
            </div>
            <div class="mb-3">
                <asp:TextBox ID="txtSeries" runat="server" CssClass="form-control" Placeholder="Series" />
            </div>
            <div class="mb-3">
                <asp:TextBox ID="txtPeso" runat="server" CssClass="form-control" Placeholder="Peso" />
            </div>
            <div class="mb-3">
                <asp:TextBox ID="txtComentarios" runat="server" CssClass="form-control" TextMode="MultiLine" Placeholder="Comentarios" />
            </div>
            <asp:Button ID="Button1" runat="server" Text="Registrar Progreso" CssClass="btn" OnClick="btnRegistrarProgreso_Click" />

            <h3 class="mt-4">Historial de Progreso</h3>
            <asp:GridView ID="gvProgreso" runat="server" AutoGenerateColumns="False" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                    <asp:BoundField DataField="RepeticionesCompletadas" HeaderText="Repeticiones Completadas" SortExpression="RepeticionesCompletadas" />
                    <asp:BoundField DataField="SeriesCompletadas" HeaderText="Series Completadas" SortExpression="SeriesCompletadas" />
                    <asp:BoundField DataField="Comentarios" HeaderText="Comentarios" SortExpression="Comentarios" />
                </Columns>
            </asp:GridView>
        </div>
    </form>

    <!-- Scripts -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>


