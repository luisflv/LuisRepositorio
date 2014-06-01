using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.Exercicios_Complementares
{
    class Exe02_VagasEstacionamento
    {
        /*2)  Considere um programa de computador que controla as vagas de um estacionamento. 
        Esse programa deve armazenar em uma tabela (array de arrays) a situação das vagas (ocupada ou livre) por andar.
        Implemente um programa em C# que defina aleatoriamente a situação das vagas de um estacionamento de quatro andares
        numerados de 1 a 4. Considere que a capacidade de cada andaré de 10 vagas. Complete o código a seguir.
        */
        static void Main2(string[] args)
        {
            int[,] andar = new int[4, 10];
            String[] vagas = new String[] { "Ocupada", "Livre" };

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                andar[i, i] = i;
                for (int j = 0; j < 10; j++)
                {
                    andar[i, j] = j;
                    Console.WriteLine("Andar {0}, Vaga {1}, Situação {2} ", i + 1, j + 1, vagas[random.Next(0, 2)]);

                }
            }
        }
    }
}
