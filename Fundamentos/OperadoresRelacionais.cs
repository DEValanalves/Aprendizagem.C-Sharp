using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {

            // double nota = 6.0;   Pode ser usado assim  ou com Console.readline
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota); // usando com Console.Readline() - o valor da nota digitado pelo usuario
            double notaDeCorte = 7.0;

            // Vai Executar false ou true = Verdadeiro ou falso 
            Console.WriteLine("Nota invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota invalida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota <notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);

        }
    }
}
