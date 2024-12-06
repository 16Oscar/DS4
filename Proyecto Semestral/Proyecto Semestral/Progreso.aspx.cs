using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Semestral
{
    public partial class Progreso : System.Web.UI.Page
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRutinas();
            }
        }

        private void CargarRutinas()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT RutinaID, Nombre FROM Rutinas", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlRutinas.DataSource = dt;
                ddlRutinas.DataTextField = "Nombre";
                ddlRutinas.DataValueField = "RutinaID";
                ddlRutinas.DataBind();
            }
        }

        protected void ddlRutinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rutinaID = Convert.ToInt32(ddlRutinas.SelectedValue);
            CargarEjerciciosDeRutina(rutinaID);
        }

        private void CargarEjerciciosDeRutina(int rutinaID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT re.RutinaEjercicioID, e.Nombre AS EjercicioNombre, re.Repeticiones, re.Series, re.Peso
                    FROM RutinaEjercicios re
                    INNER JOIN Ejercicios e ON re.EjercicioID = e.EjercicioID
                    WHERE re.RutinaID = @RutinaID", con);
                da.SelectCommand.Parameters.AddWithValue("@RutinaID", rutinaID);

                DataTable dt = new DataTable();
                da.Fill(dt);
                gvRutinaEjercicios.DataSource = dt;
                gvRutinaEjercicios.DataBind();
            }
        }

        protected void btnRegistrarProgreso_Click(object sender, EventArgs e)
        {
            int rutinaEjercicioID = Convert.ToInt32(gvRutinaEjercicios.SelectedDataKey["RutinaEjercicioID"]);
            DateTime fecha = DateTime.Now;
            int repeticiones = Convert.ToInt32(txtRepeticiones.Text);
            int series = Convert.ToInt32(txtSeries.Text);
            float peso = Convert.ToSingle(txtPeso.Text);
            string comentarios = txtComentarios.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Progreso (RutinaEjercicioID, Fecha, RepeticionesCompletadas, SeriesCompletadas, Comentarios)
                    VALUES (@RutinaEjercicioID, @Fecha, @RepeticionesCompletadas, @SeriesCompletadas, @Comentarios)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RutinaEjercicioID", rutinaEjercicioID);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@RepeticionesCompletadas", repeticiones);
                cmd.Parameters.AddWithValue("@SeriesCompletadas", series);
                cmd.Parameters.AddWithValue("@Comentarios", comentarios);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            txtRepeticiones.Text = "";
            txtSeries.Text = "";
            txtPeso.Text = "";
            txtComentarios.Text = "";
            CargarProgreso(rutinaEjercicioID);
        }

        private void CargarProgreso(int rutinaEjercicioID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT Fecha, RepeticionesCompletadas, SeriesCompletadas, Comentarios
                    FROM Progreso
                    WHERE RutinaEjercicioID = @RutinaEjercicioID", con);
                da.SelectCommand.Parameters.AddWithValue("@RutinaEjercicioID", rutinaEjercicioID);

                DataTable dt = new DataTable();
                da.Fill(dt);
                gvProgreso.DataSource = dt;
                gvProgreso.DataBind();
            }
        }

        protected void gvRutinaEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rutinaEjercicioID = Convert.ToInt32(gvRutinaEjercicios.SelectedDataKey["RutinaEjercicioID"]);
            CargarProgreso(rutinaEjercicioID);
        }
    }
}