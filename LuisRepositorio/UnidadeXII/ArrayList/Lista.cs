using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXII
{
    class Lista
    {
        public static void Main(string[] args)
        {
            ArrayList nomes = new ArrayList();

            nomes.Add("Luis");
            nomes.Add("Fernando");

            foreach (string nom in nomes)
            {
                Console.Write(" " +nom);
            }
            
            ArrayList numerosInteriros = new ArrayList();

            numerosInteriros.Add(1);
            numerosInteriros.Add(2);
            numerosInteriros.Add(3);

            foreach (int numInt in numerosInteriros)
            {
                Console.Write(" "+numInt);
            }

            ArrayList numerosDecimais = new ArrayList();

            numerosDecimais.Add(1.5);
            numerosDecimais.Add(2.5);
            numerosDecimais.Add(3.5);

            foreach (double numDec in numerosDecimais)
            {
                Console.WriteLine("\n" + numDec);
            }
            


            Console.ReadKey();
        }


    }

}