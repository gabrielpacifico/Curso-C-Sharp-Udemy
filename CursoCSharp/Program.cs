using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                // Estruturas de controle
                {"Estrutura If - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else If - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de controle", EstruturaForeach.Executar},
                {"Usando Break - Estruturas de controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controle", UsandoContinue.Executar},
                // Classes e métodos
                {"Membros - Classes e métodos", Membros.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e métodos", DesafioAtributo.Executar},
                {"Params - Classes e métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e métodos", GetSet.Executar},
                {"Props - Classes e métodos", Props.Executar},
                {"Readonly - Classes e métodos", Readonly.Executar},
                {"Enum - Classes e métodos", ExemploEnum.Executar},
                {"Struct - Classes e métodos", Struct.Executar},
                {"Struct Vs Classe - Classes e métodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes e métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro Padrão - Classes e métodos", ParametroPadrao.Executar},
                // Coleções
                {"Array - Coleções ", Arrays.Executar},
                {"List - Coleções ", ColecoesList.Executar},
                {"Array List - Coleções ", ColecoesArrayList.Executar},
                {"Set - Coleções ", ColecoesSet.Executar},
                {"Queue - Coleções ", ColecoesQueue.Executar},
                {"Igualdade - Coleções ", Igualdade.Executar},
                {"Stack - Coleções ", ColecoesStack.Executar},
                {"Dicionario - Coleções ", ColecoesDicionario.Executar},
                // OO
                {"Herança - Orientação à objetos ", Heranca.Executar},
                {"Construtor This - Orientação à objetos ", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação à objetos ", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação à objetos ", Polimorfismo.Executar},
                {"Abstract - Orientação à objetos ", Abstract.Executar},
                {"Interface - Orientação à objetos ", Interface.Executar},
                {"Sealed - Orientação à objetos ", Sealed.Executar},
                // Métodos e funções
                {"Lambda - Métodos e funções", ExemploLambda.Executar},
                {"Lambdas como delegate - Métodos e funções", LambdasDelegate.Executar},
                {"Usando delegate - Métodos e funções", UsandoDelegate.Executar},
                {"Delegate com função anônima - Métodos e funções", DelegateFunAnonima.Executar},
                {"Delegate com parâmetros - Métodos e funções", DelegatesComParametro.Executar},
                {"Delegate de extensão - Métodos e funções", MetodosDeExtensao.Executar},
                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExecao.Executar},
                {"Exceções personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                // API
                {"Primeiro arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretorios - Usando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},
                // Tópicos avançados
                {"LINQ - Tópicos avançados", LINQ1.Executar},
                {"LINQ2 - Tópicos avançados", LINQ2.Executar},
                {"Nullables - Tópicos avançados", Nullables.Executar},
                {"Dynamics - Tópicos avançados", Dynamics.Executar},
                {"Genericos - Tópicos avançados", Genericos.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}