namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pesoValue.Text) || string.IsNullOrWhiteSpace(alturaValue.Text))
            {
                MessageBox.Show("Por favor, preencha os campos de peso e altura.");
                return;
            }
            else if (!double.TryParse(pesoValue.Text, out _) || !double.TryParse(alturaValue.Text, out _))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para peso e altura.");
                return;
            }
            resultValue.Text = calcularIMC(Convert.ToDouble(pesoValue.Text), Convert.ToDouble(alturaValue.Text)).ToString("F2");
        }

        private double calcularIMC(double peso, double altura)
        {
            return (peso / (altura * altura));
        }
    }
}

