using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintaPergunta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String a ser invertida
            string original = "Inverta os caracteres de um string";

            // Chamada da função para inverter a string
            string inverted = InverterString(original);

            // Exibição da string invertida
            Console.WriteLine("String original: " + original);
            Console.WriteLine("String invertida: " + inverted);

            // Aguarda o usuário pressionar Enter para encerrar o programa
            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();
        }

        // Função para inverter a string
        static string InverterString(string str)
        {
            // Converte a string para um array de caracteres
            char[] caracteres = str.ToCharArray();

            // Inverte o array de caracteres
            for (int i = 0, j = caracteres.Length - 1; i < j; i++, j--)
            {
                // Troca os caracteres de posição
                char temp = caracteres[i];
                caracteres[i] = caracteres[j];
                caracteres[j] = temp;
            }

            // Cria uma nova string a partir do array invertido
            string invertida = new string(caracteres);

            // Retorna a string invertida
            return invertida;
        }
    }
}
