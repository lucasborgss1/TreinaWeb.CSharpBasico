using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Fisica : Cliente
    {
        private int cpf;

        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public void Incluir()
        {
            Status = cpf + " incluído.";
        }
    }
}
