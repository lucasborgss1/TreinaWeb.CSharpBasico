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
            int numero1 = txbn1.Text == "" ? 0 : Convert.ToInt32(txbn1.Text);
            int numero2 = txbn2.Text == "" ? 0 : Convert.ToInt32(txbn2.Text);
            int resultado = numero1 + numero2;
            txbresult.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = txbn1.Text == "" ? 0 : Convert.ToInt32(txbn1.Text);
            int numero2 = txbn2.Text == "" ? 0 : Convert.ToInt32(txbn2.Text);
            int resultado = numero1 / numero2;
            txbresult.Text = resultado.ToString();
        }

        private void btnRestoDivisao_Click(object sender, EventArgs e)
        {
            int numero1 = txbn1.Text == "" ? 0 : Convert.ToInt32(txbn1.Text);
            int numero2 = txbn2.Text == "" ? 0 : Convert.ToInt32(txbn2.Text);
            int resultado = numero1 % numero2;
            txbresult.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = txbn1.Text == "" ? 0 : Convert.ToInt32(txbn1.Text);
            int numero2 = txbn2.Text == "" ? 0 : Convert.ToInt32(txbn2.Text);
            int resultado = numero1 * numero2;
            txbresult.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int numero1 = txbn1.Text == "" ? 0 : Convert.ToInt32(txbn1.Text);
            int numero2 = txbn2.Text == "" ? 0 : Convert.ToInt32(txbn2.Text);
            int resultado = numero1 - numero2;
            txbresult.Text = resultado.ToString();
        }
    }
}
