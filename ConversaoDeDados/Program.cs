namespace ConversaoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão explicita
            int i;
            double y = 10.5;
            i = (int)y;
            // No exemplo abaixo, a conversão pode ser feita de forma implícita, pois o tipo 'int' é menor que o tipo 'long'.    
            long x;
            int a = 5;
            x = a;
        }
    }
    class boxing
    {
        // Boxing é o processo de converter um tipo de valor em um tipo de referência.
        // Unboxing é o processo inverso, convertendo um tipo de referência de volta para um tipo de valor.
        public void ExemploBoxingUnboxing()
        {
            int valor = 10;
            object obj = valor; // Boxing
            int valorDesconstruido = (int)obj; // Unboxing
        }
    }
}
