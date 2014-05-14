using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exe_Slide_Instrucao_Repeticao
{
    /*11) Ainda no projeto UNIDADE VIII, crie um exercício chamado GeradorDeIngressos. 
     Implemente um programa para gerar os ingressos das apresentações de um teatro. 
     Considere que esse teatro possui 4 setores e cada setor possui 20 lugares.*/


    class _11_GeradorIngressos
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i <= 4; i++)
            {
                
                for (int j = 1; j <= 20; j++)
                {
                    Console.WriteLine("Setor"+ i +"Cadeira: "  +j);
                }
            }
            Console.ReadKey();
        }
    }
}
