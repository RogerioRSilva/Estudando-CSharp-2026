using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeRepeticao
{
    internal class ExemploEstruturaRepeticaoFOR
    {
        public static void Executar()
        {
            // Utilizando o laço FOR para repetir uma ação um número determinado de vezes
            Console.WriteLine("Contando de 1 até 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Execução número: {i}");
            }
            /**
             * Sintaxe do laço FOR:
             * 
             * for (inicialização; condição; incremento/decremento)
             * 
             * O laço FOR é útil quando sabemos de antemão quantas vezes queremos repetir uma ação.
             * 
             * O FOR sempre vai repetir o código que estiver dentro de suas chaves {} enquanto a condição for verdadeira.
             * Assim que a condição se tornar falsa, o laço é encerrado e a execução do programa continua após o laço.
             * 
             * Em alguns casos o laço pode se tornar infinito se a condição nunca se tornar falsa.
             * 
             */

            Console.WriteLine("\n--------------------------------\n");

            // Laço FOR infinito (CUIDADO!)
            //for (int i = 1; i <= 5; i--)
            //{
            //    Console.WriteLine($"Execução número: {i}");
            //}

            Console.WriteLine("Contagem regressiva de 5 até 0");
            // Exemplo de laço FOR com decremento
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine($"Contagem regressiva: {i}");
            }


        }
    }
}
