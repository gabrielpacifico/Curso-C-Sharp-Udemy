using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametroPadrao
    {

        public static int Somar(int a = 1, int b  = 1)
        {
            return a + b;
        }
        public static void Executar()
        {
            /* Caso nao tenha sido passado valor, será assumido o valor padrão definido na classe Somar. Caso haja valor
            será substituido o valor padrão pelo valor passado. */

            Console.WriteLine(Somar(10,23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7));
        }
    }
}
