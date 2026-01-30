using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.SaidaDeDados
{
    internal class ExemploSaidaDeDados
    {
        public static void executar()
        {
            // Utilizando saida de dados com dados primitivos
            Console.WriteLine("Olá, mundo!"); // Texto - String
            Console.WriteLine(1000); // Número inteiro - Int
            Console.WriteLine(3.14); // Número decimal - Double
            Console.WriteLine(true); // Valor booleano - Bool
            Console.WriteLine('A'); // Caractere - Char

            Console.WriteLine("\n-----------------------------------\n");

            // Utilizando o Console.Write para saída de dados sem quebra de linha
            Console.Write("Este é um exemplo de ");
            Console.Write("saída de dados ");
            Console.Write("sem quebra de linha.");

            Console.WriteLine("\n-----------------------------------\n");

            // Utilizando a concatenação e quebra de linha
            Console.WriteLine("\nConcatenação de strings: " + "Olá, " + "mundo!");
            Console.WriteLine("Idade: " + 35);
            Console.WriteLine("Altura: " + 1.75);
            Console.WriteLine("Cadastro ativo: " + true);
            Console.WriteLine("Letra Inicial do nome: " + 'R');

            Console.WriteLine("\n-----------------------------------\n");

            // Utilizando interpolação 
            Console.WriteLine($"Oi meu nome é {"Rogério"} e tenho {42} anos.");
            /**
             * A utilização da interpolação é recomendada por melhorar a legibilidade do código,
             * sempre dentro das chaves { } você pode colocar expressões que serão avaliadas e convertidas em string.
             * Incluindo todos os tipos de dados primitivos.
             */

            Console.WriteLine("\n-----------------------------------\n");

            // Normalização de saída de dados
            Console.WriteLine("Número formatado: {0:N2}", 12345.6789); // Formata o número com 2 casas decimais
            Console.WriteLine("Data formatada: {0:dd/MM/yyyy}", DateTime.Now); // Formata a data no formato dia/mês/ano
            Console.WriteLine("Ajustando o numero decimal: " + (3.80).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n-----------------------------------\n");


        }
    }
}
