using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkS_14._06._2024
{
    public static  class Arrray
    {
        public static void LessonOne()
        {
            int[] numbers = { 5, 12, 3, 7, 9, 1, 4 };

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Минимальный элемент: {min}");
        }

        public static void LessonTwo()
        {
            int[] numbers = { 5, 12, 3, 7, 9, 1, 4 };

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = Convert.ToDouble(sum) / numbers.Length;


            Console.WriteLine("Сумма элементов: " + sum);
            Console.WriteLine("Среднее значение: " + average);
        }

        public static void LessonThree()
        {
            {
                int[] numbers = { 5, 12, 3, 7, 9, 1, 4 };

                Console.WriteLine($"Заданный массив: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < numbers.Length / 2; i++)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[numbers.Length - 1 - i];
                    numbers[numbers.Length - 1 - i] = temp;
                }
                Console.WriteLine($"Реверсированный массив: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
        public static void LessonFour()
        {
            {
                int[] numbers = { 5, 12, 3, 7, 9, 1, 4 };

                Console.Write("Введите число для поиска: ");
                int target = Convert.ToInt32(Console.ReadLine());
                bool found = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == target)
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    Console.WriteLine("число  найдено");
                }
                else
                {
                    Console.WriteLine("число не найдено");
                }
            }

        }
    }
}
