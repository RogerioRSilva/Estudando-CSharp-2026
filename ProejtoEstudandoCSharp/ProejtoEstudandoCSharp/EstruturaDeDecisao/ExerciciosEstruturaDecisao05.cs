using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExerciciosEstruturaDecisao05
    {
        public static void executar()
        {
            /**
             * Crie um programa que solicite ao usuário que digite um número de 1 a 7,
             * representando os dias da semana (1 para domingo, 2 para segunda-feira, etc.).
             * O programa deve usar uma estrutura de decisão switch para exibir o nome do dia correspondente.
             * Se o número digitado não estiver entre 1 e 7, o programa deve informar que o número é inválido.
             */

            Console.WriteLine("Digite um número de 1 a 7 para representar o dia da semana:");
            int diaDaSemana = Convert.ToInt32(Console.ReadLine());

            switch (diaDaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Número inválido! Por favor, insira um número entre 1 e 7.");
                    break;
            }
        }
    }
}
