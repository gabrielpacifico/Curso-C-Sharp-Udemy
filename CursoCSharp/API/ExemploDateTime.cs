using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 08, day: 23);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minuto: " + diaAtual.Minute);
            Console.WriteLine("Segundos: " + diaAtual.Second);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine("Amanha: " + amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine("Ontem: " + ontem);

            Console.WriteLine(diaAtual.ToString("dd")); // Exibe apenas o dia
            Console.WriteLine(diaAtual.ToString("d")); // Exibe dia, mês e ano
            Console.WriteLine(diaAtual.ToString("D")); // Exibe dia, mês e ano por extenso
            Console.WriteLine(diaAtual.ToString("g")); // Exibe data e hora, mas sem segundos
            Console.WriteLine(diaAtual.ToString("G")); // Exibe data e hora, com segundos
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH-mm")); // Formato personalizado 
        }
    }
}
