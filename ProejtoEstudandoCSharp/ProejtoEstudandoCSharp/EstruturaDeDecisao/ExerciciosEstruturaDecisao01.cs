using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExerciciosEstruturaDecisao01
    {
        public static void executar()
        {
            /**
             * Crie um programa que solicite ao usuário que digite um número inteiro.
             * Após o numero ser digitado, o programa deve verificar se o número é positivo,
             * negativo ou zero, e exibir uma mensagem correspondente na tela.
             */

            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
    }
}
