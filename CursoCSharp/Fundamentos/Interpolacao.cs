using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook gamer";
            string marca = "Acer";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco + ".");

            // Maneiras de fazer intepolação

            Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, preco );

            Console.WriteLine($"O {nome} da marca {marca} custa R${preco}.");

            Console.WriteLine($"A marca {marca} é de ótima qualidade!");

            Console.WriteLine($"4 + 8 = {4 + 8}!");
        }
    }
}
