using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numaric = new int[] { 1, 2, 3, 4, 5 };
            string[] name = new string[] { "Fatih", "Hakan", "Furkan", "Yasin", "Mertcan" };
            string[] phone = new string[] { "0542-534-2323", "0532-037-0261", "0535-899-2389", "0534-999-7809", "0342-938-2832" };
            string[] email = new string[] { "fatcet@gmail.com", "hakan@gmail.com", "furkan@gmail.com", "yasin@gmail.com", "mertcan@gmail.com" };

            int employee;
            Console.WriteLine("Aradığınız Personel Numarası");
            employee = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Personel numarası = " + numaric[employee - 1]);
            Console.WriteLine("Personel adı = " + name[employee - 1]);
            Console.WriteLine("Personel telefon  numarası = " + phone[employee - 1]);
            Console.WriteLine("Personel emali = " + email[employee - 1]);

            Console.ReadKey(); 
        }
    }
}
