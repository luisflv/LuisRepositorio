using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares
{
    /*6)	Escreva um programa que leia o primeiro nome e a altura das moças inscritas em um concurso de beleza. 
     * Quando for informada a palavra FIM para o nome da moça o programa deverá ser encerrado e imprimir: 
     * o nome e a altura da moça mais alta e o número de moças no concurso. Considere que todas as moças possuem altura diferente
    */
    class Exercicio6_ConcursoBeleza
    {
        static void Main6(string[] args)
        {

            string nome;
            int numero;
            double altura;
            double maisAlta = 0;
            string nomeAlta = null;

            do{
                Console.WriteLine("Informe o nome da moca: ");
                nome = Console.ReadLine();
                
                Console.WriteLine("Informe o numero da inscricao da moca: ");
                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura da moca: ");
                altura = double.Parse(Console.ReadLine());

                if (altura > maisAlta)
                {
                    nomeAlta = nome;
                    maisAlta = altura;
                }

                Console.WriteLine("Informe o nome da moca: ");
                nome = Console.ReadLine();
            
            }
            while(nome!="fim");
           



            Console.WriteLine("O nome da moca mais alta e: " + nomeAlta);
            Console.WriteLine("A altura da moca mais alta e: " + maisAlta);
            
            Console.ReadKey();
        }
    }
}
