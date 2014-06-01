using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Complementares
{
    class Exe08_Loteria
    {
        /*8)Escreva um algoritmo que leia um vetor de 13 elementos inteiros, 
        que é o Gabarito de um teste da loteria esportiva, contendo os valores 1(coluna 1),
        2 (coluna 2) e 3(coluna do meio). Leia, a seguir, para cada apostador, o número do seu 
        cartão e um vetor de Respostas de 13 posições. Verifique para cada apostador os números de acertos,
        comparando o vetor de Gabarito com o vetor de Respostas. Escreva o númerodo apostador e o número de acertos.
        Se o apostador tiver 13 acertos, mostrar amensagem "Ganhador".*/

        static void Main8(string[] args)
        {
            Random random = new Random();
            int contCerto = 0;
            int[] gabarito = new int[13];
            int[,] aposta = new int[3, 13];


            for (int i = 0; i < 13; i++)
            {
                gabarito[i] = random.Next();
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    aposta[i, j] = random.Next();
                    if (aposta[i, j] == gabarito[i])
                    {
                        contCerto++;
                    }


                }
                if (contCerto == 13)
                {
                    Console.WriteLine("Jogador na posição: " + i + " Você ganhou " + contCerto);
                }
                else
                {
                    Console.WriteLine("Jogador na posição: " + i + " Você perdeu " + contCerto);
                }
            }
        }

    }
}
