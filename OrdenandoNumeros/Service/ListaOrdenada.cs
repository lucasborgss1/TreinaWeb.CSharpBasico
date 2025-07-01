using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoNumeros.Service
{
    internal class ListaOrdenada
    {
        public int tamanho { get; set; }
        public double[] numeros { get; set; }
        public ListaOrdenada(int tamanho)
        {
            this.tamanho = tamanho;
            numeros = new double[tamanho];
        }

        public void AdicionarNumero(double numero, int index)
        {
            if (index <= tamanho)
            {
                numeros[index] = numero;
            }
        }

        public void ExibirNumeros()
        {
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        public void OrdenarLista()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                int menorIndice = i;
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[j] < numeros[menorIndice])
                    {
                        menorIndice = j;
                    }
                }
                if (menorIndice != i)
                {
                    double temp = numeros[i];
                    numeros[i] = numeros[menorIndice];
                    numeros[menorIndice] = temp;
                }
            }
        }
    }
}
