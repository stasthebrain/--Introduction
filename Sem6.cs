using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task1()
        {
            int count = 0;
            Console.Write("Введите числа через пробел: ");
            string[] nums = Console.ReadLine().Split();

            foreach (string num in nums)
            {
                if (int.Parse(num) > 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество чисел больше 0: " + count);
            Console.ReadLine();
        }
        private static void Task2()
        {
            double k1, b1, k2, b2, x, y;

            Console.Write("Введите значение k1: ");
            k1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b1: ");
            b1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение k2: ");
            k2 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b2: ");
            b2 = double.Parse(Console.ReadLine());

            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;

            Console.WriteLine("Точка пересечения двух прямых: ({0}, {1})", x, y);
            Console.ReadLine();
        }
    }
}
