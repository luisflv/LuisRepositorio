using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares
{
    /*3) Tendo como entrada a altura e o sexo (codificado da seguinte forma: 1:feminino 2:masculino) de uma pessoa, 
    construa um programa que calcule e imprima seu peso ideal, utilizando as seguintes fórmulas: 
    - para homens : (72.7 * altura) – 58 
    - para mulheres : (62.1 * altura) – 44.7*/


    class Exercicio3_PesoIdeal
    {

        public static void Main3(string[] args)
        {
            int sexo;
            double altura = 0, pesoIdeal = 0;

            Console.WriteLine("Informe o sexo da pessoa: ");
            Console.WriteLine("1:feminino" + "\n2:masculino");
            sexo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura da pessoa: ");
            altura = double.Parse(Console.ReadLine());

            switch (sexo)
            {
                case 1:
                    
                    pesoIdeal = ((62.1 * altura) - 44.7);
                    Console.WriteLine("O peso ideal e: " +pesoIdeal);
                    break;
                case 2:
                    pesoIdeal = ((72.7 * altura) - 58);
                    Console.WriteLine("O peso ideal e: " + pesoIdeal);
                    break;
                default: Console.WriteLine("Não ha peso ideal para esta pessoa!");
                    
                    break;
            }
            Console.ReadKey();
        }


    }
}

