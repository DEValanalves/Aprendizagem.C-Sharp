using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar () {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true; // vira falso , motivo : !booleano

            Console.WriteLine(-valorNegativo); // nesse codigo  o valor sera positivo pois o -valorNegativo  sera + motivo : !booleano
            Console.WriteLine(!booleano); // Converte negativo para positvio , verdadeiro para falso - vice versa

            numero1++; // numero1++ : Sera = 3  ++ depois da variavel soma com 1  - Incremento
            Console.WriteLine(numero1);

            --numero1; // --numero1 : Sera 2 pois --antes da variavel tira 1 da mesma   - Decremento
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); 
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
