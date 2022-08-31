using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    { 
        public static void Executar()
        {

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            // Formatando valor monetário para R$ e usando o C2, que significa duas casas após a vírgula
            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2", cultura));

            // Completar a variável até ter 10 caracteres adicionando zeros à esquerda
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
