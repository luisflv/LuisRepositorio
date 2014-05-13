using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI
{
    class Exercicio5_Fazendeiro
    {
        static void Main5(string[] args)
        {

            int idade, numero, quantidadeCaixas;

            double pagamentoCaixa = 0, pagamentoFinal = 0;

            Console.WriteLine("Informe a idade do trabalhador: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número do trabalhador: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de caixas colhidas pelo trabalhador: ");
            quantidadeCaixas = int.Parse(Console.ReadLine());



            //Calculo do pagamento por caixa colhida pelo trabalhador


            if (quantidadeCaixas <= 5)
            {
                pagamentoCaixa = quantidadeCaixas * 2.00;
            }
            else if ((quantidadeCaixas > 6) && (quantidadeCaixas <= 10))
            {
                pagamentoCaixa = quantidadeCaixas * 2.50;
            }
            else if ((quantidadeCaixas >= 11) && (quantidadeCaixas <= 20))
            {
                pagamentoCaixa = quantidadeCaixas * 3.50;
            }
            else if ((quantidadeCaixas >= 21))
            {
                pagamentoCaixa = quantidadeCaixas * 5.00;
            }

            //Calculo do pagamento adicional

            if ((idade >= 18) && (idade <= 45))
            {
                pagamentoFinal = pagamentoCaixa + (pagamentoCaixa * 0.10);
            }
            else if ((idade > 45) && (idade < 65))
            {
                pagamentoFinal = pagamentoCaixa + (pagamentoCaixa * 0.20);


            }else if ((idade < 18) && (idade>65)){
                Console.WriteLine("Não receberá adicional!");
            }

            Console.WriteLine("O pagamento deste funcionario foi de: " +pagamentoFinal);

            Console.ReadKey();
        }




    }
}
