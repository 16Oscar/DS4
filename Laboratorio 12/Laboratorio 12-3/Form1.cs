namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC, semiperimetro;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB) && double.TryParse(txtLadoC.Text, out ladoC))
            {
                if (EsTrianguloValido(ladoA, ladoB, ladoC))
                {
                    semiperimetro = (ladoA + ladoB + ladoC) / 2;
                    txtSemiperimetro.Text = semiperimetro.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Los lados ingresados no forman un triángulo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB) && double.TryParse(txtLadoC.Text, out ladoC))
            {
                if (EsTrianguloValido(ladoA, ladoB, ladoC))
                {
                    if (semiperimetro == 0)
                    {
                        semiperimetro = (ladoA + ladoB + ladoC) / 2;
                    }

                    double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
                    txtArea.Text = area.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Los lados ingresados no forman un triángulo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool EsTrianguloValido(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = string.Empty;
            txtLadoB.Text = string.Empty;
            txtLadoC.Text = string.Empty;
            txtSemiperimetro.Text = string.Empty;
            txtArea.Text = string.Empty;
            semiperimetro = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
