using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.Exercicios_Fixacao
{
    class Exe01_AcharMaiorMenorElemento
    {
        /*1)	Na pasta problemas, crie um arquivo chamado AcharMaiorMenorElemento.cs. Implemente um programa em C#.*/

        public static void Main1(string[] args)
        {


            double[] numeros = { 14, 25, 3, 1, 5, 6 };

            PosicaoMaior(numeros);
            PosicaoMenor(numeros);


        }





        public static void PosicaoMaior(double[] array)
        {
            int posicaoDoMaior = 0;
            double valor = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[posicaoDoMaior] < array[i])
                {
                    posicaoDoMaior = i;
                    valor = array[i];
                }
            }
            Console.WriteLine("Posicao: " + posicaoDoMaior + " " + "Maior Valor: " + valor);
        }

        public static void PosicaoMenor(double[] array)
        {
            int posicaoDoMenor = 0;
            double valor = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[posicaoDoMenor] > array[i])
                {
                    posicaoDoMenor = i;
                    valor = array[i];
                }
            }
            Console.WriteLine("Posicao: " + posicaoDoMenor + " " + "Menor Valor: " + valor);
        }


    }
}
