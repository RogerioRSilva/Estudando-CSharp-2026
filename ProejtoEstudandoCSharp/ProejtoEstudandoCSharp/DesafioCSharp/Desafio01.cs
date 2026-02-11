using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.DesafioCSharp {
    internal class Desafio01 {
        public static void Executar() {
            List<string> listaAlunos = new List<string>();
            List<List<double>> listaNotasAlunos = new List<List<double>>();

            Console.Write("Quantos alunos deseja cadastrar? (1 a 5): ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- CADASTRO DE ALUNOS ---\n");

            // Cadastro dos alunos
            for (int i = 0; i < quantidadeAlunos; i++) {
                Console.Write($"Digite o nome do aluno {i + 1}: ");
                string nome = Console.ReadLine();
                listaAlunos.Add(nome);

                List<double> notasAluno = new List<double>();

                Console.WriteLine($"Digite as 4 notas do aluno {nome}:");

                for (int j = 0; j < 4; j++) {
                    Console.Write($"Nota {j + 1}: ");
                    double nota = double.Parse(Console.ReadLine());
                    notasAluno.Add(nota);
                }

                listaNotasAlunos.Add(notasAluno);
                Console.WriteLine();
            }

            Console.WriteLine("\n--- RESULTADOS ---\n");

            double somaMedias = 0;
            double maiorMedia = double.MinValue;
            double menorMedia = double.MaxValue;
            string alunoMaiorMedia = "";
            string alunoMenorMedia = "";

            int aprovados = 0;
            int recuperacao = 0;
            int reprovados = 0;

            // Processamento dos dados
            for (int i = 0; i < quantidadeAlunos; i++) {
                string nome = listaAlunos[i];
                List<double> notasAluno = listaNotasAlunos[i];

                double soma = 0;
                for (int j = 0; j < notasAluno.Count; j++) {
                    soma += notasAluno[j];
                }

                double media = soma / notasAluno.Count;
                somaMedias += media;

                string status;

                if (media >= 6) {
                    status = "Aprovado";
                    aprovados++;
                }
                else if (media >= 4) {
                    status = "Recuperação";
                    recuperacao++;
                }
                else {
                    status = "Reprovado";
                    reprovados++;
                }

                // Verificando maior e menor média
                if (media > maiorMedia) {
                    maiorMedia = media;
                    alunoMaiorMedia = nome;
                }

                if (media < menorMedia) {
                    menorMedia = media;
                    alunoMenorMedia = nome;
                }

                // Exibição individual
                Console.WriteLine($"Aluno: {nome}");
                Console.Write("Notas: ");

                for (int j = 0; j < notasAluno.Count; j++) {
                    Console.Write(notasAluno[j]);
                    if (j < notasAluno.Count - 1)
                        Console.Write(", ");
                }

                Console.WriteLine($"\nMédia: {media:F2}");
                Console.WriteLine($"Status: {status}\n");
            }

            // Média geral da turma
            double mediaGeral = somaMedias / quantidadeAlunos;

            Console.WriteLine("--- RESUMO FINAL ---\n");
            Console.WriteLine($"Média geral da turma: {mediaGeral:F2}");
            Console.WriteLine($"Aprovados: {aprovados}");
            Console.WriteLine($"Recuperação: {recuperacao}");
            Console.WriteLine($"Reprovados: {reprovados}");
            Console.WriteLine($"Maior média: {alunoMaiorMedia} ({maiorMedia:F2})");
            Console.WriteLine($"Menor média: {alunoMenorMedia} ({menorMedia:F2})");


        }

    }
}
