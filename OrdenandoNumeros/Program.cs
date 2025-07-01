namespace OrdenandoNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da lista:");
            int tamanho = int.Parse(Console.ReadLine());
            Service.ListaOrdenada lista = new Service.ListaOrdenada(tamanho);
            double numero;
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                try
                {
                    numero = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                    i--;
                    throw;
                }
                lista.AdicionarNumero(numero , i);
            }
            Console.WriteLine();
            Console.WriteLine("Lista antes da ordenação:");
            lista.ExibirNumeros();
            Console.WriteLine();
            Console.WriteLine("Ordenando a lista...");
            lista.OrdenarLista();
            Console.WriteLine("Lista ordenada:");
            lista.ExibirNumeros();
        }
    }
}
