using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, после ввода нажмите Enter");

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<n; i++ )
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
