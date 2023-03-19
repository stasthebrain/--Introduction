using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
        
        private static void Task1()
        {
            int[] array = new int[8];

            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100, 1000);
            }

            int count = 0;
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество четных чисел в массиве: " + count);
            Console.ReadLine();
        }

        private static void Task2()
        {
            int[] array = new int[8];

            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }

            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
            Console.ReadLine();
        }

        private static void Task3()
        {
            double[] array = new double[8] { 1.2, 3.4, 5.6, 7.8, 9.1, 0.1, 1.1, 2.1 };

            double max = array[0];
            double min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            double diff = max - min;
            Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + diff);
            Console.ReadLine();
        }
    }
}
