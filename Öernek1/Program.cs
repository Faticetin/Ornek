using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öernek1
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Dizi Elaman Sayısını Giriniz");
            num1 = Convert.ToInt32(Console.ReadLine());

            int[] series = new int[num1];
            for (int i = 0; i < num1; i++)
            {
                Console.WriteLine("Elamanı giriniz");
                series[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < series.Length; j++)
            {
                Console.WriteLine(series[j]);
            }

            Console.ReadLine();
        }



    }
}
