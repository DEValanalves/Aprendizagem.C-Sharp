using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false; // Varriavel boleano - Verdadeiro ou falso
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine(); 
            double.TryParse(entrada, out double nota); // Convertendo a variavel entrada do tipo string para numero Real

            Console.WriteLine("Possui bom comportamento? (S/N) : ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s") // se entrada for S ou s o bom comportamento é true senão continau falso
            //    bomComportamento = true;

            // bomComportamento = entrada == "S" || entrada == "s"; //  Esse codigo pode substituir o valor do codigo acima

            bomComportamento = entrada.ToLower() == "s"; /* Esse codigo substitui os dois codigos acima
                                                          * ToLower - Converte a letra s para S maiusculo*/

            if (nota >= 9.0 && bomComportamento) { // se nota maior ou igual a 9.0 e comportamento S  , Quadro de honra
                Console.WriteLine("Quadro de honra! ");
            }






        }
    }
}
