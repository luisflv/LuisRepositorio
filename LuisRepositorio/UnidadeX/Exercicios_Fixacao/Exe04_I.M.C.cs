using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Fixacao
{
    class Exe04_IMC
    {
        /*4)Na pasta funcoes-ou-metodos, crieumarquivo chamado IMC.cs.
         * Implemente umprogramaem C# definindo um método que realize o cálculo do índice
         * de massa corporal e outro que determina a situação da pessoa a partir desse índice.
         */
        static void Main4(string[] args)
        {
            double retorno; 
            retorno = CalculaImc(72, 1.72);
            Console.WriteLine("Calculo do IMC: {0:F2} ", retorno);

            verifica(retorno);
            Console.ReadKey();
        }

        static double CalculaImc(double peso, double altura)
        {
            double imc = (peso / (altura * altura));
            return imc;
        }

        static void verifica(double valor)
        {
            if (valor < 17)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            if (valor >= 17 && valor <= 18.49)
            {
                Console.WriteLine("Abaixo do peso");
            }
            if (valor >= 18.5 && valor <= 24.99)
            {
                Console.WriteLine("Peso Normal");
            }
            if (valor >= 25 && valor <= 29.99)
            {
                Console.WriteLine("Acima do Peso");
            }
            if (valor >= 30 && valor <= 34.99)
            {
                Console.WriteLine("Obsidade I ");
            }
            if (valor >= 35 && valor <= 39.99)
            {
                Console.WriteLine("Obsidade II  - Severa");
            }
            if (valor >= 40)
            {
                Console.WriteLine("Obsidade III  - Móbida");
            }
        }

    }
}
