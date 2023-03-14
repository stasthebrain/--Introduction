using System;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Console.ReadLine();
        Console.Clear();
        Task2();
        Console.ReadLine();
        Console.Clear();
        Task3();
        Console.ReadLine();
    }
    static void Task1()
    {
        Console.Write("Задача 1. ");
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = new int[5];
        for (int i = 4; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        bool isPalindrome = true;
        for (int i = 0; i < 2; i++)
        {
            if (digits[i] != digits[4 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    static void Task2()
    {
        Console.Write("Задача 2. ");
        Console.WriteLine("Введите координаты первой точки: ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double z1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки: ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double z2 = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"Расстояние между двумя точками: {distance}");
    }
    static void Task3()
    {
        Console.Write("Задача 3. ");
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 0)
        {
            Console.WriteLine("Таблица кубов чисел:");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}^3 = {i * i * i}");
            }
        }
        else
        {
            Console.WriteLine($"Таблица кубов чисел от {n} до -1:");
            for (int i = n; i <= -1; i++)
            {
                Console.WriteLine($"{i}^3 = {i * i * i}");
            }
        }
    }
}
