using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Fixacao
{
    class Exe04_SequencialImpar
    {
        /*4)Na pasta arrays, crie um arquivo chamado SequenciaImpar.cs. 
        Implemente um programa emC# que armazene 10 números inteiros ímparesemumarray. 
        Ao final, exiba no terminal esses valores*/

        static void Main4(string[] args)
        {
            Random gerador = new Random();

            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;
            }

            Console.WriteLine("Imprimindo os valores impares: ");
            for (int j = 0; j < vetor.Length; j++)
            {
                if (vetor[j] % 2 == 0)
                {
                    continue;   
                }
                Console.WriteLine(vetor[j]);
            }

            Console.ReadKey();
        }
    }
}
