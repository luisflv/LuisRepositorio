using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Complementares
{
    class Exe01_GerarGabarito
    {
        /*1)Considere um programa de computador que corrige provas de múltipla escolha. 
        Esse programa deve armazenar em um array o gabarito de uma prova.
        Implemente um programa em C# que gere aleatoriamente o gabarito de uma prova com
        10 questões de múltipla escolha. Considere que cada questão possui três alternativas numeradas de 1 a 3.
        Complete o código a seguir.
        */

        static void Main1(string[] args)
        {
            Random random = new Random();

            int[] gabarito = new int[10];
            int[] alternativa = new int[3];

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Questão {0} ", i);
                for (int j = 1; j <= 1; j++)
                {
                    alternativa[j] = random.Next(1, 4);
                    Console.WriteLine("Alternativa Correta {0} ", alternativa[j]);
                }
            }
        }

    }
}
