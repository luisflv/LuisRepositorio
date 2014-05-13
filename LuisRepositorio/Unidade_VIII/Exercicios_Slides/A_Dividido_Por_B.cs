using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Slides
{
    class A_Dividido_Por_B
    {
        static void Main(string[] args)
        {
            
            Random gerador = new Random();
            double a = gerador.NextDouble();
            double b = gerador.NextDouble();

            double result;
            result = MetodoDivide(a, b);

            Console.WriteLine("O resultado foi: {0:F2}", +result);
        }

        public static double MetodoDivide(double a, double b)
        {
            double valor = 0;
            
            if (b == 0)
            {
                Console.WriteLine("Não e possivel realizar a divisao!");
            }
            else
            {
                valor = a / b; 
                    return valor;
            }
            return 0;
        }


    }
}
