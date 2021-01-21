using System;
using System.Globalization; // Usado com CultureInfo.InvariantCulture para transformar pontos em virgula 


namespace CursoCSharp.Fundamentos
{
	class LendoDados
	{
		public static void Executar() {
            Console.Write("Qual é o seu nome?");
			string nome = Console.ReadLine(); // Console.Readline() -  Simplesmente vai ler a variavel nome

            Console.Write("Qual sua idade? ");
			int idade = int.Parse(Console.ReadLine()); // .Parse - Converte a variavel idade para numeros

            Console.Write("Qual é seu salario? ");
			double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			// (CultureInfo.InvariantCulture) - Usado para transformar o (ponto) . em (virgula) , em todos os sistemas operacionais

            Console.WriteLine($" Nome {nome} Idade {idade} R${salario}");
           
        }
	}
}
