using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.Exercicios_Complementares
{
    class Exe02_DataValida
    {
        /*2)Implemente um método que verifica se uma determinada data é válida ou não.
         * Lembre-se que Janeiro, Março, Maio, Julho, Agosto, Outubro e Dezembro possuem 31 dias;
         * Abril, Junho, Setembro e Novembro possuem 30 dias; e Fevereiro possui 28 dias em anos 
         * não bissextos e 29 dias em anos bissextos.*/
        static void Main2(string[] args)
        {

        }

        static void verifica(int dia, int mes, int ano)
        {
            {
                if ((ano % 4 == 0) && (ano % 400 == 0) && (ano % 100 == 1))
                {
                    Console.WriteLine("Estes ano e bissexto!");
                }
                else
                {
                    Console.WriteLine("Nao e bissexto!");
                }
            }

        }
    }
    
}
