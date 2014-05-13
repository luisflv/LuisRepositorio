using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Slides
{
    class Escolhe_Caminho
    {
        static void Main2(string[] args)
        {
            Random gerador = new Random();
            double direcao = gerador.NextDouble() * 10;

            MetodoCaminho(direcao);

            Console.ReadKey();

        }

        public static void MetodoCaminho(double direcao)
        {
            if (direcao > 0.5)
            {
                Console.WriteLine("Siga para direita!");
            }else{
                Console.WriteLine("Siga para a esquerda!");
            }

        }
    }
}
