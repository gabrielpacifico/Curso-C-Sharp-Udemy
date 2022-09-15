using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.OO.Avo;

namespace CursoCSharp.OO
{

sealed class SemFilho
    {
        public double ValorFortuna()
        {
            return 1_423_092.65;
        }
    }
    //public class SouFilho : SemFilho
    //{

    //}
    public class Avo
    {
        public virtual bool HonrarNomeDaFamilia()
        {
            return true;
        }
        public class Pai : Avo
        {
            public sealed override bool HonrarNomeDaFamilia()
            {
                return true;
            }
        }
        public class FilhoRebelde : Pai
        {
            //public override bool HonrarNomeDaFamilia()
            //{
            //    return false;
            //}
        }
    }
    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeDaFamilia());


        }
    }
}
