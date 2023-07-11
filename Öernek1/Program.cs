using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öernek1
{
    internal class Program
    {
        enum mounths
        {
            Ocak = 1,
            Şubat,
            Mart,
            Nistan,
            Mayıs,
            Haziran,
            Temmuz,
            Ağustos,
            Eylül,
            Ekim,
            Kasım,
            Aralık
        }


        static void Main(string[] args)
        {
            int num1;
            Console.Write("Sayı giriniz = ");
            num1 =Convert.ToInt32(Console.ReadLine());

            mounths mounth = mounth_bring(num1);

            print(mounth);
            Console.ReadLine();
        }

        static mounths mounth_bring(int num1)
        {
            if (Enum.IsDefined(typeof(mounths), num1))
            {
                return (mounths)num1;
            }
            else
            {
                throw new ArgumentException("Geçersiz ay numarası");
            }
        }

        static void print(mounths mounth)
        {
            
            Console.Write("Denk gelen ay = " + mounth);
        }

    }
}
