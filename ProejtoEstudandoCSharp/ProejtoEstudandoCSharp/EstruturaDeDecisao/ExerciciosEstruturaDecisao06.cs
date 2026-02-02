using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExerciciosEstruturaDecisao06
    {
        public static void executar()
        {
            /**
             * Crie um programa que o usuário deve digitar 4 notas de um aluno.
             * Após as notas serem digitadas, o programa deve calcular a média aritmética das notas.
             * Seguindo as seguintes reagras, o programa deve exibir se o aluno foi aprovado, 
             * reprovado ou está em recuperação:
             * 0.00 a 4.99: Reprovado
             * 5.00 a 6.99: Recuperação
             * 7.00 a 10.00: Aprovado
             * 
             * Caso seja digitada alguma nota inválida (menor que 0 ou maior que 10), 
             * o programa deve informar que a nota é inválida e não calcular a média.
             * 
             */

            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine().Replace(".", ","));

            if (nota1 < 0 || nota1 > 10 ||
                nota2 < 0 || nota2 > 10 ||
                nota3 < 0 || nota3 > 10 ||
                nota4 < 0 || nota4 > 10)
            {
                Console.WriteLine("Nota inválida. As notas devem estar entre 0 e 10.");
                return;
            }

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"Média: {media.ToString("F2", CultureInfo.InvariantCulture)}");

            if (media >= 0 && media <= 4.99)
            {
                Console.WriteLine("Reprovado");
            }
            else if (media >= 5.00 && media <= 6.99)
            {
                Console.WriteLine("Recuperação");
            }
            else if (media >= 7.00 && media <= 10.00)
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}
