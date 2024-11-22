using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                double resultado = num1 + num2;
                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }
    }
}