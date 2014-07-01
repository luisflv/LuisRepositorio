using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares
{
    class Exe01_Cem_Numeros
    {
        /*1)Faça um algoritmo que adicione 100 números em qualquer coleção que você preferir, ao final imprima esses números decrescente e depois crescente.*/

        public static ArrayList _Arraylist = new ArrayList();

        static void Main1(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                _Arraylist.Add(i);
            }

             _Arraylist.Reverse(); //ORDEM DECRESENTE

             ImprimeArrayList(_Arraylist);

             _Arraylist.Sort();// ORDEM CRESCENTE

             ImprimeArrayList(_Arraylist);

            Console.ReadKey();
        }

        public static void ImprimeArrayList(ArrayList _ArrayList)
        {
            foreach (var itens in _Arraylist)
            {
                Console.WriteLine(itens);
            }
        }
    }
}
