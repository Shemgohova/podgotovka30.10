using System;

namespace KR
{
    partial class Program
    {
        static void Задача4()
        {
            
            int[] arr = { 3, 1, 4, 2 }; 

            if (arr.Length < 2) 
            {
                Console.WriteLine("нет");
            }
            else
            {
               //копия массива чтобы не испортить тот
                int[] temp = (int[])arr.Clone(); 
                
                Array.Sort(temp);    // по возрастанию 
                Array.Reverse(temp); // Переворачиваем
                
            
                Console.WriteLine(temp[1]); 
            }
        }
    }
}