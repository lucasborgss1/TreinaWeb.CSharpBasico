using IntOrientacaoObjetos.Model;

namespace IntOrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.Cor = "Vermelho";
            c1.Modelo = "Vectra";
            c1.Motor = "1.8";
            c1.Ligar();
            c1.Acelerar();
            c1.MudarMarcha();
            c1.Brecar();
            c1.Desligar();

            Carro c2 = new Carro();
        }
    }
}
