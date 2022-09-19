using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome( this string path)
        {
            // Encontrando a pasta users em Linux, MacOSx e Windows. Após encontrar substitui o símbolo "~" pelo nome do diretório.
            string home = (Environment.OSVersion.Platform == PlatformID.Unix) || (Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) // Criando arquivo no diretório Users do sistema (path).
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro arquivo");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) // Modificando (append) o mesmo arquivo.
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto");
            }
        }
    }
}
