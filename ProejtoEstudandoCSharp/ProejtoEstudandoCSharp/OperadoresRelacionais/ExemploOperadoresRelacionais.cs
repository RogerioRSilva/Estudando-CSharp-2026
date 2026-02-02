using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.OperadoresRelacionais
{
    internal class ExemploOperadoresRelacionais
    {
        public static void executar()
        {
            Console.WriteLine("Exemplo de Operadores Relacionais:\n----------------------------------\n");

            // Declaração de variáveis
            int a = 10;
            int b = 20;

            // Operações Relacionais
            // Igualdade
            bool igual = a == b;
            Console.WriteLine($"Igualdade: {a} == {b} -> {igual}");

            // Desigualdade
            bool diferente = a != b;
            Console.WriteLine($"Desigualdade: {a} != {b} -> {diferente}");

            // Maior que
            bool maiorQue = a > b;
            Console.WriteLine($"Maior que: {a} > {b} -> {maiorQue}");

            // Menor que
            bool menorQue = a < b;
            Console.WriteLine($"Menor que: {a} < {b} -> {menorQue}");

            // Maior ou igual a
            bool maiorOuIgual = a >= b;
            Console.WriteLine($"Maior ou igual a: {a} >= {b} -> {maiorOuIgual}");

            // Menor ou igual a
            bool menorOuIgual = a <= b;
            Console.WriteLine($"Menor ou igual a: {a} <= {b} -> {menorOuIgual}");
        }
    }
}
