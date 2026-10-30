using System;

namespace KR
{
    partial class Program
    {
        static void Main(string[] args)
        {
          
           // Задача1();
            // Задача2();
            // Задача3();
           // Задача4();
          // Задача5();
          // Задача6();

        }

        static void Задача1()
        {
            Console.Write("Введите секунды: ");
            int seconds = int.Parse(Console.ReadLine());
            
            int h = seconds / 3600;
            int m = (seconds % 3600) / 60;
            int s = seconds % 60;
            
            Console.WriteLine($"{h} ч {m} мин {s} сек");
        }
    }
}