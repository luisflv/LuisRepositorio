using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares
{
    /*4) Escreva um programa para receber números aleatórios de gols marcados pelo Grêmio e o 
      número de gols marcados pelo Inter em um GRENAL. Escrever o nome do vencedor. 
      Mostre no final o vencedor e quando foi a partida. Caso não haja vencedor deverá ser impressa a palavra EMPATE.
      
     Lembrando que o normal de uma partida é até 5 gols para cada equipe visando o equilíbrio.*/


    class Exercicio4_Gol
    {
        static void Main4(string[] args)
        {
            Random gerador = new Random();

            int golGremio = gerador.Next(6);
            
            int golInter = gerador.Next(6);

            if (golInter > golGremio)
            {
                Console.WriteLine("O inter ganhou a partida de: " + golInter + " X " +golGremio);
            }
            else if (golGremio > golInter)
            {
                Console.WriteLine("O gremio ganhou a partida de: " + golGremio + " X " +golInter);
            }
            else
            {
                Console.WriteLine("Os dois times empataram!");
            }

            Console.ReadLine();

        }

    }
}
