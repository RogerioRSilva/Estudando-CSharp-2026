using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EntradaDeDados
{
    internal class ExercicioEntradaDados01
    {
        public static void executar()
        {
            Console.WriteLine("Cadastro de Produto: \n----------------------\n");

            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.Write("Digite a quantidade em estoque: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine());


            Console.WriteLine("\nResumo do Produto Cadastrado:");
            Console.WriteLine($"Nome: {nomeProduto}");
            Console.WriteLine($"Preço: R$ {precoProduto.ToString("N2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque} unidades");
        }
    }
}
