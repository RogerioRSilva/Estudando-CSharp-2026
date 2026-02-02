using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExerciciosEstruturaDecisao02
    {
        public static void executar()
        {
            /**
             * Crie um programa que solicite ao usuário que digite dois números.
             * O programa deve comparar os dois números e exibir qual deles é o maior.
             * Se os números forem iguais, o programa deve informar que são iguais.
             */

            Console.WriteLine("Digite o primeiro número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"O maior número é: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O maior número é: {numero2}");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }
    }
}
