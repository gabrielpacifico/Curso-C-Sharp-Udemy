using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 += 10;
            num1 -= 2;
            num1 *= 4;
            num1 /= 2;
            Console.WriteLine($"O número é: {num1}");
        }
    }
}
