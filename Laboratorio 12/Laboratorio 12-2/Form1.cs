namespace Laboratorio_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3;

            if (double.TryParse(txtNota1.Text, out nota1) && double.TryParse(txtNota2.Text, out nota2) && double.TryParse(txtNota3.Text, out nota3))
            {
                double promedio = (nota1 + nota2 + nota3) / 3;

                txtPromedio.Text = promedio.ToString("N2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para todas las notas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            txtPromedio.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
