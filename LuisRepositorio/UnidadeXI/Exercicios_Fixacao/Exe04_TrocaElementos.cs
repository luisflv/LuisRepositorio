using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.Exercicios_Fixacao
{
    class Exe04_TrocaElementos
    {
        /*4)Na pasta problemas, crie um arquivo chamado TrocaElementos.cs. Implemente um programaem C#.*/

        public static void Main4(string[] args)
        {

            int[] numeros = { 15, 18, 26, 1, 46 };

            TrocaElemento(numeros, 0,1);

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            

        }

        public static void TrocaElemento(int[] vet, int posicaoA, int posicaoB)
        {
            int aux;
            
            for (int i = 0; i < vet.Length; i++)
            {
                aux = vet[posicaoA];
                vet[posicaoA] = vet[posicaoB];
                vet[posicaoB] = aux;
            }
        }

    }
}
