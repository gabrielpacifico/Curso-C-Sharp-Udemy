using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 2.6;
            const double PI = 3.14;
            
            double area = PI * raio * raio;
            Console.WriteLine(area);

            Console.WriteLine("A área é: " + area);

            // Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor inteiros " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1599.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor apple" + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'a';
            Console.WriteLine("Letra " + letra);

            string bemVindo = "Seja bem vindo";
            Console.WriteLine(bemVindo);
                ;

        }
    }
}
