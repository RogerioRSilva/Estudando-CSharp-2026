using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProejtoEstudandoCSharp.EstruturaDeDados {
    internal class ExercicioLista03 {
        public static void Executar() {

            //List<int> numeros = new List<int>();

            //Console.WriteLine("Digite 5 números inteiros:");

            //for (int i = 0; i < 5; i++) {
            //    Console.Write($"Número {i + 1}: ");
            //    int valor = int.Parse(Console.ReadLine());
            //    numeros.Add(valor);
            //}

            //Console.WriteLine("\n--- Resultados ---");
            //Console.WriteLine("Todos os números: " + string.Join(", ", numeros));
            //Console.WriteLine("Maior número: " + numeros.Max());
            //Console.WriteLine("Menor número: " + numeros.Min());
            //Console.WriteLine("Média: " + numeros.Average());

            List<int> numeros = new List<int>();

            Console.WriteLine("Digite 5 números inteiros:");

            for (int i = 0; i < 5; i++) {
                Console.Write($"Número {i + 1}: ");
                int valor = int.Parse(Console.ReadLine());
                numeros.Add(valor);
            }

            // Inicializa maior e menor com o primeiro valor da lista
            int maior = numeros[0];
            int menor = numeros[0];
            int soma = 0;

            // Percorre a lista usando IF
            foreach (int n in numeros) {
                if (n > maior)
                    maior = n;

                if (n < menor)
                    menor = n;

                soma += n;
            }

            double media = soma / 5.0;

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine("Todos os números: " + string.Join(", ", numeros));
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Média: " + media);

        }
    }
}
