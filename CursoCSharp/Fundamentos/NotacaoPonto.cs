using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World").Replace("World", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Testando".Length);

            /* o símbolo de "?" é uma forma segura de usar a notação ponto, neste caso ele só imprimiria o valor do tamanho(Length) da string caso a
               variável seja iniciada, neste caso é nulo e não ocorre erro. */

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
