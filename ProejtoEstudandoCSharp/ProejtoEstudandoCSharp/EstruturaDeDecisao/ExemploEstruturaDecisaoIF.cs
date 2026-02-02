using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExemploEstruturaDecisaoIF
    {
        public static void executar()
        {
            Console.WriteLine("Exemplo de Estrutura de Decisão IF:\n----------------------------------\n");
            // Declaração de variável
            int numero = 10;

            // Estrutura de Decisão IF
            /**
             * Sintaxe:
             * if (condição)
             * {
             *      bloco de codigo a ser executado se a condição for verdadeira
             * }
             */
            Console.WriteLine("Exemplo com IF simples.");
            if (numero > 0) // Nesse formato estamos utilizando o IF de forma simples, sem o ELSE
            {
                Console.WriteLine($"Sim {numero} é maior que Zero!!");
            }

            /**
             * Sintaxe com ELSE:
             * if (condição)
             * {
             *      Codigo a ser executado se a condição for verdadeira
             * } else {
             *      Codigo a ser executado se a condição for falsa
             * }
             */

            Console.WriteLine("\nExemplo com IF e ELSE.");
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é um número par.");
            }
            else
            {
                Console.WriteLine($"{numero} é um número ímpar.");
            }

            /**
             * Sintaxe com ELSE IF:
             * 
             * if (condição1)
             * {
             *      Codigo a ser executado se a condição1 for verdadeira. Caso seja falsa,
             *      pula para o próximo if.
             * } 
             * else if (condição2)
             * {
             *      Codigo a ser executado se a condição2 for verdadeira. Caso seja falsa,
             *      pula para o else final ou para o próximo else if caso tenha.
             * } else {
             *      Codigo a ser executado se todas as condições anteriores forem falsas.
             * }
             */
            Console.WriteLine("\nExemplo com IF, ELSE IF e ELSE.");
            int idade = 20;
            if (numero > 0 && idade < numero)
            {
                Console.WriteLine($"A idade {idade} é maior que 0 e menor que o {numero}");
            }
            else if (idade == numero)
            {
                Console.WriteLine($"A idade {idade} é igual a {numero}.");
            }
            else
            {
                Console.WriteLine($"A idade {idade} é maior que {numero}.");
            }

            // Operador Ternário
            /**
             * Sintaxe:
             * 
             * condição ? valor_se_verdadeiro : valor_se_falso;
             * 
             * O operador ternário é uma forma concisa de escrever uma estrutura de decisão IF-ELSE.
             * Dessa forma, podemos atribuir um valor a uma variável com base em uma condição, 
             * tudo em uma única linha de código.
             * 
             */
            int numero2 = 45;
            Console.WriteLine("\nExemplo com Operador Ternário.");
            string resultado = (numero2 % 2 == 0) ? "par" : "ímpar";
            Console.WriteLine($"{numero2} é um número {resultado}.");

            // IF Aninhado

            /**
             * Sintaxe:
             * 
             * if (condição1)
             * {
             *      if (condição2)
             *      {
             *          Codigo a ser executado se condição1 e condição2 forem verdadeiras
             *      }
             * }
             * 
             * O IF aninhado é uma estrutura de decisão onde um bloco IF está dentro de outro bloco IF.
             * Isso permite verificar múltiplas condições de forma hierárquica.
             */

            Console.WriteLine("\nExemplo com IF Aninhado.");
            int numero3 = 25;

            if (numero3 < 0)
            {
                Console.WriteLine($"O numero {numero3} é negativo");
                if (numero3 % 2 == 0)
                {
                    Console.WriteLine($"E também é um número par.");
                }
                else
                {
                    Console.WriteLine($"E também é um número ímpar.");
                }
            }
            else
            {
                Console.WriteLine($"O numero {numero3} é positivo.");
                if (numero3 % 2 == 0)
                {
                    Console.WriteLine($"E também é um número par.");
                }
                else
                {
                    Console.WriteLine($"E também é um número ímpar.");
                }
            }



        }
    }
}
