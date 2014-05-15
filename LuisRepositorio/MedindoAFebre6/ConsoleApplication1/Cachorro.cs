using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cachorro
    {
        static void Mainc(string[] args)
        {
            Random gerador = new Random();

            int cachorro1 = 0, cachorro2 = 0, cachorro3 = 0, cachorro4 = 0;

            for (int i = 0; i < 20; i++)
            {
                cachorro1 += gerador.Next(0, 3);
            }

            for (int i = 0; i < 20; i++)
            {
                cachorro2 += gerador.Next(0, 3);
            }

            for (int i = 0; i < 20; i++)
            {
                cachorro3 += gerador.Next(0, 3);
            }

            for (int i = 0; i < 20; i++)
            {
                cachorro4 += gerador.Next(0, 3);
            }






        }
    }
}
