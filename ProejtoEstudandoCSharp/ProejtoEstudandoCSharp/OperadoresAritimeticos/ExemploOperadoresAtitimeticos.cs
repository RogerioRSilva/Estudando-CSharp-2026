using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.OperadoresAritimeticos
{
    internal class ExemploOperadoresAtitimeticos
    {
        public static void executar()
        {
            Console.WriteLine("Exemplo de Operadores Aritméticos:\n----------------------------------\n");

            // Declaração de variáveis
            int a = 10;
            int b = 3;

            // Operações Aritméticas

            // Adição
            int soma = a + b;
            Console.WriteLine($"Adição: {a} + {b} = {soma}");

            // Subtração
            int subtracao = a - b;
            Console.WriteLine($"Subtração: {a} - {b} = {subtracao}");

            // Multiplicação
            int multiplicacao = a * b;
            Console.WriteLine($"Multiplicação: {a} * {b} = {multiplicacao}");

            // Divisão
            int divisao = a / b;
            Console.WriteLine($"Divisão: {a} / {b} = {divisao}");

            // Módulo
            int modulo = a % b;
            Console.WriteLine($"Módulo: {a} % {b} = {modulo}");

            // Operações com Números Decimais
            double x = 10.0;
            double y = 3.0;

            double divisaoDecimal = x / y;
            Console.WriteLine($"\nDivisão com Números Decimais: {x} / {y} = {divisaoDecimal:F2}");

            // Precedência de Operadores
            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine("Precedencia de Operadores\n");

            Console.WriteLine($"no calculo: {a} + {b} * {2} = {a + b * 2} ");
            /**
             * Quando utilizamos mais de um operador em uma expressão, 
             * a precedência dos operadores determina a ordem em que as operações são realizadas.
             * 
             * No exemplo acima, a multiplicação (b * 2) tem precedência sobre a adição (a + ...),
             * sendo assim a multiplicação é realizada primeiro, seguida pela adição.
             * 
             * Quando queremos alterar a ordem das operações, podemos utilizar parênteses.
             * exemplo:
             * 
             * (a + b) * 2
             * 
             * Dessa forma, a adição (a + b) será realizada primeiro, seguida pela multiplicação do resultado por 2.
             * 
             */
            Console.WriteLine($"no calculo: ({a} + {b}) * {2} = {(a + b) * 2} ");

            // Operadores Compostos
            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine("Operadores Compostos\n");

            int c = 5;

            // Operador composto de adição
            Console.WriteLine($"Calculo com operador composto: {c} += {3} Resultado: {c += 3} ");

            // Operador composto de subtração
            Console.WriteLine($"Calculo com operador composto: {c} -= {2} Resultado: {c -= 2} ");

            // Operador composto de multiplicação
            Console.WriteLine($"Calculo com operador composto: {c} *= {10} Resultado: {c *= 10} ");

            // Operador composto de divisão
            Console.WriteLine($"Calculo com operador composto: {c} /= {4} Resultado: {c /= 4} ");

            // Utilizando Incremento e Decremento
            Console.WriteLine("\n-----------------------------\n");

            Console.WriteLine("Incremento e Decremento\n");

            int d = 7;
            Console.WriteLine($"Valor inicial de d: {d}");
            Console.WriteLine($"Incremento de d: {++d}"); // Pré-incremento
            Console.WriteLine($"Decremento de d: {--d}"); // Pré-decremento

            Console.WriteLine($"Valor inicial de d: {d}");
            Console.WriteLine($"Incremento de d: {d++}"); // Pós-incremento
            Console.WriteLine($"Valor de d após o pós-incremento: {d}");
            Console.WriteLine($"Decremento de d: {d--}"); // Pós-decremento
            Console.WriteLine($"Valor de d após o pós-decremento: {d}");

            /**
             * Os operadores de incremento (++) e decremento (--) podem ser utilizados
             * para aumentar ou diminuir o valor de uma variável em 1.
             * 
             * Quando utilizados antes da variável (pré-incremento/decremento),
             * Quando utilizados depois da variável (pós-incremento/decremento),
             * 
             * Exemplo:
             * ++ variavel (pré-incremento): incrementa o valor da variável antes de utilizá-la na expressão.
             * -- variavel (pré-decremento): decrementa o valor da variável antes de utilizá-la na expressão.
             * 
             * variavel ++ (pós-incremento): utiliza o valor atual da variável na expressão e depois incrementa.
             * variavel -- (pós-decremento): utiliza o valor atual da variável na expressão e depois decrementa.
             * 
             */

            // Conversão utilizando o CAST
            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine("Conversão utilizando o CAST\n");

            int inteiro = 9;
            double convertidoParaDouble = (double)inteiro; // Convertendo int para double usando CAST
            
            Console.WriteLine($"Valor inteiro: {inteiro}");
            Console.WriteLine($"Valor convertido para double: {convertidoParaDouble:F1}");



        }
    }
}
