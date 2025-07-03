namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = 1;
            cliente.Nome = "João";
            cliente.Status = "Ativo";

            Fisica clienteFisica = new Fisica(); 
            clienteFisica.Codigo = 2;
            clienteFisica.Nome = "Maria";
            clienteFisica.Cpf = 123456789;
            clienteFisica.Status = "Ativo";
            clienteFisica.Incluir();
        }
    }
}
