using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Proyecto_Semestral
{
    public partial class Ejercicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEjercicios();
            }
        }

        private void CargarEjercicios()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ejercicios", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvEjercicios.DataSource = dt;
                gvEjercicios.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Ejercicios (Nombre, Categoria, Descripcion) VALUES (@Nombre, @Categoria, @Descripcion)", con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                CargarEjercicios();
                LimpiarFormulario();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ViewState["EjercicioID"] != null)
            {
                int ejercicioID = Convert.ToInt32(ViewState["EjercicioID"]);
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Ejercicios SET Nombre = @Nombre, Categoria = @Categoria, Descripcion = @Descripcion WHERE EjercicioID = @EjercicioID", con);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@EjercicioID", ejercicioID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    CargarEjercicios();
                    LimpiarFormulario();
                }
            }
        }
        protected void gvEjercicios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvEjercicios.EditIndex = e.NewEditIndex;

            CargarEjercicios();
        }

        protected void gvEjercicios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEjercicios.EditIndex = -1;

            CargarEjercicios();
        }

        protected void gvEjercicios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int ejercicioID = Convert.ToInt32(gvEjercicios.DataKeys[e.RowIndex].Value);

            GridViewRow row = gvEjercicios.Rows[e.RowIndex];
            string nombre = (row.FindControl("txtNombre") as TextBox).Text;
            string categoria = (row.FindControl("txtCategoria") as TextBox).Text;
            string descripcion = (row.FindControl("txtDescripcion") as TextBox).Text;

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Ejercicios SET Nombre = @Nombre, Categoria = @Categoria, Descripcion = @Descripcion WHERE EjercicioID = @EjercicioID", con);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Categoria", categoria);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@EjercicioID", ejercicioID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            gvEjercicios.EditIndex = -1;

            CargarEjercicios();
        }


        protected void gvEjercicios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ejercicioID = Convert.ToInt32(gvEjercicios.DataKeys[e.RowIndex].Value);

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Ejercicios WHERE EjercicioID = @EjercicioID", con);
                cmd.Parameters.AddWithValue("@EjercicioID", ejercicioID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                CargarEjercicios();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            ViewState["EjercicioID"] = null;
        }
    }
}


