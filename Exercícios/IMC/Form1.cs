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
            resultValue.Text = calcularIMC(Convert.ToDouble(pesoValue.Text), Convert.ToDouble(alturaValue.Text)).ToString();
        }

        private double calcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}

