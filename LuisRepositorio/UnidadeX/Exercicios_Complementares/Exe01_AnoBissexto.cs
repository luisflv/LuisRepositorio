using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Complementares
{
    /*1)	Implemente um método que determina seu ano é ou não é bissexto. As regras para determinar se um ano é bissexto são:
    1. Anos múltiplos de 4 são bissextos.
    2. Anos múltiplos de 100 não são bissextos.
    3. Anos múltiplos de 400 são bissextos.
    4. As últimas regras prevalecem sobre as primeiras.*/


    class Exe01_AnoBissexto
    {
        static void Main1(string[] args)
        {
            verifica(2014);
        }

        static void verifica(int ano)
        {
            if ((ano % 4 == 0) && (ano % 400 == 0) && (ano % 100 == 1))
            {
                Console.WriteLine("Estes ano e bissexto!");
            }
            else 
            {
                Console.WriteLine("Nao e bissexto!");
            }
        }
    }
}
