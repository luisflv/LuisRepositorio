using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.Exercicios_Fixacao
{
    class Exe02_SomaElementos
    {
        /*2)Na pasta problemas, crie um arquivo chamado SomaElementos.cs. Implemente um programa em C#.*/
        public static void Main2(string[] args)
        {
            double[] numeros = { 15, 15 };
            double a = SomaVetor(numeros);
            Console.WriteLine(a);
        }


        public static double SomaVetor(double[] vet)
        {
            double resultadoSoma = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                resultadoSoma += vet[i];
            }
            return resultadoSoma;
        }
    }
}
