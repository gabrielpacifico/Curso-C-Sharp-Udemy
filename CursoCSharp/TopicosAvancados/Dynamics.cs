using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.Nome = "Maria Julia";
            aluno.Idade = 18;
            aluno.Nota = 6.7;

            Console.WriteLine($"{aluno.Nome} {aluno.Idade} {aluno.Nota}");
        }
    }
}
