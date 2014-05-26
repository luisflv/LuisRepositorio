using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Fixacao
{
    class Exe05_SequenciaAleatoria
    {
        /*5)Na pasta arrays, crie um arquivo chamado SequenciaAleatoria.cs. 
        Implemente um programa em C# que armazene 10 números inteiros aleatórios em um array. 
        Ao final, exiba no terminal esses valores. */
        
        static void Main5(string[] args)
        {
            Random gerador = new Random();

            int[] dezValores = new int[10];

            for (int i = 0; i < 10; i++)
            {
                dezValores[i] = gerador.Next(1, 11);
            }

            Console.WriteLine("Mostrando os valores informados: ");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Valor " + j + " : " + dezValores[j]);
            }

            Console.ReadKey();
        }
    }
}
