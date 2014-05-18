using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Slides
{
    class Escolhe_Roupa
    {
        static void Main3(string[] args)
        {

            Random gerador = new Random();
            double escolha = gerador.NextDouble() * 10;

            MetodoEscolhe(escolha);
            
            Console.ReadKey();

        }

        public static void MetodoEscolhe(double escolha)
        {
            if (escolha > 0.5)
            {
                Console.WriteLine("Vista uma camisa vermelha!");
            }
            else
            {
                Console.WriteLine("Vista uma blusa azul");
            }
        }


    }
}
