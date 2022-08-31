using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Segundo Programa - Comentários", Comentarios.Executar},
                {"Terceiro Programa - Variáveis e constantes", VariaveisEConstantes.Executar},
                {"Quarto Programa - Inferência", Inferencia.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}