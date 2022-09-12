using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            int hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }
    }
    internal class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.99);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.99),
                new Produto("8ª Temporada de Game of Thrones", 45.99),
                new Produto("Poster", 9.99)
            };

            carrinho.AddRange(combo); // Adiciona vários itens de uma vez só
            Console.WriteLine(carrinho.Count); // Tamanho da lista com o count

            carrinho.RemoveAt(3); // Remove o índice 3

            foreach(var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" - {item.Nome} - R${item.Preco}");
            }
        }
    }
}
