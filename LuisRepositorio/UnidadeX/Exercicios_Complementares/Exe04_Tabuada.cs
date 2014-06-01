using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Complementares
{
    /*4)Faça um método chamado tabuada que passa por parâmetro o número da tabuada. 
    Por exemplo se passar 4 por parâmetro ela deve retornar a tabuada completa do 4.*/

    class Exe04_Tabuada
    {
        static void Main4(string[] args)
        {
            Tabuada(2);
        }

        static void Tabuada(int valor)
        {

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(valor + " x " + i +" : " +(valor * i));
            }
        }
    }
}
