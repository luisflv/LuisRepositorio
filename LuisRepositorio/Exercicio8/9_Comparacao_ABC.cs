using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI
{
    public class Exercicio9
    {   //
        /*9) Faça um algoritmo que leia os valores A, B e C. Mostre uma mensagem que 
        informe se a soma de A com B é menor, maior ou igual a C.*/

        public static void Main9(string[] args)
        {
            //Opa

            double a, b, c, soma;

            Console.WriteLine("Informe o valor de A :");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B :");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C :");
            c = double.Parse(Console.ReadLine());

            soma = a + b;

            if (soma > c)
            {
                Console.WriteLine("A soma de A e B é maior que o valor de C");
            }
            else if (soma < c)
            {
                Console.WriteLine("A soma de A e B é menor que o valor de C");
            }
            else if (soma == c)
            {
                Console.WriteLine("A soma de A e B é igual ao valor de C");
            }

            Console.ReadKey();



        }

    }

}
