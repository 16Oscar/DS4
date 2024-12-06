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
    public partial class Rutinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRutinas();
                CargarEjercicios();
            }
        }

        private void CargarRutinas()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rutinas", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvRutinas.DataSource = dt;
                gvRutinas.DataBind();
            }
        }

        private void CargarEjercicios()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT EjercicioID, Nombre FROM Ejercicios", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ddlEjercicios.DataSource = dt;
                ddlEjercicios.DataTextField = "Nombre";
                ddlEjercicios.DataValueField = "EjercicioID";
                ddlEjercicios.DataBind();
            }
        }

        protected void btnAgregarRutina_Click(object sender, EventArgs e)
        {
            string nombre = txtRutinaNombre.Text;
            DateTime fecha = Convert.ToDateTime(txtFechaRutina.Text);

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Rutinas (Nombre, Fecha) VALUES (@Nombre, @Fecha)", con);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Fecha", fecha);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                CargarRutinas();
                txtRutinaNombre.Text = string.Empty;
                txtFechaRutina.Text = string.Empty;
            }
        }

        protected void gvRutinas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int rutinaID = Convert.ToInt32(gvRutinas.DataKeys[index].Value);

            if (e.CommandName == "VerEjercicios")
            {
                ViewState["RutinaSeleccionada"] = rutinaID;
                lblRutinaSeleccionada.Text = "Rutina seleccionada: " + rutinaID;
                CargarEjerciciosDeRutina(rutinaID);
            }
            else if (e.CommandName == "EliminarRutina")
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Rutinas WHERE RutinaID = @RutinaID", con);
                    cmd.Parameters.AddWithValue("@RutinaID", rutinaID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    CargarRutinas();
                }
            }
        }

        private void CargarEjerciciosDeRutina(int rutinaID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT RE.RutinaEjercicioID, E.Nombre, RE.Repeticiones, RE.Series, RE.Peso 
                                                  FROM RutinaEjercicios RE
                                                  INNER JOIN Ejercicios E ON RE.EjercicioID = E.EjercicioID
                                                  WHERE RE.RutinaID = @RutinaID", con);
                cmd.Parameters.AddWithValue("@RutinaID", rutinaID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvEjerciciosRutina.DataSource = dt;
                gvEjerciciosRutina.DataBind();
            }
        }

        protected void btnAsignarEjercicio_Click(object sender, EventArgs e)
        {
            if (ViewState["RutinaSeleccionada"] == null)
            {
                lblRutinaSeleccionada.Text = "No hay ninguna rutina seleccionada. Por favor, selecciona una rutina de la lista.";
                lblRutinaSeleccionada.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int rutinaID = Convert.ToInt32(ViewState["RutinaSeleccionada"]);
            int ejercicioID = Convert.ToInt32(ddlEjercicios.SelectedValue);

            if (string.IsNullOrEmpty(txtRepeticiones.Text) || string.IsNullOrEmpty(txtSeries.Text) || string.IsNullOrEmpty(txtPeso.Text))
            {
                lblRutinaSeleccionada.Text = "Por favor, llena todos los campos.";
                lblRutinaSeleccionada.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int repeticiones;
            int series;
            decimal peso;

            if (!int.TryParse(txtRepeticiones.Text, out repeticiones))
            {
                lblRutinaSeleccionada.Text = "Por favor, ingresa un número válido para las repeticiones.";
                lblRutinaSeleccionada.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!int.TryParse(txtSeries.Text, out series))
            {
                lblRutinaSeleccionada.Text = "Por favor, ingresa un número válido para las series.";
                lblRutinaSeleccionada.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!decimal.TryParse(txtPeso.Text, out peso))
            {
                lblRutinaSeleccionada.Text = "Por favor, ingresa un número válido para el peso.";
                lblRutinaSeleccionada.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand verificarRutinaCmd = new SqlCommand("SELECT COUNT(*) FROM Rutinas WHERE RutinaID = @RutinaID", con);
                verificarRutinaCmd.Parameters.AddWithValue("@RutinaID", rutinaID);

                con.Open();
                int rutinaExiste = (int)verificarRutinaCmd.ExecuteScalar();
                con.Close();

                if (rutinaExiste == 0)
                {
                    lblRutinaSeleccionada.Text = "La rutina seleccionada no existe. Por favor, selecciona una rutina válida.";
                    lblRutinaSeleccionada.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO RutinaEjercicios (RutinaID, EjercicioID, Repeticiones, Series, Peso) VALUES (@RutinaID, @EjercicioID, @Repeticiones, @Series, @Peso)", con);
                cmd.Parameters.AddWithValue("@RutinaID", rutinaID);
                cmd.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                cmd.Parameters.AddWithValue("@Repeticiones", repeticiones);
                cmd.Parameters.AddWithValue("@Series", series);
                cmd.Parameters.AddWithValue("@Peso", peso);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            CargarEjerciciosDeRutina(rutinaID);
        }



        protected void gvEjerciciosRutina_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rutinaEjercicioID = Convert.ToInt32(gvEjerciciosRutina.DataKeys[e.RowIndex].Value);

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM RutinaEjercicios WHERE RutinaEjercicioID = @RutinaEjercicioID", con);
                cmd.Parameters.AddWithValue("@RutinaEjercicioID", rutinaEjercicioID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                int rutinaID = Convert.ToInt32(ViewState["RutinaSeleccionada"]);
                CargarEjerciciosDeRutina(rutinaID);
            }
        }
    }
}