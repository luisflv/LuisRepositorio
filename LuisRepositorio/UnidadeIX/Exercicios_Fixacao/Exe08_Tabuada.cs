using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Fixacao
{
    class Exe08_Tabuada
    {
        /*8)	Na pasta arrays, crie um arquivo chamado Tabuada.cs.
        Implemente umprograma em C# que armazene números inteiros em um array de arrays. 
        Ao final, exiba no terminal esses valores.*/

        static void Main8(string[] args)
        {

            int[,] tabuada = new int[10,11];

            for (int i = 1; i < 10; i++)
            {
            for (int j = 0; j < 11; j++)
                {
                    tabuada[i, j] = i * j;
                }
            }


            for (int i = 1; i <= 10; i++)
            {
            for (int j = 0; j < 11; j++)
                {
                 Console.WriteLine(i +" X " +j +" : " +tabuada[i,j]);   
                }
            }


        }

    }
}
