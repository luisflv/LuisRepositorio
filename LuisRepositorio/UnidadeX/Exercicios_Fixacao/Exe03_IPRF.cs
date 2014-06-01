using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Fixacao
{  /*3)Na pasta funcoes-ou-metodos, crie um arquivo chamado IRPF.cs. 
  * Implemente um programaem C# definindo um método que realize o cálculo do imposto de renda pessoa física.*/
    class Exe03_iPRF
    {
        static void Main3(string[] args)
        {
            double calaculaImposto = ImpostoDeRenda(3000, 0.11, 329);
            Console.WriteLine("Calcula Imposto de renda: {0} ", calaculaImposto);
            Console.ReadKey();
        }
        static double ImpostoDeRenda(double salario, double inss, int dependente)
        {
            double calculaInss = salario * inss;
            double calculaImpostoDeRenda = salario - calculaInss - dependente;
            return calculaImpostoDeRenda;
        }
    }
}
