using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Fixacao
{

    /*2)Na pasta funcoes-ou-metodos, crie um arquivo chamado JurosComposto.cs. 
    Implemente um programa em C# definindo um método que realize o cálculo do 
    montante obtido com a aplicaçãode juros compostos.*/
    class Exe02_JurosComposto
    {
        static void Main2(string[] args)
        {

            double retorno = jurComp(7.000, 1.5, 1);
            Console.WriteLine(retorno);
        }

        static double jurComp(double capital, double taxa, double tempo)
        {
            double montante = 0;
            montante = capital * (Math.Pow(taxa + 1, tempo));
            return montante;
            
        }
    
    }
}
