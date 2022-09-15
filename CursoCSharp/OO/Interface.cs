using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    public class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    public class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    public class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    public class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";
            
            foreach(var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)} \n";
            }
            return resultado;
        }
    }
    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
