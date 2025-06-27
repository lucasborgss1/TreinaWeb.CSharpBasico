using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caracteres de escape: "\n" (nova linha) ; "\t" (tabulação)
            string s = "ab\ncd";
            Console.WriteLine(s);
            s = "ab\tcd";
            Console.WriteLine(s);
            //Caracteres de escape: "\\" (barra invertida) ; "\"" (aspas duplas)
            s = "ab\\cd";
            Console.WriteLine(s);
            //@ ignora caracteres de escape e quebras de linha.
            s = @"ab\ncd";
            Console.WriteLine(s);

            // Torna a aplicação mais eficiente em termos de memória.
            StringBuilder sb = new StringBuilder();
            sb.Append("ab");
            sb.Append("  ");
            sb.Append("cd");
            Console.WriteLine(sb.ToString());
        }
    }
}
