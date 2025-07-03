using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public abstract class Cliente
    {
        private int codigo;
        private string nome;
        private string endereco;
        protected string status;

        public Cliente()
        {
            codigo = 0;
            nome = string.Empty;
            endereco = string.Empty;
            status = string.Empty;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public void Excluir()
        {
            status = codigo + " excluído.";
        }

        public virtual void EnderecoCliente()
        {
            Console.WriteLine("Endereço do cliente: " + endereco);
        }
    }
}
