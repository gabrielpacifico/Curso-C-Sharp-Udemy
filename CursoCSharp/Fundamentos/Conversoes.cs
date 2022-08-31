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
            // MAIS CONHECIDO COMO CAST, que basicamente é um método na qual um valor é convertido de um tipo para outro e pode haver perca de dados
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");
        }
    }
}
