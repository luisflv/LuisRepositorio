using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.Exercicios_Fixacao
{
    class Exe03_MediaElementos
    {
        /*3)Na pasta problemas, crie um arquivo chamado MediaElementos.cs. Implemente um programaem C#.*/

        public static void Main3(string[] args)
        {
            double[] numeros = {10,10,15};

            double a = MediaVetor(numeros);
            Console.WriteLine("A media dos valores e: " +a);
            

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

        public static double MediaVetor(double[] array)
        {
            double soma = SomaVetor(array);
            double media = soma / array.Length;

            return media;
        }

    }
}
