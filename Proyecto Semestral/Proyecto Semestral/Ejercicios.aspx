<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicios.aspx.cs" Inherits="Proyecto_Semestral.Ejercicios" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Gestión de Ejercicios</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" />

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
            display: flex;
            padding: 20px 0;
            align-items: center;
            justify-content: space-between;
        }

        .header .title {
            font-size: 32px;
            font-weight: bold;
            margin-left: 20px;
        }

        .header .nav-links {
            display: flex;
            font-size: 18px;
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
            text-align: center;
        }

        .content h1 {
            font-size: 36px;
            color: #007bff;
        }

        .content p {
            font-size: 20px;
            margin-top: 10px;
        }

        .form-section {
            margin-top: 40px;
        }

        .form-section label {
            font-size: 18px;
            font-weight: bold;
        }

        .form-section .form-control {
            margin-bottom: 15px;
            width: 50%;
            margin-left: auto;
            margin-right: auto;
        }

        .form-buttons {
            margin-top: 20px;
        }

        .form-buttons button {
            margin: 5px;
        }

        .grid-section {
            margin-top: 40px;
            text-align: center;
        }

        .grid-section .table {
            margin-top: 20px;
            width: 90%;
            margin-left: auto;
            margin-right: auto;
        }

        @media (max-width: 768px) {
            .header .title {
                font-size: 24px;
            }

            .header .nav-links {
                font-size: 14px;
                float: none;
                text-align: center;
                margin-top: 10px;
            }

            .header .nav-links a {
                margin-left: 15px;
                margin-right: 15px;
            }

            .form-section .form-control {
                width: 100%;
            }
        }
    </style>
</head>
<body>
    <div class="header">
        <div class="title">Plan FitMe</div>
        <div class="nav-links">
            <a href="Home.aspx">Inicio</a>
            <a href="Rutinas.aspx">Rutinas</a>
            <a href="Progreso.aspx">Progreso</a>
            <a href="Reportes.aspx">Reportes</a>
        </div>
    </div>

    <div class="content">
        <h1>Gestión de Ejercicios</h1>
        <p>Aquí puedes agregar, editar y administrar los ejercicios que forman parte de tu plan de entrenamiento. Usa las opciones de abajo para personalizar tu rutina.</p>
    </div>

    <form id="form1" runat="server">
        <div class="grid-section">
            <h2>Lista de Ejercicios</h2>
            <asp:GridView ID="gvEjercicios" runat="server" CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="EjercicioID"
                  OnRowEditing="gvEjercicios_RowEditing" OnRowUpdating="gvEjercicios_RowUpdating"
                  OnRowCancelingEdit="gvEjercicios_RowCancelingEdit" OnRowDeleting="gvEjercicios_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="EjercicioID" HeaderText="ID" ReadOnly="True" />
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <%# Eval("Nombre") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Categoría">
                        <ItemTemplate>
                            <%# Eval("Categoria") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCategoria" runat="server" Text='<%# Bind("Categoria") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Descripción">
                        <ItemTemplate>
                            <%# Eval("Descripcion") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDescripcion" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>

        <div class="form-section">
            <h2>Agregar/Editar Ejercicio</h2>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
            <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control" placeholder="Categoría"></asp:TextBox>
            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" placeholder="Descripción"></asp:TextBox>

            <div class="form-buttons">
                <asp:Button ID="btnAgregar" runat="server" CssClass="btn btn-primary" Text="Agregar" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnActualizar" runat="server" CssClass="btn btn-success" Text="Actualizar" OnClick="btnActualizar_Click" />
                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" OnClick="btnCancelar_Click" />
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>




