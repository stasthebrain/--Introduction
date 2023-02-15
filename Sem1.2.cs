using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, после ввода нажмите Enter");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else Console.WriteLine("Число нечетное");
            
            Console.ReadLine();
        }
    }
}
