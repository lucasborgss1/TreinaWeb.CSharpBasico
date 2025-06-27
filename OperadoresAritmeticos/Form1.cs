namespace OperadoresAritmeticos
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            txbresult.Text = operadoresAritmeticos(Convert.ToInt32(txbn1.Text), Convert.ToInt32(txbn2.Text), "+").ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txbresult.Text = operadoresAritmeticos(Convert.ToInt32(txbn1.Text), Convert.ToInt32(txbn2.Text), "/").ToString();
        }

        private void btnRestoDivisao_Click(object sender, EventArgs e)
        {
            txbresult.Text = operadoresAritmeticos(Convert.ToInt32(txbn1.Text), Convert.ToInt32(txbn2.Text), "%").ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txbresult.Text = operadoresAritmeticos(Convert.ToInt32(txbn1.Text), Convert.ToInt32(txbn2.Text), "*").ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            txbresult.Text = operadoresAritmeticos(Convert.ToInt32(txbn1.Text), Convert.ToInt32(txbn2.Text), "-").ToString();
        }

        int operadoresAritmeticos(int numero1, int numero2, string operador)
        {
            int resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                case "%":
                    resultado = numero1 % numero2;
                    break;
            }
            return resultado;
        }
    }
}
