using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {         /* Convertendo valor INTEIRO (int) em REAL  (double) 
                                               FORMA INPLICITA - quando o computador não exige que faça alteração
                                                Obs: int cabe dentro do double sem problema pois double tem mais capacidade de armazenamento*/
           int inteiro = 10;                                                  
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;                 // Convertendo um Valor REAL (double) para INTEIRO (int)                             
            int notaTruncada = (int)nota;      // Obs: adicionaa o tipo int entre parentes (int)antes da variavel real que quer converter 
            Console.WriteLine("Nota truncada: {0}", notaTruncada); // FORMA EXPLICITA - tem que declarar a forma CASH sintaxe = (INT) 

            Console.WriteLine("Digite sua idade: ");  //Convertendo string para numero usando int.Parse 
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);              //Convertendo string para numero usando Convert.Toint32
            Console.WriteLine("Rresultado: {0}", idadeInteiro);

            Console.WriteLine("Digite um número"); // Formma segura de converter sem da erro mesmo que digite letra ao invez de numero
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); // Int.Tryparse - tentar fazer um passe = (string)palavra para (int)numero

            Console.WriteLine("Digite o segundo numero: "); // Formma segura de converter sem da erro mesmo que digite letra ao invez de numero
            int.TryParse(Console.ReadLine(), out int numero2); // usando Console.ReadLine direto para conversão de palavra para inteiro.
            Console.WriteLine("Resultado 2: {0}", numero2);

        }
    }
}
