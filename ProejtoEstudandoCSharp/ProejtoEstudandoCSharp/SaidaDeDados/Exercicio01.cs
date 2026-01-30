using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoEstudandoCSharp.SaidaDeDados
{
    internal class Exercicio01
    {
        public static void executar()
        {
            Console.WriteLine(false);
            Console.WriteLine('M');
            Console.WriteLine(58);
            Console.WriteLine((5.9).ToString(CultureInfo.InvariantCulture));
            Console.WriteLine($"Oi! Sou o {"Rogério"} e tenho {42} anos. ");
        }
    }
}
