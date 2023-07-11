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
            string text;
            Console.WriteLine("Metini Giriniz");
            text= Console.ReadLine();

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();



        }
    }
}
