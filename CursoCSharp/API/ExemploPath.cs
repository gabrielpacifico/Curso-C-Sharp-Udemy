using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine("Arquivos");
            Console.WriteLine(Path.GetExtension(arquivo)); // Extensão do arquivo
            Console.WriteLine(Path.GetFileName(arquivo)); // Nome completo do arquivo
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo)); // Nome do arquivo sem extensão
            Console.WriteLine(Path.GetDirectoryName(arquivo)); // Nome do diretório
            Console.WriteLine(Path.HasExtension(arquivo)); // Se tem extensão

            Console.WriteLine("\nPastas");
            Console.WriteLine(Path.HasExtension(pasta)); // Se tem extensão
            Console.WriteLine(Path.GetFullPath(pasta)); // Caminho completo para a pasta
            Console.WriteLine(Path.GetPathRoot(pasta)); // Pasta pai
        }
    }
}
