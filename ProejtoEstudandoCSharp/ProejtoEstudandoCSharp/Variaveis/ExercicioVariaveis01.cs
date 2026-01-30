using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.Variaveis
{
    internal class ExercicioVariaveis01
    {
        public static void executar()
        {
            // Declaração de variáveis
            string nome = "Maria";
            int idade = 28;
            double altura = 1.70;
            double peso = 70.00;
            string cidade = "São Paulo";
            char genero = 'F';
            bool cadastroAtivo = true;

            // Exibindo os valores das variáveis
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Peso: {peso.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} kg");
            Console.WriteLine($"Cidade: {cidade}");
            Console.WriteLine($"Gênero: {genero}");
            Console.WriteLine($"Cadastro Ativo: {cadastroAtivo}");
        }
    }
}
