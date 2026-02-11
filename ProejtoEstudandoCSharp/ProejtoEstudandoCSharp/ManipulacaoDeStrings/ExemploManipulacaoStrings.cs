using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.ManipulacaoDeStrings {
    internal class ExemploManipulacaoStrings {
        public static void Executar() {
            // Convertendo as strings em minusculas e maiusculas
            // Para isso vamos utilizar o metodo ToUpper() e ToLower
            /**
             * ToUpper() - Converte todos os caracteres de uma string para maiúsculas.
             * 
             * ToLower() - Converte todos os caracteres de uma string para minúsculas.
             */

            string texto = "Olá, Mundo!";
            Console.WriteLine("Texto original: " + texto);
            Console.WriteLine("Convertendo para Maiusculo: " + texto.ToUpper());
            Console.WriteLine("Convertendo para Minusculo: " + texto.ToLower());

            // Utilizando o método Trim() para remover espaços em branco no início e no final de uma string

            Console.WriteLine("\n---------------------------------\n");

            string textoComEspacos = "   Algum texto aqui.   ";
            Console.WriteLine("Texto original: '" + textoComEspacos + "'");
            Console.WriteLine("Texto após Trim(): '" + textoComEspacos.Trim() + "'");
            Console.WriteLine("Removendo o espaço do inicio: " + textoComEspacos.TrimStart());
            Console.WriteLine("Removendo o espaço do final: " + textoComEspacos.TrimEnd());

            // Acesso e Analise de caracteres em uma string
                Console.WriteLine("\n---------------------------------\n");
            string frase = "C# é uma linguagem de programação poderosa.";
            Console.WriteLine("Frase: " + frase);

            // Length - Retorna o número de caracteres em uma string 
            Console.WriteLine("Quantidade de Caracteres na frase: " + frase.Length);

            // Verificando um trexo existente em uma string utilizando o método Contains()
            Console.WriteLine("A frase contém a palavra 'poderosa'? " + frase.Contains("poderosa"));

            // Verificando inicio e fim de uma string utilizando os métodos StartsWith() e EndsWith()
            Console.WriteLine("A frase começa com 'C#'? " + frase.StartsWith("C#"));
            Console.WriteLine("A frase termina com 'poderosa.'? " + frase.EndsWith("poderosa."));

            // Retornando o índice de um caractere ou substring utilizando o método IndexOf() pegando o inicio da palavra
            Console.WriteLine("Índice da palavra 'linguagem': " + frase.IndexOf("linguagem"));


            Console.WriteLine("\n---------------------------\n");

            // Substituindo parte de uma string utilizando o método Replace()
            string fraseOriginal = "Estou utilizando um teclado e um mouse.";
            Console.WriteLine(fraseOriginal);
            string fraseSubstituida = fraseOriginal.Replace("teclado", "notebook").Replace("mouse", "touchpad");
            Console.WriteLine("Frase após substituição: " + fraseSubstituida);

            // Dividindo uma string em partes utilizando o método Split()
            string separandoFrase = "C#,Java,Python,JavaScript";
            Console.WriteLine("Formato original da string: " + separandoFrase);
            string[] linguagens = separandoFrase.Split(',');
            Console.WriteLine("Linguagens de Programação após separação:");
            foreach (string linguagem in linguagens) {
                Console.WriteLine("- " + linguagem);
            }

        }
    }
}
