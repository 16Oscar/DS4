using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "sql;Northwind;User Id = sa; Password= 1604";

        }
    }
}

/*Se requiere una aplicación web que permita mostrar el índice de masa corporal. Tomar en cuenta que: IMC = kg/m2
-Guardar un registro por cada cálculo realizado en la actual ejecución de aplicación (historial) y mostrarlo en la lista
-Windows Form con c#
-Manejo de exepciones
-Los datos de entrada (peso y estatura) serán recibidos en kg y metros respectivamente, si vienen en libras y/o pies realice la convrsión*/
