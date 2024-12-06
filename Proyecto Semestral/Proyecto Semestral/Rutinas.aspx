<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rutinas.aspx.cs" Inherits="Proyecto_Semestral.Rutinas" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <title>Gestión de Rutinas</title>
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

        .header .nav-links a {
            color: white;
            margin-left: 30px;
            text-decoration: none;
            font-size: 20px;
        }

        .header .nav-links a:hover {
            text-decoration: underline;
        }

        .content {
            padding: 40px;
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
    </style>
</head>
<body>
    <div class="header">
        <div class="title">Plan FitMe</div>
        <div class="nav-links">
            <a href="Home.aspx">Inicio</a>
            <a href="Ejercicios.aspx">Ejercicios</a>
            <a href="Progreso.aspx">Progreso</a>
            <a href="Reportes.aspx">Reportes</a>
        </div>
    </div>

    <form id="form1" runat="server">
        <div class="content">
            <h2>Gestión de Rutinas</h2>
            <p>En esta sección puedes crear, editar y gestionar tus rutinas de ejercicios.</p>

            <h3>Crear Rutina</h3>
            <asp:Label ID="lblMensaje" runat="server" CssClass="text-danger" />
            <div class="mb-3">
                <asp:TextBox ID="txtRutinaNombre" runat="server" CssClass="form-control" Placeholder="Nombre de la Rutina" />
            </div>
            <div class="mb-3">
                <asp:TextBox ID="txtFechaRutina" runat="server" TextMode="Date" CssClass="form-control" />
            </div>
            <asp:Button ID="btnAgregarRutina" runat="server" Text="Agregar Rutina" CssClass="btn" OnClick="btnAgregarRutina_Click" />

            <h3 class="mt-5">Lista de Rutinas</h3>
            <asp:GridView ID="gvRutinas" runat="server" AutoGenerateColumns="False" DataKeyNames="RutinaID"
                OnRowCommand="gvRutinas_RowCommand" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="RutinaID" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:yyyy-MM-dd}" />
                    <asp:ButtonField CommandName="VerEjercicios" ButtonType="Button" Text="Ver Ejercicios" />
                    <asp:ButtonField CommandName="EliminarRutina" ButtonType="Button" Text="Eliminar" />
                </Columns>
            </asp:GridView>

            <h3 class="mt-5">Asignar Ejercicios a Rutina</h3>
            <asp:Label ID="lblRutinaSeleccionada" runat="server" Text="Seleccione una rutina de la lista." CssClass="text-primary" />
            <div class="mb-3">
                <asp:DropDownList ID="ddlEjercicios" runat="server" CssClass="form-select" />
            </div>
            <div class="mb-3">
                <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control" Placeholder="Repeticiones" />
            </div>
            <div class="mb-3">
                <asp:TextBox ID="txtSeries" runat="server" CssClass="form-control" Placeholder="Series" />
            </div>
            <div class="mb-3">
                <asp:TextBox ID="txtPeso" runat="server" CssClass="form-control" Placeholder="Peso (kg)" />
            </div>
            <asp:Button ID="btnAsignarEjercicio" runat="server" Text="Asignar Ejercicio" CssClass="btn" OnClick="btnAsignarEjercicio_Click" />

            <h3 class="mt-5">Ejercicios Asignados a la Rutina</h3>
            <asp:GridView ID="gvEjerciciosRutina" runat="server" AutoGenerateColumns="False" DataKeyNames="RutinaEjercicioID"
                OnRowDeleting="gvEjerciciosRutina_RowDeleting" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Ejercicio" />
                    <asp:BoundField DataField="Repeticiones" HeaderText="Repeticiones" />
                    <asp:BoundField DataField="Series" HeaderText="Series" />
                    <asp:BoundField DataField="Peso" HeaderText="Peso (kg)" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>



