using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoEstudandoCSharp.SaidaDeDados
{
    internal class Exercicio03
    {
        public static void executar()
        {
            Console.WriteLine($"Nome: {"Maria"}");
            Console.WriteLine($"Idade: {28}");
            Console.WriteLine($"Altura: {1.70.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Peso: {70.00.ToString("F2", CultureInfo.InvariantCulture)} kg");
            Console.WriteLine($"Cidade: {"São Paulo"}");
            Console.WriteLine($"Gênero: {'F'}");
            Console.WriteLine($"Cadastro Ativo: {true}");

        }
    }
}
