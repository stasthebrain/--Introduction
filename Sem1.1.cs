using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа, после ввода каждого нажмите Enter");
            int max = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (max < a)
            {
                max = a;
            }
            if (max < b)
            {
                max = b;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}