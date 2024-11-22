using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio__20_2
{
    public partial class Matriz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            TableMatriz.Rows.Clear();

            if (int.TryParse(txtDimension.Text, out int n) && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    TableRow row = new TableRow();

                    for (int j = 0; j < n; j++)
                    {
                        TableCell cell = new TableCell();

                        cell.Text = (j == n - i - 1) ? "1" : "0";

                        row.Cells.Add(cell);
                    }

                    TableMatriz.Rows.Add(row);
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor, ingrese un valor válido para N (un número entero mayor a 0).');</script>");
            }
        }
    }
}