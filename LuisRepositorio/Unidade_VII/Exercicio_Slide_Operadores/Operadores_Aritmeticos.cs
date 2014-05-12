using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class Operadores_Aritmeticos
    {
        static void Main1(string[] args)
        {
            string A = "Luís";
            string B = "Fernando";
            int a = 10;
            int b = 2;
            int c = 3;
            int d = 100;
            double e = 0;

            //Soma
            Console.WriteLine(a + b);
            
            //Subtracao
            Console.WriteLine(a - b);
            
            //Divisao
            Console.WriteLine((a + b)/3);
            
            //Multiplicacao
            Console.WriteLine(a * b *c);
            
            //Mod
            Console.WriteLine(a % b);
            Console.WriteLine(a % c);

            //Utilizando a classe Math (Potenciacao)

            Console.WriteLine(Math.Pow(a, b));

            //Utilizando a classe Math (Raiz)

            Console.WriteLine(Math.Sqrt(d));

            //(Casting)

            Console.WriteLine(e = (double)5 / 2);

            //Concatenacao de Strings

            Console.WriteLine(A +" " +B);



            Console.ReadKey();
        }
    }
}
