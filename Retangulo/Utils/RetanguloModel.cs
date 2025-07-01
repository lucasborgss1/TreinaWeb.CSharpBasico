using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo.Utils
{
    internal class RetanguloModel
    {
        public double largura { get; set; }
        public double altura { get; set; }
        public RetanguloModel(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
        public double CalcularArea()
        {
            return largura * altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (largura + altura);
        }
    }
}
