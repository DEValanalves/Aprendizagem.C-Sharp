using System;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "ola".ToUpper()/* .ToUpper ()- Deixa a letra da variavel do valor OLA maiuscula */
                .Insert(3, "World!")
                /* .Insert() depois da 3 letra  ola inclui o valor World! */
                .Replace("World!", "Mundo"); 
            /* Replace.("valor que quer muda", "para qual valor")-                                     
             * Transcreve o valor World para depois da virgula Mundo */

            Console.WriteLine(saudacao);
            // Resulta em OLA Mundo

            Console.WriteLine("Teste".Length); // .Length - o Resultado sera 5 (Coloca em numero quantas letras tem o valor "teste")

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);   /* O ponto de interrogação ? usado em sequencia da variavel
                                                           * evita erro caso o valor da variavel esteja vazio = null */
            
        }
    }
}
