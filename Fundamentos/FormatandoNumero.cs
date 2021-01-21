using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            // Formatando numeros usando ToString
            Console.WriteLine(valor.ToString("F1")); //ToString("F1") - o numero depois do F representa a quantidade de casas decimais
            Console.WriteLine(valor.ToString("C"));// ToString("C") - C formata o numero adicionando formato em moeda R$" Antes do numero 
            Console.WriteLine(valor.ToString("P")); // ToString("P") - P multiplica o numero por 100 e adiciona porcentagem % apos o numero 
            Console.WriteLine(valor.ToString("#.##")); // ToString("#.##") - ##.## é um formato expecifico de adicionar casas decimais

            CultureInfo cultura = new CultureInfo("pt-br"); /* o Tipo de variavel CultureInfo + o valor new CultureInfo("pais")
                                                             * formata pontuação e $ para pais desejado*/

            Console.WriteLine(valor.ToString("C2", cultura)); 
            /* Exemplo - adicionando  C de coins e 2 de duas casas decimais a variavel cultura (pt-br)*/

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));/*ToString("D10") - Adiciona 0 a esquerda com valor de 10 o mesmo ficara com 10 numeros
                                                        * ex: 0000000256 */


        }
    }
}
