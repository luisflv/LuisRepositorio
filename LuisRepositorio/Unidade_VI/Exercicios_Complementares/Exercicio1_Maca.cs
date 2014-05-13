using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI
{
    class Exercicio1_Maca
    {
        /*1)	As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
         * e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, 
         * calcule e escreva o valor total da compra.*/


        static void Main(string[] args)
        {
            //
            int quantidade;
            double precoFinal = 0;
            string opcao;

            do
            {
                Console.WriteLine("Informe a quantidade de macas que deseja comprar: ");
                quantidade = int.Parse(Console.ReadLine());

                if (quantidade < 12)
                {
                    precoFinal = quantidade * 0.30;
                }
                else if (quantidade >= 12)
                {
                    precoFinal = quantidade * 0.25;
                }


                Console.WriteLine("Deseja continuar comprando: sim/nao");
                opcao = Console.ReadLine();
            }
            while (opcao.ToLower() != "nao");
            
            Console.WriteLine("O valor final da compra foi de: " +precoFinal);

            Console.ReadKey();

        }
    }
}
