using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
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
            Console.WriteLine("Введите количество строк: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int n = int.Parse(Console.ReadLine());

            double[,] arr = new double[m, n]; 

            Random rnd = new Random(); 

            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.NextDouble();
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void Task2()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

            Console.Write("Введите номер строки: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Введите номер столбца: ");
            int col = int.Parse(Console.ReadLine()); 

            if (row < 0 || row >= arr.GetLength(0) || col < 0 || col >= arr.GetLength(1))
            {
                Console.WriteLine("Такого элемента нет.");
            }
            else
            {
                Console.WriteLine("Значение элемента: " + arr[row, col]);
            }

            Console.ReadLine();
        }
        private static void Task3()
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += arr[i, j];
                }
                double avg = (double)sum / rows;
                Console.WriteLine($"Среднее арифметическое столбца {j}: {avg}");
            }
            Console.ReadLine();
        }
    }
}
