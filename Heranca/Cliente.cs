using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private string status;

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

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public void Excluir()
        {
            status = codigo + " excluído.";
        }
    }
}
