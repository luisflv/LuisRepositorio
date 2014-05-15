using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Complementares
{
    class Exe04_Tabuada
    {
       /*4)Escreva um programa em C# que exiba no terminal a tabuada dos números 
       de 1 a 10 de acordo com o padrão abaixo.
       1x1 = 1
       1x2 = 2
       1x3 = 3
       ...
       10x8 = 80
       10x9 = 90
       10x10 = 100*/



        static void Main4(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i +"x" +j +": "+(i*j));
                }  
            }
        }
    }

}
