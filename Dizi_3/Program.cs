using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Dizi_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[20];

            int rnum, nnum = 0, pnum = 0, ncounter = 0, pcounter = 0;

            Random r = new Random();

            for (int i = 0; i < 18; i++)

            {

                rnum = r.Next(-100, 100);

                num[i] = rnum;

                if (rnum < 0) nnum++;

                else pnum++;

            }

            int[] negatif = new int[nnum];

            int[] pozitif = new int[pnum];

            foreach (int i in num)

            {

                if (i < 0)

                {

                    negatif[ncounter] = i;

                    ncounter++;

                }

                else

                {

                    pozitif[pcounter] = i;

                    pcounter++;

                }

            }

            Console.WriteLine("\nÜretilen Sayılar");

            foreach (int i in num)

            {

                Console.Write(" {0} ", i);

            }

            Console.WriteLine("\nÜretilen Sayılardan Negatif Olanlar");

            foreach (int i in negatif)

            {

                Console.Write(" {0} ", i);

            }

            Console.WriteLine("\nÜretilen Sayılardan Pozitif Olanlar");

            foreach (int i in pozitif)

            {

                Console.Write(" {0} ", i);

            }

            Console.ReadKey();

        }

    } 
    
}
