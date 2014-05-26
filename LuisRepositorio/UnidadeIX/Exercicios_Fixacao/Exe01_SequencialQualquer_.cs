using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Fixacao
{

    class Exe01_SequencialQualquer_
    {

        /*1)Na pasta arrays, crie um arquivo chamado SequenciaQualquer.cs. 
        Implemente um programaem C# que armazene 10 números inteiros em um array. 
        Todas as posições do array devem serpreenchidas e o valor armazenado fica à sua escolha. 
        Após preencher o array, exiba os seus valoresno terminal.*/

        static void Main1(string[] args)
        {
            Random gerador = new Random();

            int[] dezValores = new int[10];

            for (int i = 0; i < 10; i++)
            {
                dezValores[i] = gerador.Next(1,11);
            }

            Console.WriteLine("Mostrando os valores informados: ");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Valor " +j +" : " +dezValores[j]);
            }

            Console.ReadKey();
        }
    }
}
