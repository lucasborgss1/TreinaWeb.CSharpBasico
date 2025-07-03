
namespace IntOrientacaoObjetos.Model
{
    class Carro
    {
        public string Cor = "";
        public string Modelo = "";
        public string Motor = "";
        public string Status = "";

        public void Ligar()
        {
            Status = "Ligando o carro.";
        }

        public void Desligar()
        {
            Status = "Desligando o carro.";
        }

        public void Acelerar()
        {
            Status = "Acelerando o carro.";
        }

        public void Brecar()
        {
            Status = "Brecando o carro.";
        }

        public void MudarMarcha()
        {
            Status = "Mudando de Marcha.";
        }
    }
}
