using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{ 
    internal class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.99);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.99),
                new Produto("8ª Temporada de Game of Thrones", 45.99),
                new Produto("Poster", 9.99),
                new Produto("Poster", 9.99)
            };

            carrinho.UnionWith(combo); 
            Console.WriteLine(carrinho.Count); 

            // carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
               // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" - {item.Nome} - R${item.Preco}");
            }

            //Console.WriteLine(carrinho.Count);
            //carrinho.Add(livro);
            //Console.WriteLine(carrinho.Count);
        }
    }
}
