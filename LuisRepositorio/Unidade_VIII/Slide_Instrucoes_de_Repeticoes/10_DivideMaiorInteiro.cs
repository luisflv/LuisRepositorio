using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exe_Slide_Instrucao_Repeticao
{
    class DivideMaiorInteiro
    {
        static void Main10(string[] args)
        {
            int numero = 2147483647;

            while (numero > 100)
            {
                numero = numero / 2;
                Console.WriteLine("Os resultados : " +numero);
            }
            
            Console.ReadKey();
        }
    }
    
}
