using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{

    internal class Arrays
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Gabriel";
            alunos[1] = "Matheus";
            alunos[2] = "Daniel";
            alunos[3] = "Ana";
            alunos[4] = "José";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 5.6, 7.9, 4.2, 8.0 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'a', 'B', 'b', 'C', 'c' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
