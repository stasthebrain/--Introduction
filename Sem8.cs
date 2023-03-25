using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }

        private static void Task1()
        {
            int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = j + 1; k < arr.GetLength(1); k++)
                    {
                        if (arr[i, k] > arr[i, j])
                        {
                            int temp = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void Task2()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int minSum = int.MaxValue;
            int minSumRow = -1;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                if (sum < minSum)
                {
                    minSum = sum;
                    minSumRow = i;
                }
            }

            Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");

            Console.ReadLine();
        }

        private static void Task3()
        {
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } }; 
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } }; 

            int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; 

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j]; 
                    }
                    product[i, j] = sum; 
                }
            }

            Console.WriteLine("Произведение матриц:");
            for (int i = 0; i < product.GetLength(0); i++)
            {
                for (int j = 0; j < product.GetLength(1); j++)
                {
                    Console.Write($"{product[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void Task4()
        {
            int[,,] arr = new int[5, 3, 2]; 

            int num = 10;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = num++;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"[{i},{j},{k}] = {arr[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void Task5()
        {
            int[,] array = new int[4, 4];

            int num = 1; 
            int row = 0; 
            int col = 0;

            while (num <= 16) 
            {
                for (int i = col; i < 4 - col; i++)
                {
                    array[row, i] = num;
                    num++;
                }
                row++;

                for (int i = row; i < 4 - row; i++)
                {
                    array[i, 4 - col - 1] = num;
                    num++;
                }
                col++;

                for (int i = 4 - col - 1; i >= col - 1; i--)
                {
                    array[4 - row - 1, i] = num;
                    num++;
                }
                row++;

                for (int i = 4 - row - 1; i >= row - 1; i--)
                {
                    array[i, col - 1] = num;
                    num++;
                }
                col++;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
            }
        }
    }
}
