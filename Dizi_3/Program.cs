using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Dizi_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positiveNumbersCount = 0;
            int negativeNumbersCount = 0;
            int[] numbers = new int[20];
            GenerateRandomNumbers(numbers);

            positiveNumbersCount = GetPositiveNumbersCount(numbers);
            int[] positiveNumbers = new int[positiveNumbersCount];

            negativeNumbersCount = GetNegativeNumbersCount(numbers);
            int[] negativeNumbers = new int[negativeNumbersCount];

            SetPositiveNumbers(numbers, positiveNumbers);
            SetNegativeNumbers(numbers, negativeNumbers);

            Console.WriteLine("Üretilen Sayılar");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.Write("\n"+"Pozitif Sayılar " +"\n");
            foreach (int positiveNumber in positiveNumbers)
            {
                Console.Write(positiveNumber + " ");
            }

            Console.Write("\n"+"Negatif Sayılars" +"\n");
            foreach (int negativeNumber in negativeNumbers)
            {
                Console.Write(negativeNumber + " ");
            }



            Console.ReadKey();
        }


        static void GenerateRandomNumbers(int[] numbers)
        {
            Random ran = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ran.Next(-100, 100);
            }
        }

        static int GetPositiveNumbersCount(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int GetNegativeNumbersCount(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    count++;
                }

            }
            return count;
        }

        static void SetPositiveNumbers(int[] numbers, int[] positiveNumbers)
        {
            int index = 0;
            foreach(int number in numbers)
            {
                if(number > 0)
                {
                    positiveNumbers[index] = number;
                    index++;
                }
            }
        }

        static void SetNegativeNumbers(int[] numbers, int[] negativeNumbers)
        {
            int index = 0;
            foreach(int number in numbers)
            {
                if (number < 0)
                {
                    negativeNumbers[index] = number;
                    index++;
                }
            }
        }

    }



}
