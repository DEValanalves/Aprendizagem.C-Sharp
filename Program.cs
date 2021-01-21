using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // FUNDAMENTOS
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar } ,
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar } ,
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar } ,
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar } ,
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar } ,
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar } ,
                
               //ESTRUTURA DE CONTROLE
                {"Estrutura de Controle - Estrutura de Controle", EstruturaIf.Executar } ,


             
                

            });

            central.SelecionarEExecutar();
        }
    }
}