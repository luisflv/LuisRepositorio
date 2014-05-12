using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    /*8) Uma empresa de vendas tem três corretores. A empresa paga ao corretor uma 
      comissão calculada de acordo com o valor de suas vendas. Se o valor da venda 
      de um corretor for maior que R$ 50.000.00 a comissão será de 12% do valor 
      vendido. Se o valor da venda do corretor estiver entre R$ 30.000.00 e R$        
      50.000.00 (incluindo extremos) a comissão será de 9.5%. Em qualquer outro 
      caso, a comissão será de 7%. Escreva um algoritmo que gere um relatório 
      contendo nome, valor da venda e comissão de cada um dos corretores. O 
      relatório deve mostrar também o total de vendas da empresa. */


    public class Exercicio8_Corretores
    {
        static string corretor1, corretor2, corretor3;
        static double valorVendas, totVendas1, totVendas2, totVendas3, totVendas;
        static double comissao1, comissao2, comissao3;


        public static void Main8(string[] args)
        {




            //*****************************************************************************

            Console.WriteLine("Informe o nome do primeiro corretor: ");
            corretor1 = Console.ReadLine();

            Console.WriteLine("Informe o valor das vendas do primeiro corretor: ");
            valorVendas = double.Parse(Console.ReadLine());


            totVendas1 = totalDeVendasEmpresa(valorVendas);

            //Chamada do método que verifica a comissao do corretor
            comissao1 = retornaComissao(valorVendas);


            //*****************************************************************************
            Console.WriteLine("Informe o nome do segundo corretor: ");
            corretor2 = Console.ReadLine();

            Console.WriteLine("Informe o valor das vendas do segundo corretor: ");
            valorVendas = double.Parse(Console.ReadLine());

            totVendas2 = totalDeVendasEmpresa(valorVendas);

            //Chamada do método que verifica a comissao do corretor
            comissao2 = retornaComissao(valorVendas);

            //*****************************************************************************

            Console.WriteLine("Informe o nome do terceiro corretor: ");
            corretor3 = Console.ReadLine();

            Console.WriteLine("Informe o valor das vendas do terceiro corretor: ");
            valorVendas = double.Parse(Console.ReadLine());

            //Chamada do método que verifica a comissao do corretor
            comissao3 = retornaComissao(valorVendas);

            totVendas3 = totalDeVendasEmpresa(valorVendas);

            //*****************************************************************************

            totVendas = totVendas1 + totVendas2 + totVendas3;

            //Chamada dos procedimentos para impressao dos dados
            imprimeDados();
            Console.WriteLine("O total de vendas foi de : " + totVendas);

            Console.ReadKey();
        }

        public static void imprimeDados()
        {
            Console.WriteLine("O nome do primeiro corretor e     :" + corretor1);
            Console.WriteLine("A comissao do primeiro corretor e :" + comissao1);
            Console.WriteLine("O nome do segundo corretor e      :" + corretor2);
            Console.WriteLine("A comissao do segundo corretor e  :" + comissao2);
            Console.WriteLine("O nome do terceiro corretor e     :" + corretor3);
            Console.WriteLine("A comissao do terceiro corretor e :" + comissao3);
        }

        public static double totalDeVendasEmpresa(double valorVendas)
        {
            double totalEmpresa = 0;
            totalEmpresa += valorVendas;
            return totalEmpresa;
        }




        public static double retornaComissao(double valorVendas)
        {
            double comissao = 0;
            if (valorVendas > 50.000)
            {
                comissao = valorVendas + (valorVendas * 0.12);
            }
            else if (valorVendas >= 30.000 & valorVendas <= 50.000)
            {
                comissao = valorVendas + (valorVendas * 0.095);
            }
            else
            {
                comissao = valorVendas + (valorVendas * 0.07);
            }

            return comissao;
        }

    }
}