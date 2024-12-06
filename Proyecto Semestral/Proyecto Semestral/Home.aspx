<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Proyecto_Semestral.Home" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Plan FitMe - Home</title>
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
            align-items: center;
            justify-content: space-between;
            padding: 15px 20px;
        }

        .header .title {
            font-size: 32px;
            font-weight: bold;
            margin: 0;
        }

        .header .nav-links {
            display: flex;
            gap: 20px;
        }

        .header .nav-links a {
            font-size: 18px;
            color: white;
            text-decoration: none;
            transition: color 0.3s ease;
        }

        .header .nav-links a:hover {
            text-decoration: underline;
            color: #f8f9fa;
        }

        .content {
            padding: 40px 20px;
            text-align: center;
        }

        .content h2 {
            font-size: 36px;
            color: #007bff;
        }

        .content p {
            font-size: 20px;
            margin-top: 20px;
        }

        .features {
            margin-top: 40px;
        }

        .features h2 {
            font-size: 28px;
            color: #0056b3;
            margin-top: 30px;
        }

        .features p {
            font-size: 18px;
            margin-top: 10px;
            color: #333;
        }

        @media (max-width: 768px) {
            .header .title {
                font-size: 24px;
            }

            .header .nav-links {
                font-size: 14px;
                flex-direction: column;
                align-items: center;
                gap: 10px;
            }
        }
    </style>
</head>
<body>

    <div class="header">
        <div class="title">Plan FitMe</div>
        <div class="nav-links">
            <a href="Ejercicios.aspx">Ejercicios</a>
            <a href="Rutinas.aspx">Rutinas</a>
            <a href="Progreso.aspx">Progreso</a>
            <a href="Reportes.aspx">Reportes</a>
        </div>
    </div>

    <div class="content">
        <h2>Bienvenido a Plan FitMe</h2>
        <p>Tu lugar para llevar el control de tus rutinas y progreso de ejercicios. Elige una opción en el Header para comenzar.</p>

        <div class="features">
            <h2>Ejercicios</h2>
            <p>Registra y visualiza tus ejercicios diarios, establece objetivos y realiza un seguimiento de tu rendimiento físico.</p>

            <h2>Rutinas</h2>
            <p>Crea, personaliza y organiza tus rutinas de entrenamiento para mantener un plan consistente y efectivo.</p>

            <h2>Progreso</h2>
            <p>Visualiza tu progreso a lo largo del tiempo con gráficos interactivos y mantente motivado para alcanzar tus metas.</p>

            <h2>Reportes</h2>
                <p>Genera informes detallados sobre tu progreso, incluyendo estadísticas y análisis de tus logros.</p>
        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>

