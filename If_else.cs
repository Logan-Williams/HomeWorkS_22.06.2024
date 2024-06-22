using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkS_14._06._2024
{
    public static class If_else
    {
        public static void LessonOne()
        {
            while (true)
            {
                Console.WriteLine("Введите чилсло от 1 до 100");
                int result = 0;

                try
                {
                    result = Convert.ToInt32(Console.ReadLine());
                    if ((result % 2) == 0)
                    {
                        Console.WriteLine($"Число {result} четное");
                    }
                    else
                    {
                        Console.WriteLine($"Число {result} не четное");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка, неверный формат ввода");
                    Console.WriteLine("Повторите попытку:");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }


        public static void LessonTwo()
        {

            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"Число {a} больше {b}");
            }
            else
            {
                Console.WriteLine($"Число {b} больше {a}");
            }
        }


        public static void LessonThree()
        {
            Console.WriteLine("Введите год");
            int result = Convert.ToInt32(Console.ReadLine());
            if ((result % 4) == 0 || (result % 400) == 0 && (result % 100) == 0)
            {
                Console.WriteLine("Год вискокосный");
            }
            else
            {
                Console.WriteLine("Год не вискокосный");
            }
        }


        public static void LessonFour()
        {

            Console.WriteLine("Введите число");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == 0)
            {
                Console.WriteLine("Число равно  нулю");
            }
            if (result! <= 0 && result != 0)
            {
                Console.WriteLine($"Число {result} меньше нуля");
            }
            if (result! >= 0 && result != 0)
            {
                Console.WriteLine($"Число {result} больше нуля");
            }
        }


    }

}
