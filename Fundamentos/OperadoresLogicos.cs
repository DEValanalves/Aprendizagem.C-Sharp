using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executoutrabalho1 = true;
            var executoutrabalho2 = false;

            bool comprouTv50 = executoutrabalho1 && executoutrabalho2; // && - Representa E
            Console.WriteLine("Comprou Tv 50? {0}", comprouTv50); // Não comprou TV 50, Deveria estar true(verdadeiro) trabalho1 e trabalho2

            var comprouSorvete = executoutrabalho1 || executoutrabalho2; // || - Representa OU
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete); // Comprou o sorvete, pois nao executou trabalho1 mas executou trabalho2

            var comprouTv32 = executoutrabalho1 ^ executoutrabalho2; // ^ - Representa OU exclusivo ( so da averdadeiro se executar um ou outro)
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32); // Comprou TV 32, pois Executou trabalho1 e não executou trabalho2

            Console.WriteLine("Maisa saudavel? {0}", !comprouSorvete); // ! no comprouSorvete - Deixa falso se for verdadeiro e verdadeiro se for falso
               


        }
    }
}
