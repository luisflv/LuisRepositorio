using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Fixacao
{
    class Exe03_SequencialDecrescente
    {
        /*3)Na pasta arrays, crie um arquivo chamado SequenciaDecrescente.cs.
        Implemente um programaem C# que armazene 10 números inteiros em um array. 
        Preencha todas as posições do array com valores sequenciais descrescentes. 
        Ao final, exiba no terminal esses valores.*/

        static void Main3(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;
            }


            Console.WriteLine("Mostrando os valores em ordem decrescente: ");
            for (int j = 9; j >= 0; j--)
            {
                Console.WriteLine(vetor[j]);
            }
            Console.ReadKey();
        }
    }
}
