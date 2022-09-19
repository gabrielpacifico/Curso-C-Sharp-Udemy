using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia); // Se algum arquivo existir, exclui antes de criar novamente.

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original");
            }
            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name); // Nome do arquivo.
            Console.WriteLine(origem.IsReadOnly); // Se é apenas leitura
            Console.WriteLine(origem.FullName); // Caminho do diretorio
            Console.WriteLine(origem.Extension); // Tipo te extensão
            Console.WriteLine(origem.Directory); // Nome do diretório(pasta) onde está localizado

            origem.CopyTo(caminhoCopia); // Copia para ().
            origem.MoveTo(caminhoDestino); // Move para ().
        }
    }
}
