using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.OperadoresLogicos
{
    internal class ExemploOperadoresLogicos
    {
        public static void executar()
        {
            Console.WriteLine("Exemplo de Operadores Lógicos:\n----------------------------------\n");

            // Declaração de variáveis booleanas
            bool condicaoA = true;
            bool condicaoB = false;

            // Operações Lógicas
            // E lógico (AND)
            bool resultadoE = condicaoA && condicaoB;
            Console.WriteLine($"E lógico (AND): {condicaoA} && {condicaoB} -> {resultadoE}");

            /**
             * O operador E lógico (AND) retorna true somente se ambas as condições forem verdadeiras.
             * Caso qualquer uma das condições seja falsa, o resultado será false.
             */

            // OU lógico (OR)
            bool resultadoOU = condicaoA || condicaoB;
            Console.WriteLine($"OU lógico (OR): {condicaoA} || {condicaoB} -> {resultadoOU}");

            /**
             * O operador OU lógico (OR) retorna true se pelo menos uma das condições for verdadeira.
             * O resultado será false somente se ambas as condições forem falsas.
             */

            // NÃO lógico (NOT)
            bool resultadoNAO = !condicaoA;
            Console.WriteLine($"NÃO lógico (NOT): !{condicaoA} -> {resultadoNAO}");

            /**
             * O operador NÃO lógico (NOT) inverte o valor da condição.
             * Se a condição for true, o resultado será false, e vice-versa.
             */

            // OU exclusivo (XOR)
            bool resultadoXOR = condicaoA ^ condicaoB;
            Console.WriteLine($"OU exclusivo (XOR): {condicaoA} ^ {condicaoB} -> {resultadoXOR}");

            /**
             * O operador OU exclusivo (XOR) retorna true se exatamente uma das condições for verdadeira.
             * Se ambas as condições forem verdadeiras ou ambas forem falsas, o resultado será false.
             */

            // AND invertido (NAND)
            bool resultadoNAND = !(condicaoA && condicaoB);
            Console.WriteLine($"AND invertido (NAND): !({condicaoA} && {condicaoB}) -> {resultadoNAND}");

            /**
             * O operador AND exclusivo (NAND) retorna true se pelo menos uma das condições for falsa.
             * O resultado será false somente se ambas as condições forem verdadeiras.
             */
        }
    }
}
