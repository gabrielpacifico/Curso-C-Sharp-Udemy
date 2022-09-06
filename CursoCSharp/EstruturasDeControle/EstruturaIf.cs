using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;
            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();

            double.TryParse(entrada, out double nota);
            Console.WriteLine("Possui um bom comportamento? (S/N):");

            entrada = Console.ReadLine();

            //if(entrada == "S" || entrada == "s")
            //{
            //    bomComportamento = true;
            //}

            // Funciona do mesmo jeito que a condicional if acima
            bomComportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
