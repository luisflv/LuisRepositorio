using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Slides
{
    class Verifica_Valor_Produto
    {

        static void Main4(string[] args)
        {
            Random gerador = new Random();
            double valor = gerador.NextDouble() * 10;

            verificaValor(valor);
        }

        public static void verificaValor(double valor)
        {
            if (valor > 0.5)
            {
                Console.WriteLine("O valor do produto foi: {0:F1}", +valor);
                Console.WriteLine("O preco e caro!");
            }
            else if (valor < 0.5)
            {
                Console.WriteLine("O valor do produto foi: {0:F1}", +valor);
                Console.WriteLine("O preco esta em conta!");
            }
        }

    }



}
