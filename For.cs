using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkS_14._06._2024
{
    public static class For
    {
        public static void LessonOne()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void LessonTwo()
        {
            while (true)
            {
                Console.WriteLine("Введите число");
                int result = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = 0; i <= result; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void LessonThree()
        {
            while (true)
            {
                Console.WriteLine("Введите число");
                int result = Convert.ToInt32(Console.ReadLine());
                int factorial = 1;
                for (int i = 1; i <= result; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
                Console.ReadKey();
                Console.Clear();
            }
        }


        public static void LessonFour()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            bool palidrom = Palidrom(input);

            if (palidrom)
            {
                Console.WriteLine("Введеная строка  является палиндромом");
            }
            else
            {
                Console.WriteLine("Введеная строка не является палиндромом");
            }
        }
        static bool Palidrom(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }



        public static void LessonFive()
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Простые числа:");

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

    }
}
