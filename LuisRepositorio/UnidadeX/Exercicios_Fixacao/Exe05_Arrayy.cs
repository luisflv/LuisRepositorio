using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Fixacao
{
    /*5)Na pasta funcoes-ou-metodos, crie umarquivo chamado Arrays.cs. 
    Implemente umprogramaem C# definindo um método que preencha umarray 
   comnúmeros inteiros aleatórios no intervalo de 0 a 99 e outro que exiba 
   no terminal os valores armazenados em um array.*/

    class Exe05_Arrayy
    {
        static void Main5(string[] args)
        {

            int[] vet = new int[100];

            insereValor(vet);
            imprimeVetor(vet);

        }

        static void insereValor(int[] vetor)
        {
            Random gerador = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(0, 100);
            }
        }

        static void imprimeVetor(int[] vetor)
        {
            Console.WriteLine("Valores do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }

}
