using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExerciciosEstruturaDecisao03
    {
        public static void executar()
        {
            /**
             * Crie um programa que solicite ao usuário que digite a sua idade.
             * Após a idade ser digitada, o programa deve verificar qual a sua faixa etária:
             * 0-12 anos: Criança
             * 13-19 anos: Adolescente
             * 20-64 anos: Adulto
             * 65 anos ou mais: Idoso
              */

            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Criança");
            }
            else if (idade >= 13 && idade <= 19)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade >= 20 && idade <= 64)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade >= 65)
            {
                Console.WriteLine("Idoso");
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }
        }
    }
}
