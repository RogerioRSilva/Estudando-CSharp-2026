using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDados
{
    internal class ExemploListas
    {
        public static void Executar()
        {
            Console.WriteLine("Exemplo de Listas em C#:\n----------------------------------\n");

            // Criando lista do tipo String
            List<string>listaNomes = new List<string>();

            // Adicionando elementos à lista
            listaNomes.Add("Alice");
            listaNomes.Add("Bob");
            listaNomes.Add("Charlie");

            // Exibindo os elementos da lista
            Console.WriteLine("Elementos na lista de nomes após adição:");
            Console.WriteLine(string.Join(", ", listaNomes));

            // Identificando o tamanho da lista
            int tamanhoNomes = listaNomes.Count;
            Console.WriteLine($"\nTamanho da lista de nomes: {tamanhoNomes}");

            // Acessando um elemento pelo índice
            string primeiroNome = listaNomes[0];
            Console.WriteLine($"\nPrimeiro nome na lista: {primeiroNome}");

            // Identificando o índice de um elemento
            int indiceCharlie = listaNomes.IndexOf("Charlie");
            Console.WriteLine($"\nÍndice de Charlie na lista: {indiceCharlie}");

            // Removendo um elemento da lista
            listaNomes.Remove("Bob");
            Console.WriteLine("\nElementos na lista de nomes após remoção de Bob:");
            Console.WriteLine(string.Join(", ", listaNomes));

            // Percorrendo a lista com for convencional
            Console.WriteLine("\nPercorrendo a lista de nomes com for convencional:");
            for (int i = 0; i < listaNomes.Count; i++)
            {
                Console.WriteLine($"Nome no índice {i}: {listaNomes[i]}");
            }

            // Pecorrendo a lista com foreach
                       Console.WriteLine("\nPercorrendo a lista de nomes com foreach:");
            foreach (string nome in listaNomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }

            // Criação de uma lista de inteiros
            List<int> numeros = new List<int>();

            // Adicionando elementos à lista
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            numeros.Add(40);
            numeros.Add(50);
            Console.WriteLine("Elementos na lista após adição:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Acessando um elemento pelo índice
            int primeiroNumero = numeros[0];
            Console.WriteLine($"\nPrimeiro número na lista: {primeiroNumero}");

            // Removendo um elemento da lista
            numeros.Remove(30);
            Console.WriteLine("\nElementos na lista após remoção de 30:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Verificando o tamanho da lista
            int tamanho = numeros.Count;
            Console.WriteLine($"\nTamanho da lista: {tamanho}");

        }
    }
}
