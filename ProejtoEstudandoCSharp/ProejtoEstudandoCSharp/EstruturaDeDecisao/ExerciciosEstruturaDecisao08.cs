using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDecisao
{
    internal class ExerciciosEstruturaDecisao08
    {
        public static void executar()
        {
            /**
            * Crie um programa em C# que simule uma compra online.    
            * O usuário deve informar o valor do produto, o saldo disponível
            * e se o produto está em estoque.
            * O programa deve verificar:
            *   - Se o produto está disponível.
            *   - Se o saldo é suficiente para realizar a compra.
            * Exiba mensagens diferentes para cada situação.
            * 
            */

            Console.WriteLine("Bem-vindo à loja virtual!");

            Console.Write("Digite o valor do produto: ");
            double valorProduto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o saldo disponível na sua conta: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("O produto está em estoque? (sim/não): ");
            string estoque = Console.ReadLine().ToLower();

            if (estoque == "sim")
            {
                if (saldo >= valorProduto)
                {
                    Console.WriteLine("Compra realizada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar a compra.");
                }
            }
            else
            {
                Console.WriteLine("Produto indisponível no momento.");
            }

        }
    }
}
