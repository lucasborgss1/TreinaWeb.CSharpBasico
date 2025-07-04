using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Juridica : Cliente
    {
        private string cnpj;

        public Juridica()
        {
            cnpj = "";
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public void Incluir()
        {
            status = cnpj + " incluído";
        }

        public override void Excluir()
        {
            status = cnpj + " excluido.";
        }

        public override void EnderecoCliente()
        {
            Console.WriteLine("Endereço do cliente jurídico " + Endereco) ;
        }
    }
}
