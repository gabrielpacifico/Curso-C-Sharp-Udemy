using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDicionario
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); // Não aceita repetição na chave(int) e aceita repetição no valor(string).

            filmes.Add(2000, "Gladiador");
            filmes.Add(2004, "Os incríveis");
            filmes.Add(2010, "Os pinguins de Madagascar");
            filmes.Add(2007, "Piradas do Caribe");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
            }
            Console.WriteLine(filmes.ContainsValue("Amnesia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2007, out string filme2007);
            Console.WriteLine($"Filme: {filme2007}");

            foreach(var chave in filmes.Keys)
            {
                Console.WriteLine(chave); // Percorrendo chaves do dicionário (Anos/int)
            }

            foreach(var valor in filmes.Values)
            {
                Console.WriteLine(valor); // Percorrendo valores do dicionário (Nomes/string)
            }

            foreach (KeyValuePair<int, string> filme in filmes) { // Percorrendo chave e valor ao mesmo tempo com KeyValuePair.
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
