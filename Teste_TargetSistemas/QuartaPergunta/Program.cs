using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartaPergunta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diretório onde o arquivo de texto está localizado
            string diretorio = @"ArquivoTexto";

            // Nome do arquivo de texto
            string nomeArquivo = "Arquivo.txt";

            // Concatena o diretório e o nome do arquivo para obter o caminho completo
            string caminhoArquivo = Path.Combine(diretorio, nomeArquivo);

            try
            {
                // Verifica se o arquivo existe
                if (File.Exists(caminhoArquivo))
                {
                    // Lê o conteúdo do arquivo
                    string conteudo = File.ReadAllText(caminhoArquivo);

                    // Exibe o conteúdo do arquivo
                    Console.WriteLine("Conteúdo do arquivo:");
                    Console.WriteLine(conteudo);
                }
                else
                {
                    Console.WriteLine("O arquivo não foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar ler o arquivo: " + ex.Message);
            }

            // Aguarda o usuário pressionar Enter para encerrar o programa
            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();

        }
    }
}
