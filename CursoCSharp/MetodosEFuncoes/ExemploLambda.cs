using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>   // Action o retorno é void e só pode ser passado um único tipo de parâmetro 
            {
                Console.WriteLine("Lambda com c#");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero =>  // Func pode passar vários tipos de parâmetros e o último é o tipo de retorno.
            {
                return numero.ToString("X");
            };
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            
            Console.WriteLine(formatarData(3,12,2019));
        }
    }
}
