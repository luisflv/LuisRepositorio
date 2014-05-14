using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exe_Slide_Instrucao_Repeticao
{
    class _08_ImprimeAteCem
    {
        /*8) Ainda no projeto UNIDADE VIII, crie um exercício chamado Imprime100.
         Implemente um programa que exiba no terminal os números de 1 até 100.*/


        static void Main8(string[] args)
        {
            //Exibindo numeros de 1 ate 100
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }
}
