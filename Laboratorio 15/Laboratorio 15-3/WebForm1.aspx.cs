using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSaludo_Click(object sender, EventArgs e)
        {
            String texto = txtMensaje.Text;
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "MessageBox", "window.alert('Hola: " + texto + "');", true);
        }
    }
}