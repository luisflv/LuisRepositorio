using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.Exercicios_Complementares
{
    /*4)Continuando no software da mega-sena.
     * Implemente um método que mostre quantos números ele acertou, comparando os arrays. 
     * Caso tenha acertado 5 mostre que ele acertou a quina.*/
    class Exe04_MostrarAcerto
    {
        static int contador = 0;

        public static void Main1(string[] args)
        {



            int[] numerosSorteados = { 1, 2, 3, 4, 5, 6 };
            int[] numerosApostados = { 7, 8, 9, 7, 8, 9 };

            //GeraAposta(numerosApostados);

            //GeraSorteio(numerosSorteados);

            VerificaGanhador(numerosApostados, numerosSorteados);

            Console.ReadKey();
        }


        public static void GeraAposta(int[] aposta)
        {
            Random gerador = new Random();

            for (int i = 0; i < 6; i++)
            {
                aposta[i] = gerador.Next(1, 61);
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
                    Console.WriteLine("Você acertou apenas " + contador + " numeros. Você acertou na quina!");
                }
                else if (contador == 6)
                {
                    Console.WriteLine("Você acertou " + contador + " numeros. Você ganhou na mega-sena!");
                }


        }
    }
}
