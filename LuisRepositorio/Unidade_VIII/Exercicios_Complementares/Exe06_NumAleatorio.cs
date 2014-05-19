using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Complementares
{
    class Exe06_NumAleatorio
    {
        /*6) Crie um programa em C# que gere e exiba no terminal um número aleatório. 
        Além disso, esse programa deve contabilizar a quantidade de dígitos “1” do número 
        aleatório e exibir essa quantidadeno terminal. Complete o código abaixo*/

        static void Main(string[] args)
        {
            Random gerador = new Random();

            int numero, cont = 0;

            for (int i = 0; i < 30; i++)
            {
                numero = gerador.Next(1, 10);

                if (numero == 1)
                {
                    cont++;
                }
            }

            Console.WriteLine("O total de numeros '1' gerado foi de : {0}", cont);
            Console.ReadKey();
        }

    }
}
