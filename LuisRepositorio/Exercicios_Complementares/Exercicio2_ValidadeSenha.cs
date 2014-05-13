using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares
{
    /*2)Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. 
     A senha válida é o número NomeUsuário123. Devem ser impressas as seguintes mensagens: 
     ACESSO PERMITIDO caso a senha seja válida.  ACESSO NEGADO caso a senha seja inválida.*/


    class Exercicio2_ValidadeSenha
    {

        public static void Main2(string[] args)
        {

            //

            string verificaValidade;

            Console.WriteLine("Informe o a senha a ser verificada: ");
            verificaValidade = Console.ReadLine();

            if (verificaValidade.Equals("NomeUsuário123"))
            {
                Console.WriteLine("ACESSO PERMITIDO!");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO!");
            }

            Console.WriteLine("Para maior segurança, sua senha deve ser alterada de 15 em 15 dias!");

            Console.ReadKey();

        }
    }
}

