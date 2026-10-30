using System;

namespace KR
{
    partial class Program
    {
        static void Задача2()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            int c = int.Parse(Console.ReadLine());

            if (a == b || a == c || b == c)
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");
        }
    }
}