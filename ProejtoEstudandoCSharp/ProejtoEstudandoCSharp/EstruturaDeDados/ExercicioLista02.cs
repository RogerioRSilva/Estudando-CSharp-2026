using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDados {
    internal class ExercicioLista02 {
        public static void Executar() {
            // Crie um programa que armazene 20 numeros aleatórios em uma lista e faça a separação dos números pares e ímpares em duas listas distintas.
            // Em seguida, exiba as três listas (original, pares e ímpares) na tela.

            // Criando as listas para armazenar os números
            List<int> numerosAleatorios = new List<int>();
            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

            // Gerando 20 números aleatórios entre 1 e 100 e armazenando na lista original
            Random random = new Random();
            for (int i = 0; i < 20; i++) {
                int numero = random.Next(1, 101);
                numerosAleatorios.Add(numero);
            }

            // Separando os números pares e ímpares
            foreach (int numero in numerosAleatorios) {
                if (numero % 2 == 0) {
                    numerosPares.Add(numero);
                } else {
                    numerosImpares.Add(numero);
                }
            }

            // Exibindo as três listas na tela
            Console.WriteLine("Números Aleatórios:");
            Console.WriteLine(string.Join(", ", numerosAleatorios));

            Console.WriteLine("\nNúmeros Pares:");
            Console.WriteLine(string.Join(", ", numerosPares));

            Console.WriteLine("\nNúmeros Ímpares:");
            Console.WriteLine(string.Join(", ", numerosImpares));

        }
    }
}
