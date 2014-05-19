using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Complementares
{
    class Exe05_
    {
        /*5)Considere um jogo no qual o jogador lança um dado 10 vezes.
        O jogador ganha se a somados valores obtidos nos lançamentos for ímpar. 
        Se o número 6 for sorteado 2 vezes o jogador perde imediatamente. 
        O número 1 deve ser desconsiderado na somatória. 
        Implemente um programa em C# para simular a execução desse jogo*/


        static void Main(string[] args)
        {

            Random gerador = new Random();

            int cont =0;

            int lancamentoDado;
            double soma = 0;

            for (int i = 0; i < 10; i++)
            {
                lancamentoDado = gerador.Next(1,7);

                if (lancamentoDado == 1)
                {
                    continue;
                }

                soma += lancamentoDado;
                
                if (lancamentoDado == 6)
                {
                    cont++;
                }
                if (cont >= 2)
                {
                    Console.WriteLine("Voce perdeu!");
                    break;
                }
            }

            if (soma % 2 == 1)
            {
                Console.WriteLine("Voce ganhou!");
            }

            Console.ReadKey();

        }
        
    }
}
