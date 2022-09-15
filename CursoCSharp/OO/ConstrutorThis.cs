using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }
   
        public class Cachorro : Animal
        {
            public double Altura { get; set; }

            public Cachorro(string nome) : base(nome)
            {
                Console.WriteLine($"O cachoro {nome} inicializado");
            }

            public Cachorro(string nome, double altura) : this(nome)
            {
                Altura = altura;
            }

        public override string ToString()  // Converte para string, sem essa função quando fosse para o console.write ficaria o nome da classe, e não a string das infomações do cachorro.
        {
            return $"O {Nome} tem {Altura}cm de altura.";
        }
    }
    
    internal class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var jax = new Cachorro("Jax", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(jax);
        }
    }
}
