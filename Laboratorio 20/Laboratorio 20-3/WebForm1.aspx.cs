using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System;

namespace Laboratorio_20_3
{
    public partial class WebForm1 : Page
    {
        bool nuevo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;
                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
                txtStock.Enabled = false;
                nuevo = false; 
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();
            nuevo = true; 
            txtId.Text = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (true)
                {
                    cmd.CommandText = "INSERT INTO Laptops (Nombre, Precio, Stock) VALUES (@Nombre, @Precio, @Stock)";
                }
                else
                {
                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        Response.Write("<script>alert('Advertencia: El campo ID está vacío. No se puede actualizar.');</script>");
                        return;
                    }

                    cmd.CommandText = "UPDATE Laptops SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock WHERE ID=@ID";
                    cmd.Parameters.AddWithValue("@ID", txtId.Text);
                }

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);

                decimal precio;
                if (decimal.TryParse(txtPrecio.Text, out precio))
                {
                    cmd.Parameters.AddWithValue("@Precio", precio);
                }
                else
                {
                    Response.Write("<script>alert('Error: El valor de Precio no es válido.');</script>");
                    return;
                }

                float stock;
                if (float.TryParse(txtStock.Text, out stock))
                {
                    cmd.Parameters.AddWithValue("@Stock", stock);
                }
                else
                {
                    Response.Write("<script>alert('Error: El valor de Stock no es válido.');</script>");
                    return;
                }

                con.Open();
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('Registro guardado correctamente');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Advertencia: No se afectó ninguna fila. Verifica que el ID sea correcto y que tengas permisos.');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
                finally
                {
                    con.Close();
                }
            }
            ResetControls();
            nuevo = false;
        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Laptops WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", txtId.Text);

                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                cmd.Transaction = transaction;

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    transaction.Commit();

                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('Registro eliminado correctamente');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Error: No se encontró el registro para eliminar');</script>");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }

            ResetControls();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Laptops WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", txtBuscarId.Text);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader["ID"].ToString();
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtPrecio.Text = reader["Precio"].ToString();
                    txtStock.Text = reader["Stock"].ToString();
                    nuevo = false;

                    btnGuardar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnNuevo.Enabled = false;
                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                }
                else
                {
                    Response.Write("<script>alert('Registro no encontrado');</script>");
                }

                con.Close();
            }
        }

        private void ResetControls()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtBuscarId.Text = "";
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            nuevo = false;
        }
    }
}
