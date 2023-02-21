using System;

class Program
{
    static void Main(string[] args)
    {
        #region Задача1
        Console.Write("Введите трехзначное число: ");
        int num = int.Parse(Console.ReadLine());
        int secondDigit = (num / 10) % 10;
        Console.WriteLine($"Вторая цифра числа {num} равна {secondDigit}");
        Console.ReadLine();
        #endregion

        #region Задача2

        Console.Write("Введите число: ");
        int num1 = int.Parse(Console.ReadLine());
        if (num1 >= 100 && num1 <= 999)
        {
            int thirdDigit = num1  % 10;
            Console.WriteLine($"Третья цифра числа {num1} равна {thirdDigit}");
        }
        else
        {
            Console.WriteLine($"У числа {num1} нет третьей цифры");
        }
        Console.ReadLine();
        #endregion

        #region Задача3
        Console.Write("Введите день недели (1-7): ");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Этот день выходной!");
        }
        else
        {
            Console.WriteLine("Этот день не выходной.");
        }

        Console.ReadLine();
        #endregion
    }
}