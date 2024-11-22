using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                DataTable tablaMultiplicar = new DataTable();
                tablaMultiplicar.Columns.Add("Multiplicación", typeof(string));
                tablaMultiplicar.Columns.Add("Resultado", typeof(int));

                for (int i = 1; i <= 25; i++)
                {
                    DataRow row = tablaMultiplicar.NewRow();
                    row["Multiplicación"] = $"{numero} x {i}";
                    row["Resultado"] = numero * i;
                    tablaMultiplicar.Rows.Add(row);
                }

                GridViewTabla.DataSource = tablaMultiplicar;
                GridViewTabla.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Por favor, ingrese un número válido.');</script>");
            }
        }
    }
}