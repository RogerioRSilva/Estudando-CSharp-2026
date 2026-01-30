using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudandoCSharp.SaidaDeDados
{
    internal class NormalizacaoDados
    {
        public static void executar()
        {
            // ============================
            // NÚMEROS
            // ============================

            double numero = 12345.6789;

            Console.WriteLine("Número padrão (N): {0:N}", numero);       // 12.345,68
            Console.WriteLine("Número com 2 casas decimais (N2): {0:N2}", numero); // 12.345,68
            Console.WriteLine("Número fixo com 2 casas (F2): {0:F2}", numero);     // 12345,68
            Console.WriteLine("Moeda (C): {0:C}", numero);               // R$ 12.345,68
            Console.WriteLine("Porcentagem (P): {0:P}", 0.1234);         // 12,34 %

            // Usando CultureInfo para internacionalização
            Console.WriteLine("Número com ponto decimal (InvariantCulture): " +
                numero.ToString("N2", CultureInfo.InvariantCulture));    // 12,345.68
            Console.WriteLine("Moeda em inglês (en-US): " +
                numero.ToString("C", new CultureInfo("en-US")));         // $12,345.68

            // ============================
            // DATAS
            // ============================

            DateTime agora = DateTime.Now;

            Console.WriteLine("Data curta (dd/MM/yyyy): {0:dd/MM/yyyy}", agora);   // 30/01/2026
            Console.WriteLine("Hora (HH:mm:ss): {0:HH:mm:ss}", agora);             // 11:41:00
            Console.WriteLine("Data longa (D): {0:D}", agora);                     // sexta-feira, 30 de janeiro de 2026
            Console.WriteLine("Data e hora (f): {0:f}", agora);                    // sexta-feira, 30 de janeiro de 2026 11:41

            // ============================
            // STRINGS
            // ============================

            string nome = "Rogério";
            int idade = 35;

            // Interpolação de strings (mais moderno e legível)
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");

            // Alinhamento
            Console.WriteLine("Alinhado à direita (10 espaços): [{0,10}]", nome);
            Console.WriteLine("Alinhado à esquerda (10 espaços): [{0,-10}]", nome);
        }

    }
}
