namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juridica clienteJuridica = new Juridica
            {
                Codigo = 1,
                Nome = "João",
                Endereco = "Rua A, 123",
                Cnpj = "1233312211",
                Status = "Ativo"
            };
            clienteJuridica.Incluir();


            Fisica clienteFisica = new Fisica
            {
                Codigo = 2,
                Nome = "Maria",
                Endereco = "Rua B, 456",
                Cpf = "123456789",
                Status = "Ativo"
            };
            clienteFisica.Incluir();
        }
    }
}
