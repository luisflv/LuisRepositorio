using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_A_Febre_VII
{
    class MedindoAFebre
    {



        static void Main(string[] args)
        {

            string[] nome = new string[50];
            string[] sexo = new string[50];
            double[] altura = new double[50];
            int[] idade = new int[50];


            InsereAltura(altura);

            InsereIdade(idade);

            InsereSexo(sexo);

            InsereNome(nome);

            VerificacaIdade(idade);

            VerificacaoAlturaNome(altura, nome);

            

            Imprime(nome, altura, sexo, idade);

        }

        //*******************************************************************************************
        //Inserindo dados

        public static void InsereNome(string[] vetor)
        {
            Random gerador = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = "Teste" + i;
            }
        }


        public static void InsereAltura(double[] vetor)
        {
            Random gerador = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.NextDouble() + 1;
            }
        }

        public static void InsereSexo(string[] vetor)
        {
            Random gerador = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                if (gerador.Next(0, 2) == 0)
                {
                    vetor[i] = "masculino";
                }
                else if (gerador.Next(0, 2) == 1)
                {
                    vetor[i] = "feminino";
                }
                if ((gerador.Next(0, 2)) != 0 || (gerador.Next(0, 2) != 1))
                {
                    vetor[i] = "feminino";
                }
            }
        }

        public static void InsereIdade(int[] vetor)
        {
            Random gerador = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(1, 99);
            }
        }

        //*******************************************************************************************


        //**********************************************************
        //Verificando Altura

        static string pesAlta = null, pesBaixa = null;
        static double maisAlta = 0, maisBaixa = 2.00;
        static int contAlt = 0;

        public static void VerificacaoAlturaNome(double[] vetAltura, string[] vetNome)
        {
            for (int i = 0; i < vetAltura.Length; i++)
            {
                if (vetAltura[i] > 0)
                {
                    pesAlta = vetNome[i];
                    maisAlta = vetAltura[i];
                }
                 
                if (vetAltura[i] < maisBaixa)
                {
                    maisBaixa = vetAltura[i];
                    pesBaixa = vetNome[i];
                }

                if (vetAltura[i] > 1.70)
                {
                    contAlt++;
                }
            }


        }

        //**********************************************************
        //Verificando idade

        static int maisVelho = 0;
        static int maisNovo = 100;
        static bool[] adulto = new bool[50];
        static int contAdulto = 0;

        public static void VerificacaIdade(int[] vetIdade)
        {
            for (int i = 0; i < vetIdade.Length; i++)
            {
                if (vetIdade[i] > 18)
                {
                    adulto[i] = true;
                    contAdulto++;
                    Console.WriteLine(adulto); 
                }
                else
                {
                    adulto[i] = false;
                    Console.WriteLine(adulto);
                }

                if (vetIdade[i] > maisVelho)
                {
                    maisVelho = vetIdade[i];

                }
                else if (vetIdade[i] < maisNovo)
                {
                    maisNovo = vetIdade[i];
                }
            }
        }

        //**********************************************************
        //Verificando sexo

        static int contMasc = 0, contFem = 0;

        public static void VerificacaoSexo(string[] vetSexo)
        {
            for (int i = 0; i < vetSexo.Length; i++)
            {
                if (vetSexo[i] == "masculino")
                {
                    contMasc++;
                }
                else
                {
                    contFem++;
                }
            }
        }



        //Imprimindo... 
        public static void Imprime(string[] vetorNome, double[] vetorAltura, string[] vetorSexo, int[] vetorIdade)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Nome :{0}", vetorNome[i]);
                Console.WriteLine("Adulto: {0}", adulto[i]);
                Console.WriteLine("Altura :{0:F2}", vetorAltura[i]);
                Console.WriteLine("Sexo  :{0}", vetorSexo[i]);
                Console.WriteLine("Idade :{0}", vetorIdade[i]);

            }

            
            
                Console.WriteLine("O mais velho e: {0}", maisVelho);
                Console.WriteLine("O mais novo e: {0}", maisNovo);
                Console.WriteLine("Pessoa mais alta: {0}",  pesAlta);
                Console.WriteLine("Pessoa mais alta: {0}",  maisAlta);
                Console.WriteLine("Pessoa mais baixa: {0}", pesBaixa);
                Console.WriteLine("Pessoa mais baixa: {0}", maisBaixa);
           
        }

    }
}
