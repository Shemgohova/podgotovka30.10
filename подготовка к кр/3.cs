using System;

namespace KR
{
    partial class Program
    {
        static void Задача3()
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                    sum += digit;
                n = n / 10;
            }

            Console.WriteLine(sum);
        }
    }
}