using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao
{
    /*1)Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever: 
    - o maior preço lido 
    - a média aritmética dos preços dos produtos.*/


    class Exercicio1_Produtos
    {
        static void Main1(string[] args)
        {
            int[] codigo = new int[2];
            double[] preco = new double[15];
            double maiorPreco = 0, somaPreco = 0, media = 0;


            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Informe o codigo: ");
                codigo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o preco do produto: ");
                preco[i] = int.Parse(Console.ReadLine());

                somaPreco += preco[i];
                if (maiorPreco < preco[i])
                {
                    maiorPreco = preco[i];
                }
            }

            media = somaPreco / 15;

            Console.WriteLine("O maior valor digitado foi: " + maiorPreco);
            Console.WriteLine("A media dos valores foi de :" + media);


            Console.ReadKey();

        }
    }
}
