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
            int num1, num2;
            Console.WriteLine("1. Sayıyı Giriniz");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            karsilastirma(num1,num2);
            Console.ReadLine();
        }


        static int karsilastirma(int num1,int num2)
        {
            if(num1 > num2)
            {
                Console.WriteLine("1 numarar daha büyük");
                return num1;
            }
            else
            {
                Console.WriteLine("2 numarar daha büyük");
                return num2;
            }
        }




    }
}
