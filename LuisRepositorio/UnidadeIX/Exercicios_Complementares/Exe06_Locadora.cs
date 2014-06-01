using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Complementares
{
    /*6)Uma locadora de vídeos tem guardada, em um vetor de 50 posições,
    a quantidade de filmes retirados por seus clientes durante o ano de 2004.
    Agora, está locadora está fazendo uma promoção e, para cada 10 filmes retirados,
    o cliente tem direito a uma locação grátis. Faça um algoritmo que crie um outro vetor
    contendo a quantidade de locações gratuitas a que cada cliente tem direito.*/


    class Exe06_Locadora
    {
        static void Main6(string[] args)
        {
            Random gerador = new Random();

            int[] quantidadeRetirada = new int[50];
            int[] quantidadeGratuita = new int[50];

            for (int i = 0; i < quantidadeRetirada.Length; i++)
            {
                quantidadeRetirada[i] = gerador.Next(1, 51);

            }

            for (int i = 0; i < quantidadeGratuita.Length; i++)
            {
                if (quantidadeRetirada[i] >= 10)
                {
                    quantidadeGratuita[i] = 1;
                }
            }

            Console.WriteLine("Quantidade gratuita");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(quantidadeGratuita[i]);
            }
        }
    }
}
