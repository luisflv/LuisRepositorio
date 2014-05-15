using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_A_Febre_VI
{
    class PMedindoAFebre
    {
        static void Main(string[] args)
        {
            string nome, opcao, nomeMaior = null, nomeMenor = null;

            double notaAluno, maiorNota = 0, menorNota = 900;

            double mediaAluno = 0, notaFinal = 0;

            int frequencia, numMatricula, contReprovados = 0, contAprovados = 0, totalAlunos = 0, matMaior = 0, matMenor = 0;

            do
            {
                Console.WriteLine("Informe o nome do aluno: ");
                nome = Console.ReadLine();

                Console.WriteLine("Informe a matricula do aluno: ");
                numMatricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a frequencia do aluno: ");
                frequencia = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe as notas do aluno: ");
                for (int i = 0; i < 3; i++)
                {
                    notaAluno = int.Parse(Console.ReadLine());
                    mediaAluno += notaAluno;

                    //Verificando maior e menor nota
                    if (notaAluno > maiorNota)
                    {
                        maiorNota = notaAluno;
                        matMaior = numMatricula;
                        nomeMaior = nome;
                    }
                    else if (notaAluno < menorNota)
                    {

                        menorNota = notaAluno;
                        matMenor = numMatricula;
                        nomeMenor = nome;
                    }


                }

                

                Console.WriteLine("Deseja continuar? s/n");
                opcao = Console.ReadLine();

                
            } while (opcao != "n");


            notaFinal = mediaAluno / 3;

            //Verificando a aprovacao ou reprovacao do aluno



            if ((notaFinal >= 6) && (frequencia >= 40))
            {
                Console.WriteLine("Aprovado!");
                contAprovados++;
            }
            else
            {
                Console.WriteLine("Reprovado!");
                contReprovados++;
            }

            //Contando a quantidade de alunos
            totalAlunos = contAprovados + contReprovados;

            //Imprimindo
            Console.WriteLine("O nome do aluno que obteve a maior nota foi: {0}", nomeMaior);
            Console.WriteLine("A maior nota foi: {0}", maiorNota);
            Console.WriteLine("A matricula do aluno e: {0}", matMaior);
            Console.WriteLine("A frequencia do aluno foi de: {0}", frequencia);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("O nome do aluno que obteve a menor nota foi: {0}", nomeMenor);
            Console.WriteLine("A menor nota foi: {0}", menorNota);
            Console.WriteLine("A matricula do aluno e: {0}", matMaior);
            Console.WriteLine("A frequencia do aluno foi de: {0}", frequencia);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("A nota final do aluno: {0:F2}", notaFinal);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("O total de alunos e de: {0}", totalAlunos);
            Console.WriteLine("O total de alunos reprovados foi de: {0}", contReprovados);
            Console.WriteLine("O total de alunos reprovados foi de: {0}", contAprovados);
            

            
            
            Console.ReadKey();
        }
    }
}
