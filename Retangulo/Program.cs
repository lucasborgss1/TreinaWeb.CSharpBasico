using Retangulo.Utils;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a altura do retângulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura do retângulo: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            RetanguloModel retangulo = new RetanguloModel(largura, altura);
            double area = retangulo.CalcularArea();
            double perimetro = retangulo.CalcularPerimetro();
            Console.WriteLine($"A área do retângulo é: {area}");
            Console.WriteLine($"O perímetro do retângulo é: {perimetro}");
        }
    }
}
