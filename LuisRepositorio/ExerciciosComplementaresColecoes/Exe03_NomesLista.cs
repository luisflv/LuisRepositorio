using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExerciciosComplementares
{
    class Exe03_NomesLista
    {
        /*3)Faça um programa que leia n nomes inserindo-os em uma lista de forma ordenada utilizando 
        a ideia do algoritmo da inserção. No final, o programa deve mostrar todos os nomes ordenados alfabeticamente. */

        static ArrayList _ArrayList = new ArrayList();

        public static void Main3(string[] args)
        {
            string nome;
            Console.WriteLine("Informe os nomes: (DIGITE 'fim' PARA SAIR");
            nome = Console.ReadLine();
            while (nome != "fim"){
                _ArrayList.Add(nome);

            } 

            _ArrayList.Sort();

            foreach (var itens in _ArrayList)
            {
                Console.WriteLine("Os nomes ordenados sao: " + itens);
            }

            Console.ReadKey();
        
        }
    }
}    
