using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao
{
    /*3)Uma loja está levantando o valor total de todas as mercadorias em estoque. 
    Escreva um algoritmo que permita a entrada das seguintes informações: 
    a) o número total de mercadorias no estoque; 
    b) o valor de cada mercadoria. Ao final imprimir o valor total em estoque e a 
    média de valor das mercadorias.*/

    class Exercicio3_Loja
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o numero total de mercadorias em estoque: ");
            int numTotal = int.Parse(Console.ReadLine());

            double[] valor = new double[numTotal];

            double valorTotalEstoque = 0, media = 0;

            for (int i = 0; i < numTotal; i++)
            {
                Console.WriteLine("Informe o valor da mercadoria: ");
                valor[i] = double.Parse(Console.ReadLine());

                valorTotalEstoque += valor[i];

            }

            media = valorTotalEstoque / numTotal;

            Console.WriteLine("O valor total em estoque e de: " + valorTotalEstoque);
            Console.WriteLine("A media dos valores em estoque e de: " + media);

            Console.ReadKey();
        }
    }
}
