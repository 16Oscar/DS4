using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server= 16Oscar\sqlexpress; Database= Northwind; TrustServerCertificate=true; Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");

            CargarProductos();

        }

        private void TablaProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CargarProductos()
        {
            string query = "SELECT ProductName FROM Products";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            TablaProducts.Items.Clear();

                            while (reader.Read())
                            {
                                string productName = reader["ProductName"].ToString();
                                TablaProducts.Items.Add(productName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message);
                }
            }
        }
    }
}
