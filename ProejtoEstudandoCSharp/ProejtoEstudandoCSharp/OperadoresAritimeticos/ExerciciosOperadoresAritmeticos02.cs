using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.OperadoresAritimeticos
{
    internal class ExerciciosOperadoresAritmeticos02
    {
        public static void executar()
        {
            // Crie um programa que calcule a média aritmética de três números fornecidos pelo usuário.
            Console.Write("Digite o primeiro numero: ");
            double numero1 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Digite o segundo numero: ");
            double numero2 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Digite o terceiro numero: ");
            double numero3 = double.Parse(Console.ReadLine().Replace(".", ","));

            double mediaAritmetica = (numero1 + numero2 + numero3) / 3;

            Console.WriteLine($"\nA média aritmética de " +
                $"{numero1.ToString("F2", CultureInfo.InvariantCulture)}" +
                $", {numero2.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"e {numero3.ToString("F2", CultureInfo.InvariantCulture)} é: " +
                $"{mediaAritmetica.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
