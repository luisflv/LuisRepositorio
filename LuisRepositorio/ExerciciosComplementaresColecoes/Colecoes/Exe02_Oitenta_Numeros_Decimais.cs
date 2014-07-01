using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExerciciosComplementares
{
    

    

    class Exe02_Oitenta_Numeros_Decimais
    {
        /*2)Faça um algoritmo que leia uma coleção com 80 números decimais e encontre o menor valor, 
         o maior valor, a média e a soma de todos os valores.*/

        public static List<double> lista = new List<double>();

        public static void Main2(string[] args)
        {
            Random gerador = new Random();
            double numeros;
            for (int i = 0; i < 5; i++)
            {
                lista.Add(numeros = gerador.NextDouble()*10);
            }

            foreach (var itens in lista)
            {
                Console.WriteLine("{0:F2}", itens);
            }

            Console.WriteLine();
            Console.WriteLine("O menor valor da lista e      : {0:F2}" , lista.Min());
            Console.WriteLine("O maior valor da lista e      : {0:F2}" , lista.Max());
            Console.WriteLine("A soma dos valores da lista e : {0:F2}" , lista.Sum());
            Console.WriteLine("A media dos valores da lista e: {0:F2}" , lista.Average());

            Console.ReadKey();
        }

      
    }
}
