using System;

namespace KR
{
    partial class Program
    {
        static void Задача5()
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();

            // Проверка на пустую строку
            if (string.IsNullOrEmpty(s)) 
            {
                Console.WriteLine("(нет)");
                return; // Выходим из метода, дальше не идем
            }

            int half = s.Length / 2; // Делим длину пополам 
            string result = s.Substring(0, half); // Берем первые символы

            if (result == "")
                Console.WriteLine("(нет)");
            else
                Console.WriteLine(result);
        }
    }
}