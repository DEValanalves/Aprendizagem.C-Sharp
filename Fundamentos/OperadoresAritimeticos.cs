using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritimeticos {
        public static void Executar () {

            // Preço com Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1; // sera considerado 10%

            
            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto); //Conta com 10% de desconto
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC 
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Obs: Math.Pow(altura , 2) - Math.Pow ele a quantidade que digitar depois da altura ,
            Console.WriteLine($"IMC é:  {imc}."); // Math.Pow - Seria a mesma coisa que altura * altura  (altura, 2)

            // Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); //obs: Modo - (par , par % 2 ) Seria o resto da divisão dividido por 2
                                                                     // resulado sendo = 0  é par

            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2); //Mdo (impar, impar % 2) Seria o resto da divisao dividido por 2
                                                                          // nesse caso como é impar o resultado seria = 1  impar




        }
    }
}
