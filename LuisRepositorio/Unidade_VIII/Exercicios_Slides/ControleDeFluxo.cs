using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Slides
{
    class ControleDeFluxo
    {
        

        static void Main(string[] args)
        
        {

            Random gerador = new Random();
            double Nota = gerador.NextDouble();

            verifica(Nota);

        }

        public static void verifica(double nota)
        {
            if (nota > 0.7)
            {
                Console.WriteLine("A nota foi: " +nota);
                Console.WriteLine("O aluno esta aprovado!");
            }
            else
            {
                Console.WriteLine("A nota foi: " + nota);
                Console.WriteLine("O aluno esta reprovado!");
            }
        }
    }
}
