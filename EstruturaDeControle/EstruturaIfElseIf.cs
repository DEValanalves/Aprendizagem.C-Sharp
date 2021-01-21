using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {

            Console.WriteLine("Digite a nota do Aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota); // usado try.parse para caso usuario digite letra não aconteça erro e fique 0

            if (nota >= 9.0) { // Expressão se 
                Console.WriteLine("Quadro de Honra!!"); 
            } else if (nota >= 7.0) { // Expressão Senão se 
                Console.WriteLine("Aprovado!");
            } else if (nota >= 5.0) { // Expressão Senão se 
                Console.WriteLine("Recuperação");
            } else { // Expressão Senão semrpe usada no fim de else e if 
                Console.WriteLine("Te vejo na proxima....");
            }
            Console.WriteLine("Fim!!");

            }
            }

        }
   
