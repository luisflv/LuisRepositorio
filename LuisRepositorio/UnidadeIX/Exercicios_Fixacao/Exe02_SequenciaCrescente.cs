using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Fixacao
{
    class Exe02_SequenciaCrescente
    {
        /*2)Na pasta arrays, crie um arquivo chamado SequenciaCrescente.cs. 
        Implemente um programa em C# que armazene 10 números inteiros em um array. 
       Preencha todas as posições do array com valores sequenciais. 
       Ao final, exiba no terminal esses valores.*/

        static void Main2(string[] args)
        {

            int[] valores = new int[10];

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = i;
            }

            Console.WriteLine("Mostrando os valores em ordem crescente: ");
            for (int j = 0; j < valores.Length; j++)
            {
                Console.WriteLine(valores[j]);
            }

            Console.ReadKey();

        }

    }
}
