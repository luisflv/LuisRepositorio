﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicios_Complementares
{
    class Exe03_ControleEstaciona
    {
        /*3)Para controlar o estacionamento de um condomínio, devemos implementar um programa em C# 
        para gerar os cartões das vagas dos moradores. Nos cartões, é necessário constar o número do 
        bloco e o número do apartamento. Nesse condômino, há três blocos numerados de 1 a 3. Emcada bloco, há 9 andares. 
        Em cada andar, há 4 apartamentos. No primeiro andar, os números dos Apartamentos são: 11, 12, 13 e 14. 
        No segundo andar, os números dos apartamentos são: 21, 22, 23 e 24. Nos outros andares, a lógica de numeração é
        a mesma*/


        static void Main5(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("Bloco {0}, Andar{1}, Apartamento{2}", i,j,k);
                    }
                }
            }
            
        }
    }
}
