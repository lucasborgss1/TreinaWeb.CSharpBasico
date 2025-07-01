namespace Enum
{
    internal class Program
    {
        enum DiaDaSemana
        {
            Domingo,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }

        enum StatusPedido
        {
            Pendente = 1,
            Processando = 2,
            Enviado = 3,
            Entregue = 4,
            Cancelado = 5
        }


        static void Main(string[] args)
        {
        
        StatusPedido status = StatusPedido.Pendente;

            if (status == StatusPedido.Pendente)
            {
                Console.WriteLine("O pedido está pendente.");
            }

            // Convertendo enum para inteiro
            int codigo = (int)StatusPedido.Enviado;  // Resultado: 3

            // Convertendo inteiro para enum
            status = (StatusPedido)3;  // Resultado: StatusPedido.Enviado

            // Convertendo enum para string
            string nome = StatusPedido.Enviado.ToString();  // Resultado: "Enviado"

            // Convertendo string para enum
            status = (StatusPedido)System.Enum.Parse(typeof(StatusPedido), "Enviado");

        }
    }
}
