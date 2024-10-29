using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        List<string> historial = new List<string>();
        public Form1()
        {
            InitializeComponent();
            cmbPeso.Items.Add("kilogramos");
            cmbPeso.Items.Add("libras");
            cmbAltura.Items.Add("metros");
            cmbAltura.Items.Add("pies");

            
            cmbPeso.SelectedIndex = 0; 
            cmbAltura.SelectedIndex = 0; 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);

                if (cmbPeso.SelectedItem.ToString() == "libras")
                {
                    peso = peso * 0.453592;
                }
                if (cmbAltura.SelectedItem.ToString() == "pies")
                {
                    altura = altura * 0.3048;
                }

                double imc = peso / (altura * altura);

                lblResultado.Text = "IMC: " + imc.ToString();

                historial.Add($"Peso: {peso:F2} kg, Altura: {altura:F2} m, IMC: {imc}");
                ActualizarHistorial();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos para el peso y la altura.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ActualizarHistorial()
        {
            lstHistorial.Items.Clear();
            foreach (string registro in historial)
            {
                lstHistorial.Items.Add(registro);
            }
        }

        private void rbPies_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLibras_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}





