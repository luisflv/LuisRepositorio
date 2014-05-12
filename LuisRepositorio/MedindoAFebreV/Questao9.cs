using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Questao9
    {
        static void Main3(string[] args)
        {
            int quantidadeProd;
            double precoProd, total = 0, totalPagar = 0;
            string nomeProd;

            Console.WriteLine("Informe o nome do produto: ");
            nomeProd = Console.ReadLine();

            Console.WriteLine("Informe o preco do produto: ");
            precoProd = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade do produto: ");
            quantidadeProd = int.Parse(Console.ReadLine());

            total = quantidadeProd * precoProd;

            if (quantidadeProd <= 5)
            {
                totalPagar = total - (total * 0.02);
                Console.WriteLine("Você teve um desconto de 2%");
                Console.WriteLine("O valor final a ser pago e de: " + totalPagar);
            }
            else if ((quantidadeProd > 5) && (quantidadeProd <= 10))
            {
                totalPagar = total - (total * 0.03);
                Console.WriteLine("Você teve um desconto de 3%");
                Console.WriteLine("O valor final a ser pago e de: " + totalPagar);
            }
            else if (quantidadeProd > 10)
            {
                totalPagar = total - (total * 0.05);
                Console.WriteLine("Você teve um desconto de 5%");
                Console.WriteLine("O valor final a ser pago e de: " + totalPagar);
            }

            Console.ReadKey();
        }
    }
}
