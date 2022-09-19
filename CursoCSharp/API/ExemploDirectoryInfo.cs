using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/Curso-C-Sharp-Udemy/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("------ Arquivos ------");
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n------ Diretorios ------");
            var pastas = dirInfo.GetDirectories();
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime); // Data e hora da criação do diretório
            Console.WriteLine(dirInfo.FullName); // Caminho da pasta
            Console.WriteLine(dirInfo.Root); // Diretório raiz
            Console.WriteLine(dirInfo.Parent.Parent); // Pasta pai da pasta pai do diretorio
        }
    }
}
