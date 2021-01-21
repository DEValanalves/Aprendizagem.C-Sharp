using System;


namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
         
            // VALOR DECIMAL - double mais usado
            double raio     = 4.5; // double variavel numerica usado em casas decimais  exp 4.6 10.5
            const double PI = 3.14;
            raio = 5.5;
            //PI = 3.1415;  Quando usado const o valor não pode ser alterado

            double area = PI * raio * raio;
            Console.WriteLine(area); 
            Console.WriteLine("Área é " + area); // Se usar ("Área é " + (area + 10)) o Resultado seria Area + 10 

            bool estaChovendo = false; // bool (verdadeiro ou falso) variavel = true (verdadeiro) false (falso)
            Console.WriteLine("Está chovendo " + estaChovendo);
            // VALORES INTEIROS
            sbyte saldoDeGols = sbyte.MinValue; // sbytes tem o valro de até -128  (negativo)
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros! ( Int=  int.MinValue = 2 bilhões) Int para positivo e negativo
            Console.WriteLine("menor int" + menorValorInt);

            uint populacaoBrasileira = 207_600_00; // Unit - Somente positivio 0 até 2 bilhões
            Console.WriteLine("População Brasileira" + populacaoBrasileira);

            long menorValorLong = long.MinValue; // long - o menor valor do long seria 7 bilhões tanto para negativo com opara positivo 
            Console.WriteLine("Menor long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_00; // ulong - O menor valor de 7 bilhoes para positivo não aceita negativo
            Console.WriteLine("População Mundial " + populacaoMundial);

            // char letra = 'b'; char - Usado com uam aspas e apenas para uma letra
            // string texto = "seja bem vindo" - STRING - usado para uma cadeia de texto com duas aspas "






            //VALORES REAIS - VARIAVEIS E CONSTANTES










        }
    }
}
