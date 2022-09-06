using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class CalculadoraEstatica
    {
        // Static pode ser acessado diretamente pela classe, sem o static precisa fazer uma instância para acesso
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }    
    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro número para a multiplicação");
            string input1 = Console.ReadLine();
            int num1;
            int.TryParse(input1, out num1);

            Console.WriteLine("Digite o segundo número para a multiplicação"); 
            string input2 = Console.ReadLine();
            int num2;
            int.TryParse(input2, out num2);

            var resultado = CalculadoraEstatica.Multiplicar(num1, num2);
            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
