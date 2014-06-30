using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ExerciciosComplementaresColecoes
{
    class Exe04_DiferentesListas
    {
        /*4)Faça 4 listas com diferentes coleções, List, ArrayList, IList, Dictionary. 
        Adicione dados em cada uma delas e no final liste-os.*/


        public static ArrayList _ArrayLista = new ArrayList();
        public static List<double> _Lista = new List<double>();
        public static Dictionary<int, string> _Dicionario = new Dictionary<int, string>();
        public static void Main4(string[] args)
        {
            _ArrayLista.Add("Luís");
            _ArrayLista.Add("Fernando");

            //Imprimindo os dados do ArrayList:
            foreach (string itens in _ArrayLista)
            {
                Console.WriteLine(itens);
            }

            _Lista.Add(1.5);
            _Lista.Add(2.5);

            //Imprimindo os dados da List:
            foreach (double itens in _Lista)
            {
                Console.WriteLine(itens);
            }


            _Dicionario.Add(1, "A");
            _Dicionario.Add(2, "B");
            _Dicionario.Add(3, "C");

            //Imprimindo Dictionary
            foreach (var itens in _Dicionario)
            {
                Console.WriteLine(itens);
            }

            Console.ReadKey();
        }
    }
}
