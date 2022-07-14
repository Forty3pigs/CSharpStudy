// 2. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

namespace Geekbrains
{
    static public class Task2
    {
        static public void Main(string[] args)
        {
            int[,] array = new int[4, 3];
            int result = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 11);
                    Console.Write($"{array[i, j]} \t ");
                }
                Console.WriteLine("\n\n");
            }

            for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
            {
                result += array[i, i];
            }
            Console.WriteLine(result);
        }
    }

}