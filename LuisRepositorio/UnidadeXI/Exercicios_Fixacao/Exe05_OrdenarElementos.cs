using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.Exercicios_Fixacao
{
    class Exe05_OrdenarElementos
    {
        /*5)Na pasta problemas, crie um arquivo chamado OrdenarElementos.cs. Implemente um programa em C#.*/
        public static void Main5()
        {
            int[] numeros = { 15, 1, 7, 89, 2, 0, 14, 26, 8, 542 };

            Ordenar(numeros);

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]); 
            }
        }

        public static void Troca(int[] array, int i, int j)
        {
            int auxiliar = array[i];
            array[i] = array[j];
            array[j] = auxiliar;
        }

        public static int Menor(int[] array, int inicio)
        {
            int menor = inicio;

            for (int i = inicio + 1; i < array.Length; i++)
            {
                if (array[menor] > array[i])
                {
                    menor = i;
                }
            }
            return menor;
        }

        public static void Ordenar(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int menor = Menor(array, i);
                Troca(array, i, menor);
            }
        }

        
    }
}
