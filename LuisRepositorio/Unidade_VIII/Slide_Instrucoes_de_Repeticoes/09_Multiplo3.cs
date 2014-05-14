using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exe_Slide_Instrucao_Repeticao
{
    //9) Ainda no projeto UNIDADE VIII, crie um exercício chamado Imprime100ExcetoMultiplo3


    class _09_Multiplo3
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <=100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

        }
    }
}
