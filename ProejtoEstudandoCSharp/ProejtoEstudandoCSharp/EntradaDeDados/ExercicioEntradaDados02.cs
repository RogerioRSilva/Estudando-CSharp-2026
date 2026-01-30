using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EntradaDeDados
{
    internal class ExercicioEntradaDados02
    {
        public static void executar()
        {
            // Montando uma franse com os dados fornecidos pelo usuário
            Console.WriteLine("Montando uma frase com seus dados!\n-----------------------------------\n");
            Console.Write("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (em metros, ex: 1.75): ");
            double altura = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine($"\nOlá, {nomeCompleto}! \nVocê tem {idade} anos e sua altura é {altura.ToString("F2", CultureInfo.InvariantCulture)} metros.");
        }
    }
}
