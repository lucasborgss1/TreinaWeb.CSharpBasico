namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente
            {
                Codigo = 1,
                Nome = "João",
                Status = "Ativo"
            };

            Fisica clienteFisica = new Fisica
            {
                Codigo = 2,
                Nome = "Maria",
                Cpf = 123456789,
                Status = "Ativo"
            };
            clienteFisica.Incluir();
        }
    }
}
