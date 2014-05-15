using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Exercicio8
    {
        public static void Main(String[] args)
        {
            string a = "Curso Inicial Academia do Programador!";

            //Frase Maiuscula

            string maiuscula = a.ToUpper();

            //Frase Minuscula

            string minuscula = a.ToLower();

            //Troca de nomes


            string trocaFrase = a.Replace("Curso", "Faculdade");


            //Intercalado
            
            string[] trocaNomes = a.Split(' ');


            string troca = trocaNomes[0].ToUpper() + " " + trocaNomes[1].ToLower() + " " + trocaNomes[2].ToUpper() + " " + trocaNomes[3].ToUpper() + " " + trocaNomes[4].ToUpper();

            

            
            Console.WriteLine("Maiusula: " + maiuscula);
            Console.WriteLine("Minuscula: " + minuscula);
            Console.WriteLine("Troca de Nomes: "+ troca);
            Console.WriteLine("Troca:" + trocaFrase);

            Console.ReadLine();
        }



    }
}
