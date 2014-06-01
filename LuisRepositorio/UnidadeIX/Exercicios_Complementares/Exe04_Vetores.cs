using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Complementares
{
    /*4)  Escreva um algoritmo que leia um vetor inteiro de 12 posições e crie um segundo vetor, 
    substituindo os valores nulos por 1. Mostre os 2 vetores.*/

    class Exe04_Vetores
    {
        public static void Main4(string[] args)
        {
            int[] vet = new int[12];
            int[] novoVet = new int[12];

            Random gerador = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = gerador.Next(0, 2);
                Console.WriteLine(vet[i]);


            }
            Console.WriteLine("**************");

            for (int i = 0; i < novoVet.Length; i++)
            {
                if (vet[i] == 0)
                {
                    vet[i] = 1;

                }

                novoVet[i] = vet[i];
                Console.WriteLine(novoVet[i]);
            }
        }
    }
}
