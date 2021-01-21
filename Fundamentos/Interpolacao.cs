using System;


namespace CursoCSharp.Fundamentos {
    class Interpolacao {
         public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // TIPOS DE COCATENAR UMA STRING e INPERPOLAR
            // Interpolação faz a cocatenação sem uso de string com + 


            Console.WriteLine("O" + nome +  " da marca " + marca + " custa " + preco); // Tipo de cocatenar string e variavel  usando " e +
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco); 
            // Tipo de interpolação usando sequencia de numeros de acordo com a ordem das variaveis declaradas

            Console.WriteLine($"A marca {marca} é legal!");
            // Tipo de Interpolação usando $ antes das aspas e {variavel } apos o nome para cocatenar 



        }
    }
}
