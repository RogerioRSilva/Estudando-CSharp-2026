using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoEstudandoCSharp.EntradaDeDados
{
    internal class ExemploEntradaDeDados
    {
        public static void executar()
        {
            Console.WriteLine("ENTRADA DE DADOS\n");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (em metros, ex: 1.75): ");
            double altura = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("\nDados digitados:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
