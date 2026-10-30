using System;

namespace KR
{
    partial class Program
    {
        static void Задача6()
        {
           
            Console.WriteLine(Average(new int[] { 1, 2, 3 })); 
            Console.WriteLine(Average(new int[] { 5, 5 }));   
            Console.WriteLine(Average(new int[] { }));       
        }

      
        static double Average(int[] a)
        {
            if (a.Length == 0) 
                return 0;     

            double sum = 0;   // наше среднее
            
            foreach (int x in a) // Перебираем все элементы массива
            {
                sum += x;      // Добавляем элемент к сумме
            }
            
            return sum / a.Length; // Делим сумму на количество элементов
        }
    }
}