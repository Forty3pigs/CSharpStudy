// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

//using Task34;

namespace Geekbrains
{
    static public class Homework
    {
        static public void Main(string[] args)
        {
            Console.Clear();
            ConsoleKeyInfo choise;
            Console.WriteLine("Press:   1 for start task1 \n \t 2 for start task2 \n \t 3 for start task3 \nOr any other key for quit");
            choise = Console.ReadKey();
            if (choise.Key == ConsoleKey.D1)
            {
                Console.WriteLine("\nЗадача 34: Задайте массив заполненный случайными положительными трёхзначными числами. ");
                Console.WriteLine("Напишите программу, которая покажет количество чётных чисел в массиве.");
                Console.WriteLine("\nДля продолжения нажмите любую клавишу");
                Console.ReadKey();
                var t1 = new Task34();
                t1.solution();
            }
            if (choise.Key == ConsoleKey.D2)
            {
                Console.WriteLine("\nЗадача 36: Задайте одномерный массив, заполненный случайными числами.");
                Console.WriteLine("Найдите сумму элементов, стоящих на нечётных позициях.");
                Console.WriteLine("\nДля продолжения нажмите любую клавишу");
                Console.ReadKey();
                var t2 = new Task36();
                t2.solution();
            }
            if (choise.Key == ConsoleKey.D3)
            {
                Console.WriteLine("\nЗадача 38: Задайте массив вещественных чисел.");
                Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива.");
                Console.WriteLine("\nДля продолжения нажмите любую клавишу");
                Console.ReadKey();
                var t3 = new Task38();
                t3.solution();
            }
            else return;
        }
    }
    class Arrays
    {
        public static int AskSize()
        {
            Console.Clear();
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            return size;
        }
        public int[] CreateArray(int size, int digitQuantity)
        {
            int[] array = new int[size];
            int start = Convert.ToInt32(Math.Pow(10, digitQuantity - 1));
            int end = Convert.ToInt32(Math.Pow(10, digitQuantity));
            Console.WriteLine("\nArray generated: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(start, end);

                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
            return array;
        }
        public int[] CreateArray(int size)
        {
            int[] array = new int[size];
            int start = -999;
            int end = 1000;
            Console.WriteLine("\nArray generated: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(start, end);
                // Нужно исключить значения (-100; 100)
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
            return array;
        }
        public double[] CreateArray(int size, bool d)
        {
            double[] array = new double[size];
            int start = -999;
            int end = 1000;
            Random rand = new Random();
            Console.WriteLine("\nArray generated: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(start, end) + rand.NextDouble();

                Console.Write($"\n{array[i]} ");
            }
            Console.WriteLine("");
            return array;
        }
    }

}