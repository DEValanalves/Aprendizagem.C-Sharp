using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Alan";/* Var - pode usar a variavel do tipo var 
                              * o sistema ira descubrir qual o tipo da mesma
                              * O Valor da mesma deve ser declarado na sequencia
                              */

            Console.WriteLine(nome);

            // int idade;
            var idade = 32;  /* Var - pode usar a variavel do tipo var 
                              * o sistema ira descubrir qual o tipo da mesma
                              * O Valor da mesma deve ser declarado na sequencia
                              */
                              
            Console.WriteLine(idade);

            int a;  // ex 1 Modelos de como pode ser declarado valor a Variavel
            a = 3;  // ex 1
            int b = 2; //ex 2

            Console.WriteLine(a + b);


        }
    }
}
