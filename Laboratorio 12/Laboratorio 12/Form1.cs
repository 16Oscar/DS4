namespace Laboratorio_12              //Laboratorio 12-1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double velocidad, tiempo;

            if (double.TryParse(txtVelocidad.Text, out velocidad) && double.TryParse(txtTiempo.Text, out tiempo))
            {
                double distancia = velocidad * tiempo;

                txtDistancia.Text = distancia.ToString("N2") + " metros";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para velocidad y tiempo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVelocidad.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            txtDistancia.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
