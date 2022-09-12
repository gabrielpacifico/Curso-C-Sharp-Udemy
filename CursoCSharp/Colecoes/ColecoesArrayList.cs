﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {
                "Palavra",
                4,
                true
            };

            arraylist.Add(3.14);
            foreach(var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType()); // GetType pega o tipo da variável
            }
        }
    }
}