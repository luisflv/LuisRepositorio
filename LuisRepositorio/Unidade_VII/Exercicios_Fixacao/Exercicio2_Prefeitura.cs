using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao
{
    /*2)A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. 
    Faça um algoritmos para coletar dados sobre o salário e número de filhos de cada 
    habitante e após as leituras, escrever: 
    a) Média de salário da população 
    b) Média do número de filhos 
    c) Maior salário dos habitantes 
    d) Percentual de pessoas com salário menor que R$ 150,00 
    Obs.: O final da leituras dos dados se dará com a entrada de um “salário negativo”*/


    class Exercicio2_Prefeitura
    {
        static void Main2(string[] args)
        {
            int contHab = 0, qtdFilhos;
            double salario, somaSalarioPop = 0;
            double mediaSalarioPop = 0;
            double maiorSalario = 0;

            do{

                Console.WriteLine("Informe o salario do habitante: ");
                salario = double.Parse(Console.ReadLine());

                contHab++;

                //Verifica o maior salario
                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                //Soma o salario dos habitantes
                somaSalarioPop += salario;


                Console.WriteLine("Informe a quantidade de filhos: ");
                qtdFilhos = int.Parse(Console.ReadLine());



                Console.WriteLine("Informe o salario: ");
                salario = double.Parse(Console.ReadLine());

            }while(salario>=0);

            mediaSalarioPop = somaSalarioPop / contHab;


            Console.WriteLine("A media de salario da populacao e de: " +mediaSalarioPop);
            Console.WriteLine("O maior salario e: " +maiorSalario);
            Console.ReadKey();
        }

    }
}
