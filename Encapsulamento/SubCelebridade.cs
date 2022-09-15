using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Herança
        protected string CorDoOlho = "Verde";

        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 88997621324;

        // Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Mesma classe ou herança do mesmo projeto
        private protected string SegredoFamilia = "Segredo...";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
