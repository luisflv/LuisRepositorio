using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao
{
    class Exercicio5
    {
        /*5)Faça o programa que apresenta a seguinte saída, perguntando ao usuário o número máximo (no exemplo, 9). 
         Este número deve ser sempre ímpar.

            1 2 3 4 5 6 7 8 9
              2 3 4 5 6 7 8
                3 4 5 6 7
                 4 5 6
                   5  */

        static void Main(string[] args)
        {

            int valor;

            Console.WriteLine("Informe o valor a ser exibido: ");
            valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0){
                Console.WriteLine("Informe um numero ímpar!");
            }

            int[] vet = new int[valor];
           
           
            for (int i = 1; i<=vet.Length; i++) {
                Console.Write(+i +"\t");
                Console.WriteLine((i+1)-1); 
              
                
            }

            Console.ReadKey();

        }
    }
}
