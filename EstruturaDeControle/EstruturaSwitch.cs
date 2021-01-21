using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaSwitch {
        public static void Executar() {

            Console.Write("Avalie Meu atendimento com nota de 1 a 5:  ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    Console.WriteLine("Nos informe o  porque para melhor atendermos");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Otimo");
                    Console.WriteLine("Ficamos Felizes");
                    break;
            }
            Console.WriteLine("Obrigado por Avaliar");
        }

    }
}
