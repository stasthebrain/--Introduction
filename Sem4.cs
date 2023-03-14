using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            Console.WriteLine("Введите число A, затем введите число B:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Task2()
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();

            int number;
            bool success = int.TryParse(input, out number);

            if (success)
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                Console.WriteLine("Сумма цифр в числе: " + sum);
            }
            else
            {
                Console.WriteLine("Ошибка! Неверный формат числа.");
            }
            Console.ReadLine();
        }
    }
}
