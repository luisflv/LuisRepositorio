using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.Exercicios_Complementares
{
    class Exe02_MegaSenaII
    {
        /*2)Continuando na questão 1, o usuário agora deve informar os 6 números que ele deseja escolher. 
        Esses 6 dados devem ser armazenados em um array também, como os números premiados da questão 1. 
        Caso o usuário escolha um número fora do intervalo do cartão da mega-sena, o software deve avisa-lo.*/

        static int contador = 0;

        public static void Main2(string[] args)
        {
            int[] numeroSorteado = { 1, 2, 3, 4, 5, 6 };
            int[] numeroApostado = new int[6];


            GeraAposta(numeroApostado);
            VerificaGanhador(numeroApostado, numeroSorteado);

        }

      public static void GeraAposta(int[] aposta){
          for (int i = 0; i < 6; i++)
			{
			 
			
          Console.WriteLine("Informe os numeros da aposta: ");
          int numeroAposta = int.Parse(Console.ReadLine());     
           if (numeroAposta > 60 || numeroAposta < 0)
            {
                    Console.WriteLine("Não é possível informar tal valor! Devera ser entre 0 e 60");
            }
                else
                {
                    aposta[i] = numeroAposta;
                }
			}
      }
      

        public static void GeraSorteio(int[] sorteio)
        {
            Random gerador = new Random();

            for (int i = 0; i < 6; i++)
            {
                sorteio[i] = gerador.Next(1, 61);
            }
        }

        public static void VerificaGanhador(int[] aposta, int[] sorteio)
        {


            for (int i = 0; i < 6; i++)
            {
                if (aposta.Contains(sorteio[i]))
                {
                    contador++;
                }

            }

            if (contador == 0)
            {
                Console.WriteLine("Nossa! Você anda um pouco azarado. Não desista, tente novamente! =]");
            }
            else
                if (contador == 1)
                {
                    Console.WriteLine("Você acertou apenas " + contador + " numero. Não foi desta vez!");
                }
                else if (contador == 2)
                {
                    Console.WriteLine("Você acertou apenas " + contador + " numeros. Não foi desta vez!");
                }
                else if (contador == 3)
                {
                    Console.WriteLine("Você acertou apenas " + contador + " numeros. Não foi desta vez!");
                }
                else if (contador == 4)
                {
                    Console.WriteLine("Você acertou apenas " + contador + " numeros. Não foi desta vez!");
                }
                else if (contador == 5)
                {
                    Console.WriteLine("Você acertou apenas " + contador + " numeros. Não foi desta vez!");
                }
                else if (contador == 6)
                {
                    Console.WriteLine("Você acertou " + contador + " numeros. Você ganhou na mega-sena!");
                }


        }


    }
}
