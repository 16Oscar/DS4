using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Proyecto_Semestral
{
    public partial class Reportes : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEjercicios();
                CargarRutinas();
            }
        }

        private void CargarEjercicios()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT EjercicioID, Nombre FROM Ejercicios", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ddlEjercicio.DataSource = dt;
                ddlEjercicio.DataTextField = "Nombre";
                ddlEjercicio.DataValueField = "EjercicioID";
                ddlEjercicio.DataBind();

                ddlEjercicio.Items.Insert(0, new ListItem("Selecciona un ejercicio", "0"));
            }
        }

        private void CargarRutinas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT RutinaID, Nombre FROM Rutinas", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ddlRutina.DataSource = dt;
                ddlRutina.DataTextField = "Nombre";
                ddlRutina.DataValueField = "RutinaID";
                ddlRutina.DataBind();

                ddlRutina.Items.Insert(0, new ListItem("Selecciona una rutina", "0"));
            }
        }

        protected void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? fechaInicio = string.IsNullOrEmpty(fechaInicio1.Text) ? (DateTime?)null : Convert.ToDateTime(fechaInicio1.Text);
                DateTime? fechaFin = string.IsNullOrEmpty(fechaFin1.Text) ? (DateTime?)null : Convert.ToDateTime(fechaFin1.Text);
                int ejercicioID = Convert.ToInt32(ddlEjercicio.SelectedValue);
                int rutinaID = Convert.ToInt32(ddlRutina.SelectedValue);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT pe.Fecha, re.Peso, re.Repeticiones, re.Series FROM Progreso pe " +
                                   "INNER JOIN RutinaEjercicios re ON pe.RutinaEjercicioID = re.RutinaEjercicioID " +
                                   "WHERE (@FechaInicio IS NULL OR pe.Fecha >= @FechaInicio) " +
                                   "AND (@FechaFin IS NULL OR pe.Fecha <= @FechaFin) " +
                                   "AND (@EjercicioID = 0 OR re.EjercicioID = @EjercicioID) " +
                                   "AND (@RutinaID = 0 OR re.RutinaID = @RutinaID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FechaInicio", (object)fechaInicio ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaFin", (object)fechaFin ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                    cmd.Parameters.AddWithValue("@RutinaID", rutinaID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        Response.Write("<script>alert('No se encontraron datos para el reporte.');</script>");
                    }
                    else
                    {
                        gvProgreso.DataSource = dt;
                        gvProgreso.DataBind();
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al generar el reporte: " + ex.Message + "');</script>");
            }
        }
    }
}

        