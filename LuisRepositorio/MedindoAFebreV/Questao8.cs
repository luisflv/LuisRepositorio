using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Questao8
    {
        static void Main(string[] args)
        {
            string opcao;
            double registroHoraEntrada;
            int quantidadePessoas = 0;

            Console.WriteLine("Deseja verificar quantas pessoas entraram no banco durante o expediente ? s/n");
            opcao = Console.ReadLine();

            while (opcao == "s")
            {

                Console.WriteLine("Informe o horario de entrada no banco: ");
                registroHoraEntrada = double.Parse(Console.ReadLine());

                if ((registroHoraEntrada > 10) && (registroHoraEntrada < 16))
                {
                    quantidadePessoas++;
                }

                Console.WriteLine("Deseja continuar verificando? s/n");
                opcao = Console.ReadLine();
            }
            Console.WriteLine("A quantidade de pessoas que entrou no banco durante o expediente foi de : " + quantidadePessoas);

            Console.ReadKey();

        }
    }
}
