using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Complementares
{
    class Exe03_VetorMenorElemento
    {
        /*3)Escreva um algoritmo que leia um vetor de 7 elementos inteiros. 
        Encontre e mostre o menor elemento e sua posição no vetor.
        */
        static void Main(string[] args)
        {
            Random gerador = new Random();

            int[] vetor = new int[7];

            int menor = 200, indice = 0;
            
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(1, 101);
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    indice = i;
                }
            }
            
           Console.WriteLine("O menor elemento do vetor e: " +menor +" : " +indice);
        }
    }
}
