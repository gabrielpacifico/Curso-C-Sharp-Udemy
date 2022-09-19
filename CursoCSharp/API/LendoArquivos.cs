using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path)) // Criando arquivo.
                {
                    sw.WriteLine("Produto;Preço;Quantidade");
                    sw.WriteLine("Caneta Bic Preta;3.45;59");
                    sw.WriteLine("Borracha Branca;4.45;75");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path)) // Ler arquivo criado.
                {
                    var text = sr.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

