using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exe_Slide_Instrucao_Repeticao
{
    class Repita_5_Vezes
    {
        //07)Repita5Vezes que repita uma mensagem 5 vezes.


        static void Main5(string[] args)
        {
            Console.WriteLine("Imprimindo com 'i' inicializado em 0 +\n");
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Repetindo a frase " +i +" vezes");
            }

            Console.WriteLine("***************************************************************");

            Console.WriteLine("Imprimindo com 'i' inicializado em 1 +\n");
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Repetindo a frase " + i + " vezes");
            }


            Console.WriteLine("***************************************************************");


            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine("Repetindo a frase" + j + "vezes");
                j++;
            }

            Console.WriteLine("***************************************************************");

            int l = 0;
            while (l < 5)
            {
                Console.WriteLine("Repetindo a frase" + l + "vezes");
                l++;
            }



            Console.ReadKey();
        }

    }
}
