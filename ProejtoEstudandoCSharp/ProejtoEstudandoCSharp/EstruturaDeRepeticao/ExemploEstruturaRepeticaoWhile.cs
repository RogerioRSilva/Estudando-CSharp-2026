using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoEstudandoCSharp.EstruturaDeRepeticao {
    internal class ExemploEstruturaRepeticaoWhile {
        public static void Executar() {

            /**
             * O que é o while?
             * A estrutura de repetição while é uma das formas de criar loops em C#. 
             * Ela executa um bloco de código repetidamente enquanto uma condição especificada for verdadeira. 
             * 
             * A sintaxe básica do while é a seguinte:
             * while (condição) { bloco de código }
             * 
             * A principal diferença entre o while e o for é que o while é mais flexível, 
             * pois não exige uma inicialização, uma condição de parada ou um incremento explícito.
             * Porem o while pode ser mais propenso a erros, como loops infinitos, se a condição nunca se tornar falsa.
             */

            Console.WriteLine("Utilizando o While\n--------------------------------\n");
            int contador = 0;
            while (contador < 5) {
                Console.WriteLine($"Contador: {contador}");
                contador++;
            }

            // Exemplo com um limitador como condição de parada
            Console.WriteLine("Utilizando o While com um limitador");
            string resposta = "N";
            while (resposta.ToLower() != "s") { // Utilizando o ToLower para aceitar tanto "S" maiusculo quanto minusculo
                Console.Write("Deseja sair do loop? (S/N): ");
                resposta = Console.ReadLine();

            }

            // Exemplo com leitura de texto até o usuário digitar "SAIR"
            Console.WriteLine("\n-------------------\n");
            String texto = "";
            while (!(texto.ToLower() == "sair")) {
                Console.Write("Digite um texto (ou 'SAIR' para encerrar): ");
                texto = Console.ReadLine();
                Console.WriteLine($"Você digitou: {texto}");
            }
            Console.WriteLine("Programa encerrado.");


            // Exemplo utilizando true e break
            Console.WriteLine("\n-------------------\n");
            while (true) {
                Console.Write("Digite um número (ou '0' para encerrar): ");
                int numero = int.Parse(Console.ReadLine());
                if (numero == 0) {
                    break; // Sai do loop se o número for 0
                }
                Console.WriteLine($"Você digitou: {numero}");
            }

            // Exemplo utilizando um menu com while e switch
            Console.WriteLine("\n-------------------\n");
            int opcao = 0;
            while (true) {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Opção 1");
                Console.WriteLine("2 - Opção 2");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.WriteLine("Você escolheu a Opção 1");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu a Opção 2");
                        break;
                    case 3:
                        Console.WriteLine("Saindo do menu...");
                        return; // Encerra o método, saindo do loop
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

        }
    }
}
