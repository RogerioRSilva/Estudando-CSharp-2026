using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.EstruturaDeDados {
    internal class ExercicioLista01 {
        public static void Executar() {
            // Crie uma aplicação que percorra uma lista que contenha 10 de nomes de pessoa e faça as seguintes operações:
            // a) Adicione 5 nomes à lista.
            // b) Exiba os nomes na tela.
            // c) Identifique o tamanho da lista.
            // d) Acesse um elemento específico pelo índice.
            // e) Identifique o índice de um elemento específico.
            // f) Remova um elemento da lista.
            // g) Percorra a lista e identifique em que posição está o nome "Sofia"
            // h) Troque o nome de "Sofia" por "Helena"

            // Criando uma lista populada com 10 nomes em portugues do brasil
            List<string> listaNomes = new List<string>() {
                "Maria", "João", "Ana", "Carlos", "Fernanda",
                "Pedro", "Sofia", "Lucas", "Isabela", "Rafael"
            };

            // a) Adicione 5 nomes à lista.
            listaNomes.Add("Gabriel");
            listaNomes.Add("Beatriz");
            listaNomes.Add("Matheus");
            listaNomes.Add("Larissa");
            listaNomes.Add("Felipe");

            // b) Exiba os nomes na tela.
            Console.WriteLine(string.Join(", ", listaNomes));

            // c) Identifique o tamanho da lista.
            Console.WriteLine($"O tamanho da lista de nomes é de : {listaNomes.Count}" );

            // d) Acesse um elemento específico pelo índice.
            Console.WriteLine($"O nome no índice 3 é: {listaNomes[3]}.");

            // e) Identifique o índice de um elemento específico.
            Console.WriteLine($"O nome Fernanda está na posição {listaNomes.IndexOf("Fernanda")}.");

            // f) Remova um elemento da lista.
            listaNomes.Remove("Larissa");
                Console.WriteLine($"Lista de nomes após remoção de Larissa: {string.Join(", ", listaNomes)}");

            // g) Percorra a lista e identifique em que posição está o nome "Sofia"
            for (int i = 0; i < listaNomes.Count; i++) {
                if (listaNomes[i] == "Sofia") {
                    Console.WriteLine($"O nome Sofia está na posição {i}.");
                    break;
                }
            }

            // h) Troque o nome de "Sofia" por "Helena"
            foreach (string nome in listaNomes) {
                if (nome == "Sofia") {
                    int indiceSofia = listaNomes.IndexOf(nome);
                    listaNomes[indiceSofia] = "Helena";
                    Console.WriteLine($"Lista de nomes após troca de Sofia por Helena: {string.Join(", ", listaNomes)}");
                    break;
                }
            }

        }
    }
}
