﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 23;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos de idade.");

            sicrano.ApresentarNoConsole();  
        }
    }
}
