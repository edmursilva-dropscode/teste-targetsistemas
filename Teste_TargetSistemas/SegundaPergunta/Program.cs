using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaPergunta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que insira um número
            Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verifica se o número pertence à sequência de Fibonacci
            bool pertence = VerificarSePertenceAFibonacci(numero);

            // Exibe a mensagem correspondente
            if (pertence)
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");

            // Aguarda o usuário pressionar Enter para encerrar o programa
            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();
        }

        static bool VerificarSePertenceAFibonacci(int num)
        {
            // Inicia os dois primeiros números da sequência de Fibonacci
            int a = 0;
            int b = 1;

            // Caso especial para 0
            if (num == a)
                return true;

            // Loop para gerar os números da sequência até ultrapassar o número fornecido
            while (b <= num)
            {
                // Verifica se o número fornecido está na sequência
                if (b == num)
                    return true;

                // Calcula o próximo número da sequência
                int proximo = a + b;

                // Atualiza os valores de a e b para os próximos cálculos
                a = b;
                b = proximo;
            }

            // Se o número fornecido não foi encontrado na sequência
            return false;
        }
    }
}
