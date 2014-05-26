using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Fixacao
{
    class Exe07_TabelaAleatoria
    {
        /*7)	Na pasta arrays, crie um arquivo chamado TabelaAleatoria.cs. 7
        Implemente um programa emC# que armazene números inteiros em um array de arrays. 
        Ao final, exiba no terminal esses valores.*/


        static void Main7(string[] args)
        {
            Random gerador = new Random();

            int[,] matriz = new int[2, 5];



            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = gerador.Next(1,16);
                }
            }


            Console.WriteLine("Informando os valores gerados: ");
            for (int k = 0; k < 2; k++)
            {
                for (int l = 0; l < 5; l++)
                {
                    Console.Write(matriz[k, l] + "\t");
                }


                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
