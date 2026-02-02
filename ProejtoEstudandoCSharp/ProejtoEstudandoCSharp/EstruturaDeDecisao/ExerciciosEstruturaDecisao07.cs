using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExerciciosEstruturaDecisao07
    {
        public static void executar()
        {
            /**
             * Crie um programa que solicite ao usuário que digite um número inteiro.
             * O programa deve verificar se o número é par ou ímpar e exibir a mensagem correspondente.
             * 
             */
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            string validacao = (numero % 2 == 0) ? "par" : "ímpar";

            Console.WriteLine($"O número {numero} é {validacao}.");
        }
    }
}
