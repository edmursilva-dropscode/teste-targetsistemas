using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraPergunta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine(SOMA);

            // Aguarda o usuário pressionar Enter para encerrar o programa
            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
