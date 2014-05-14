using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Slide_Instrucoes_de_Repeticoes
{
    class _12_JogoDeDado
    {
        static void Main12(string[] args)
        {
            Random gerador = new Random();

            int soma = 0;

            for (int i = 0; i < 5; i++)
            {
                int lancamento = gerador.Next(1,7);
                Console.WriteLine("Valor do lancamento: : " +lancamento);
                soma += lancamento;
           
            }

            
            Console.WriteLine("O valor da soma foi : {0}", soma);
            if (soma > 19)
            {
                Console.WriteLine("Você ganhou! =)");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }

            Console.ReadKey();

        }

    }
}
