using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Fisica : Cliente
    {
        private string cpf;

        public Fisica()
        {
            cpf = "";
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public void Incluir()
        {
            status = cpf + " incluído.";
        }

        public override void Excluir()
        {
            status = cpf + " excluído.";
        }

        public override void EnderecoCliente()
        {
            Console.WriteLine("Endereço do cliente físico: " + Endereco);
        }
    }
}
