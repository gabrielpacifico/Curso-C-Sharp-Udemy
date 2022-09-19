using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine("O intervalo é de: " + intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em minutos: " + intervalo.TotalMinutes); // Intervalo total em minutos.

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo); // O tipo da variável tempo será TimeSpan, pois houve intervalo entre dois DateTimes.

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8))); // Cria um novo TimeSpan, ao invés de substituir.
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8))); // Subtrai da variável inicial(intervalo), ignorando a adição na linha anterior.

            Console.WriteLine("ToString 1: " + intervalo.ToString("g")); // Formato padrão sem milissegundos
            Console.WriteLine("ToString 2: " + intervalo.ToString("G")); // Exibe milissegundos
            Console.WriteLine("ToString 3: " + intervalo.ToString("c")); // Usa o ponto como separador de dia e hora 

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}
