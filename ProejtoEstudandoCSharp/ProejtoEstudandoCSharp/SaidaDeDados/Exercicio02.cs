using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoEstudandoCSharp.SaidaDeDados
{
    internal class Exercicio02
    {
        public static void executar()
        {
            Console.WriteLine("Descriçaõ do Produto: \n");
            Console.WriteLine("Nome do Produto: " + "Notebook");
            Console.WriteLine("Valor do Produto: " + 2560.90.ToString("N2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quantidade: " + 5);
        }
    }
}
