using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class Operadores_Ternario_Inc_Dec
    {
        public static void Main3(string[] args)
        {
            /*
            //Ternario

            string res;

            Console.WriteLine(res = (5 > 6) ? "Este valor e igual" : "Este valor nao e igual");
            Console.WriteLine(res = (5 == 5) ? "Este valor e igual" : "Este valor nao e igual");
            */

            //Pre e Pos incremento

            int a = 10;
            int b = 10;
            Console.WriteLine("Pos-Incremento: " + (a++));
            Console.WriteLine("Pre-Incremento: " + (++a));
            

            //Pre e Pos decremento

            int c = 5;
            int d = 5;
            Console.WriteLine("Pre-decremento: " + (--c));
            Console.WriteLine("Pos-decremento: " + (d--));

            Console.ReadKey();
        }

    }
}
