using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Complementares
{
    class Exe07_AB
    {
        /*7)Faça um algoritmo que leia dois vetores (A e B) de 50 posições de números inteiros. 
        O algoritmo deve, então, subtrair o primeiro elemento de A do último de B,acumulando o valor,
       subtrair o segundo elemento de A do penúltimo de B,acumulando o valor, e assim por diante. 
       Mostre o resultado da soma final.*/

        public static void Main7(string[] args)
        {
            int[] A = new int[50];
            int[] B = new int[50];
            int[] res = new int[50];

            for (int i = 0; i < 50; i++)
            {
                A[i] = i;
                B[i] = i;
                for (int j = 49; j >= 0; j--)
                {

                    res[j] = A[i] - B[j];
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(i + " : " + res[i]);
            }

        }
    }
}
