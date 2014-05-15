using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Slide_Instrucoes_de_Repeticoes
{
    class _13_JogoDeDado2
    {
        static void Main13(string[] args)
        {
            Random gerador = new Random();

            int soma = 0;

            for (int i = 0; i < 4; i++)
            {
                int lancamento = gerador.Next(1,7);
                Console.WriteLine("O valor do lancamento foi: " +lancamento);
                if (lancamento % 2 == 0)
                {
                    continue;
                }
                soma += lancamento;
            }

            Console.WriteLine("A soma foi: " +soma);
            if (soma > 9)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadKey();
        }

    }
}
