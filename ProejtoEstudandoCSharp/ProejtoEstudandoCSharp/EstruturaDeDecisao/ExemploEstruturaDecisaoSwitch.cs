using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExemploEstruturaDecisaoSwitch
    {
        public static void executar()
        {
            Console.WriteLine("Exemplo de Estrutura de Decisão SWITCH:\n----------------------------------\n");
            // Declaração de variável
            int diaDaSemana = 3;
            /**
             * Sintaxe do SWITCH:
             * switch (variável ou expressão)
             * {
             *      case valor1:
             *          // Código a ser executado se a variável for igual a valor1
             *          break;
             *      case valor2:
             *          // Código a ser executado se a variável for igual a valor2
             *          break;
             *      ...
             *      default:
             *          // Código a ser executado se nenhum dos casos anteriores for atendido
             *          break;
             * }
             */
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
