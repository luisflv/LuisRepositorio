using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class Operadores_Atrib_Log_Rela
    {
        public static void Main2(string[] args)
        {
            //Atribuicao

            double adicao = 2, subtracao = 4, multiplicacao = 3, divisao = 15, mod = 10;
            int incremento = 0, decremento = 3;

            Console.WriteLine("Adicao        :  (2 + 2) : " + (adicao += 2));
            Console.WriteLine("Subtracao     :  (4 - 2) : " + (subtracao -= 2));
            Console.WriteLine("Multiplicacao :  (3 * 3) : " + (multiplicacao *= 3));
            Console.WriteLine("Divisao       : (15 / 2) : " + (divisao /= 2));
            Console.WriteLine("Mod           : (10 % 3) : " + (mod % 3));
            Console.WriteLine("Incremento    : incremento++      : " +(incremento++));
            Console.WriteLine("Decremento    : decremento++      : " + (decremento--));

            //********************************************************************************

            //Relacional

            double valor = 0;
            bool res;

            Console.WriteLine("Maior        : " + (res = valor > 2));
            Console.WriteLine("Menor        : " + (res = valor < 3));
            Console.WriteLine("Maior igual  : " + (res = valor >= 2));
            Console.WriteLine("Menor igual  : " + (res = valor <= 2));
            Console.WriteLine("Igual        : " + (res = valor == 2));
            Console.WriteLine("Diferente    : " + (res = valor != 2));

            //********************************************************************************

            //Lógico

            int a = 2, b = 5;
            bool result;

            Console.WriteLine("& Simples :  " + (result = a > b & b < a));
            Console.WriteLine("&& Duplo  :  " + (result = a < b && b < a));
            Console.WriteLine("| Simples :  " + (result = a == b | b < a));
            Console.WriteLine("|| Duplo  :  " + (result = a != b || b < a));
            Console.WriteLine("Xor       :  " + (result = a > b ^ b <= a));
            
        }
    }
}
