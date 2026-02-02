using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExerciciosEstruturaDecisao04
    {
        public static void executar()
        {
            /**
             * Crie um programa que o usuário digite um valor em reais (R$).
             * Se o valor for menor que R$100,00, aplique um desconto de 5%.
             * Se o valor for entre R$100,00 e R$500,00, aplique um desconto de 10%.
             * Se o valor for maior que R$500,00, aplique um desconto de 15%.
             * Caso o usuário digite algum valor negativo, ou zero, o programa deve informar que o valor é inválido.
             */

            Console.WriteLine("Digite um valor em reais (R$):");
            double valor = double.Parse(Console.ReadLine().Replace(".", ","));

            if (valor > 0 && valor < 100)
            {
                double desconto = valor * 0.05;
                double valorFinal = valor - desconto;
                Console.WriteLine($"Valor com desconto de 5%: R$ {valorFinal:F2}");
            }
            else if (valor >= 100 && valor <= 500)
            {
                double desconto = valor * 0.10;
                double valorFinal = valor - desconto;
                Console.WriteLine($"Valor com desconto de 10%: R$ {valorFinal:F2}");
            }
            else if (valor > 500)
            {
                double desconto = valor * 0.15;
                double valorFinal = valor - desconto;
                Console.WriteLine($"Valor com desconto de 15%: R$ {valorFinal:F2}");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}
