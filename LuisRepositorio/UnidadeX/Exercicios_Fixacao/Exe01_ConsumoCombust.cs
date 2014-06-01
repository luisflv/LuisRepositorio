using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Fixacao
{
    /*1)	Na pasta funcoes-ou-metodos, crie um arquivo chamado ConsumoDeCombustivel.cs.
    Implementeumprogramaem C# definindo um método que realize o cálculo do consumo de combustível de um veículo.*/
    class Exe01_ConsumoCombust
    {
        static void Main1(string[] args)
        {
            double retorno;
            retorno  = consuCombustivel(10, 5);
            Console.WriteLine(retorno);
        }

        static double consuCombustivel(double Km, double litro){
            double consumoFinal = 0;
            consumoFinal = Km / litro;
            return consumoFinal;
        }
    }
}
