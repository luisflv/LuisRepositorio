using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Questao7
    {
        static void Main1(string[] args)
        {

            int idade;

            Console.WriteLine("Informe a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine());

            string res = idade >= 18 ? "Esta pessoa E maior de idade" : "Esta pessoa NAO e maior de idade";

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}


