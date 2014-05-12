using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII
{
    class OperadoresString
    {
        static void Main4(string[] args)
        {
            //Recuperar caractere de acordo com a sua posicao

            string nome = "Luis";

            char c = nome[0];

            Console.WriteLine(c);
            
            //Verificar se uma determinada sequencia de caractere esta contida

            string s = "Apostila de Java";

            bool resultado1 = s.Contains("Apostila");
            bool resultado2 = s.Contains("C#");

            //True
            Console.WriteLine(resultado1);
            //False
            Console.WriteLine(resultado2);
            
            //Verificar se a string termina com uma determinada sequencia de caracteres
            Console.WriteLine("\n Verificar se a string termina com uma determinada sequencia de caracteres: ");
            string b = "Apostila de C#";

            bool res1 = b.EndsWith("C#");
            bool res2 = b.EndsWith("Java");

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            
            //Verificar se a string comeca com uma determinada sequencia de caracteres
            Console.WriteLine("\n Verificar se a string comeca com uma determinada sequencia de caracteres: ");
            string d = "Apostila de C#";

            bool re1 = d.StartsWith("A");
            bool re2 = d.StartsWith("B");

            Console.WriteLine(re1);
            Console.WriteLine(re2);

            //Extrait um trecho de uma string

            string s1 = "Luís Fernando";

            string s2 = s1.Substring(5);
            string s3 = s1.Substring(2, 8);

            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.ReadKey();

            //Eliminando espacos em branco do comeco e termino de uma string

            string s4 = " Luis Fernando";

            string s5 = s4.Trim();

            Console.WriteLine(s5);


            //Separador

            string name = "Lu*is";
            string[] stringArray = nome.Split('*');
            name.Replace('*', '*');

            //Date Time

            DateTime dt = new DateTime(2010,8,27);

            //Acrescentando 140 dias

            dt = dt.AddDays(140);

            //Subtraindo 2 anos
            dt = dt.AddYears(-2);
        
            //Acrescentando 20 segundos

            dt = dt.AddSeconds(20);
        
        }
    }
}
