using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    /*10) Uma pessoa comprou quatro artigos em uma loja. Para cada artigo, tem-se 
     nome, preço e percentual de desconto. Faça um algoritmo que imprima nome, 
     preço e preço com desconto de cada artigo e o total a pagar.*/

    public class Exercicio10
    {
        static string a1, a2, a3, a4;
        static double preco, preco1, preco2, preco3, preco4;
        static double desconto;


        static void Main10(string[] args)
        {

            Console.WriteLine("Informe o nome do primeiro artigo: ");
            a1 = Console.ReadLine();

            Console.WriteLine("Informe o preco do primeiro artigo: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o desconto do primeiro artigo: ");
            desconto = double.Parse(Console.ReadLine());

            preco1 = retornaValor(preco, desconto);

            //*************************************************************

            Console.WriteLine("Informe o nome do segundo artigo: ");
            a2 = Console.ReadLine();

            Console.WriteLine("Informe o preco do segundo artigo: ");
            preco = double.Parse(Console.ReadLine());

            preco2 = retornaValor(preco, desconto);

            Console.WriteLine("Informe o desconto do segundo artigo: ");
            desconto = double.Parse(Console.ReadLine());

            //*************************************************************

            Console.WriteLine("Informe o nome do terceiro artigo: ");
            a3 = Console.ReadLine();

            Console.WriteLine("Informe o preco do terceiro artigo: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o desconto do terceiro artigo: ");
            desconto = double.Parse(Console.ReadLine());

            preco3 = retornaValor(preco, desconto);

            //*************************************************************

            Console.WriteLine("Informe o nome do quarto artigo: ");
            a4 = Console.ReadLine();

            Console.WriteLine("Informe o preco do  quarto artigo: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o desconto do primeiro artigo: ");
            desconto = double.Parse(Console.ReadLine());

            preco4 = retornaValor(preco, desconto);

            imprimeDados();

            Console.ReadKey();
        }

        public static void imprimeDados()
        {
            Console.WriteLine("O nome do primeiro artigo e: " + a1);
            Console.WriteLine("O valor do artigo com desconto foi de " + preco1);
            Console.WriteLine("O nome do segundo artigo e: " + a2);
            Console.WriteLine("O valor do artigo com desconto foi de " + preco2);
            Console.WriteLine("O nome do terceiro artigo e: " + a3);
            Console.WriteLine("O valor do artigo com desconto foi de " + preco3);
            Console.WriteLine("O nome do quarto artigo e: " + a4);
            Console.WriteLine("O valor do artigo com desconto foi de " + preco4);
        }

        public static double retornaValor(double preco, double desconto)
        {
            double resultado = 0;
            resultado = preco - (preco * (desconto / 100));
            return resultado;
        }
    }

}
