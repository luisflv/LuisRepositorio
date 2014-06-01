using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Complementares
{
    class Exe03_
    {
        /*3)Implemente um método que verifique a idade de 20 pessoas, um para comparar a maior idade,
        um para menor idade, outro para fazer a média de todas as 20 idades e por fim imprimir todos esses dados. (5 métodos)*/
        
        static int[] idade = new int[20];

        static void Main(string[] args)
        {
            Random gerador = new Random();
            for (int i = 0; i < idade.Length; i++)
            {
                idade[i] = gerador.Next(1, 101);
            }

            verificaMenoridade(idade);
        }

        static void verificaIdade(int[] vet)
        {
            verificaMaioridade(vet);
            verificaMenoridade(vet);
            mediaIdades(vet);
            imprime(vet);

        }

        static void verificaMaioridade(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] >= 18)
                {
                    Console.WriteLine("Maior de idade: " + i + " : " + idade[i]);
                }

            }
        }

        static void verificaMenoridade(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] < 18)
                {
                    Console.WriteLine("Maior de idade: " + i + " : " + idade[i]);
                }

            }
        }

        static void mediaIdades(int[] vet)
        {
            double media = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                media += vet[i] / 20;
            }
            Console.WriteLine("A media das idades e de: " + media);
        }

        static void imprime(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }

}
