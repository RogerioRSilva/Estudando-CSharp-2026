using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.OperadoresAritimeticos
{
    internal class ExerciciosOperadoresAritmeticos01
    {
        public static void executar()
        {
            // Crie um programa que receba dois numeros e inteiros e faça as operadões básicas (adição, subtração, multiplicação e divisão);

            Console.Write("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            int subtracao = numero1 - numero2;
            int multiplicacao = numero1 * numero2;
            double divisao = (double)numero1 / numero2; // Cast para double para evitar divisão inteira

            Console.WriteLine($"\nResultados das operações entre {numero1} e {numero2}:\n");
            Console.WriteLine($"Adição: {numero1} + {numero2} = {soma}");
            Console.WriteLine($"Subtração: {numero1} - {numero2} = {subtracao}");
            Console.WriteLine($"Multiplicação: {numero1} * {numero2} = {multiplicacao}");
            Console.WriteLine($"Divisão: {numero1} / {numero2} = {divisao:F2}");

        }
    }
}
