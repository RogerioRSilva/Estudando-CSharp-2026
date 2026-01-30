using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoEstudandoCSharp.Variaveis
{
    internal class ExemploVariaveis
    {
        public static void executar()
        {
            // Declaração de variáveis
            int idade = 30;
            double altura = 1.75;
            char genero = 'M';
            bool estudante = true;
            string nome = "João";

            // Exibindo os valores das variáveis
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Gênero: " + genero);
            Console.WriteLine("Estudante: " + estudante);

            /**
             * O que são variáveis?
             * Variáveis são espaços na memória do computador onde podemos 
             * armazenar dados temporariamente durante a execução de um programa.
             * 
             * Qual a finalidade das variáveis?
             * Serem utilizadas para guardar informações que podem ser alteradas ou manipuladas
             * durante a execução do programa. E podemos reutilizá-las quantas vezes forem necessárias.
             * 
             * Tipos primitivos de variáveis em C#:
             * 
             * string: Armazena sequências de caracteres (ex: "Olá, Mundo!")
             * int: Armazena números inteiros (ex: 10, -5, 0)
             * double: Armazena números decimais (ex: 3.14, -0.5)
             * bool: Armazena valores verdadeiros ou falsos (ex: true, false)
             * char: Armazena um único caractere (ex: 'A', 'b', '1')
             * 
             */

            // Convertendo os tipos de variáveis
            int numeroInteiro = 10;
            string numeroString = numeroInteiro.ToString(); // Convertendo int para string
            Console.WriteLine("Número como string: " + numeroString);

            string textoNumero = "25";
            int numeroConvertido = int.Parse(textoNumero); // Convertendo string para int
            Console.WriteLine("Número convertido: " + numeroConvertido);

            string textoDecimal = "3,14";
            Console.WriteLine("Valor da String em Decimal: " + textoDecimal);
            double decimalConvertido = double.Parse(textoDecimal); // Convertendo string para double
            Console.WriteLine("Número decimal convertido sem normalizar: " + decimalConvertido);
            textoDecimal = textoDecimal.Replace('.', ',');
            double decimalConvertidoNormalizado = double.Parse(textoDecimal); // Convertendo string para double com normalização
            Console.WriteLine("Número decimal convertido com normalização: " 
                + decimalConvertidoNormalizado.ToString(CultureInfo.InvariantCulture));
            /** 
             * Observação: Dependendo da cultura, pode ser necessário usar vírgula ao invés de ponto
             * Nesses casos temos que fazer a normalização dos dados antes da conversão e em muitos momentos
             * precisamos fazer na parte da entrada dos dados e na saída dos dados.
             * 
             * Exemplo:
             * normalização na entrada dos dados:
             * numeroDecimal = double.Parse(textoDecimal, CultureInfo.InvariantCulture);
             * 
             * normalização na saída dos dados:
             * saida no console: numeroDecimal.ToString("F2", CultureInfo.InvariantCulture);
             * 
             * Porem mesmo assim ainda pode haver problemas dependendo da cultura do sistema operacional.
             * Para garantir a correta conversão, é recomendado utilizar o REPLACE para substituir vírgulas por pontos ou vice-versa.
             * 
             * Então o código ficaria assim:
             * 
             * string textoDecimal = "3,14";
             * textoDecimal = textoDecimal.Replace(',', '.');
             * 
             * int numeroConvertido = double.Parse(textoDecimal, CultureInfo.InvariantCulture);
             * 
             * Dessa forma garantimos que a conversão será feita corretamente independentemente da cultura do sistema operacional.
             * 
            */


        }
    }
}
