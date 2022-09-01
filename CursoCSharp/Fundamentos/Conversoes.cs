using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Convertendo explicitamente double em int, já que não é possivel converter implicitamente
            /* MAIS CONHECIDO COMO CAST, que basicamente é um método na qual um valor
             é convertido de um tipo para outro e pode haver perca de dados */
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.WriteLine("Digite sua idade");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            // TryParse serve para tentar fazer um parse e caso não dê certo vai imprimir o valor zero
            //Método mais longo
            Console.WriteLine("Digite o primeiro número");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"Resultado 1: {numero1}");
            
            // Método mais curto
            Console.WriteLine("Digite o segundo número");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado 2: {numero2}");
        }
    }
}
