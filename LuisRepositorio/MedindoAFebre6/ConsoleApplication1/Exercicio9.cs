using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Exercicio9
    {
        public static void Main9(String[] args){

            string frase = "Hoje#é#dia#de#Programar!";

            string[] novaFrase = frase.Split('#');

            string vetFrase = novaFrase[0] + " " + novaFrase[1] + " " + novaFrase[2] + " " + novaFrase[3] + " " + novaFrase[4];

            Console.WriteLine(vetFrase);
            Console.ReadKey();
        }
    }
}
