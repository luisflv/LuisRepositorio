using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Fixacao
{
    class Exe06_TabelaQualquer
    {
        /*6)Na pasta arrays, crie um arquivo chamado TabelaQualquer.cs. 
        Implemente um programa em C# que armazene números inteiros em um array de arrays. 
        Ao final, exiba no terminal esses valores.*/
        
        static void Main6(string[] args)
        {
            Random gerador = new Random();
            
            int[,] matriz = new int[2,5];



            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i,j] = i + j;
                }
            }


            Console.WriteLine("Informando os valores gerados: ");
            for (int k = 0; k < 2; k++)
            {
                for (int l = 0; l < 5; l++)
                {
                    Console.Write(matriz[k,l] + "\t");
                }

           
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
