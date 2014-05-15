using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Complementares
{
    /*1)Crie um programa em C# que gere dois números aleatórios e exiba o valor desses números.Além disso, 
    esse programa deve exibir a mensagem “Primeiro > Segundo” se o primeiro número formaior do que o segundo, 
    a mensagem “Segundo > Primeiro” se o segundo número for maior do queo primeiro e mensagem 
    “Primeiro = Segundo” se o primeiro número for igual ao segundo.*/ 

    class Exe01_
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();

            int primeiro = gerador.Next(1, 11);
            int segundo = gerador.Next(1, 11);

            Console.WriteLine("O valor do primeiro e: " +primeiro) ;
            Console.WriteLine("O valor do segundo e: " +segundo);

            if (primeiro > segundo)
            {
                Console.WriteLine("Primeiro > Segundo");


            }
            else if (primeiro == segundo)
            {
                Console.WriteLine("Primeiro == Segundo");
            }else
            {
                Console.WriteLine("Segundo > Primeiro");
            }
            Console.ReadKey();
        }
    }
}
