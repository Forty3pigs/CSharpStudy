// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0, 0, 1)
// 45(1, 0, 0) 53(1, 0, 1)

namespace Geekbrains
{
    static public class Homework
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Введите ширину массива");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту массива");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите глубину массива");
            int z = Convert.ToInt32(Console.ReadLine());
            int[,,] arr = new int[x, y, z];
            int value = 10;     //первое 2значное число
            if (x * y * z < 89) // проверка размеров массива, чтоб уникальных чисел хватило
            {
                // Ну это просто шуточное решение. Числа подряд действительно уникальные.
                Console.WriteLine("\nУсловия соблюдены, значения уникальны :)");
                CreateArray(arr, value);
                PrintArray(arr);
                Console.WriteLine("Нажми на кнопку, полчишь результат"
                                + " твоя мечта осущеcтвится...");
                Console.ReadKey();

                // а вот тут "нормальное" решение
                Console.WriteLine("А вот тут какой-никакой рандом");
                int[] rand2Digits = new int[90];        //генерим массив длиной 90 для всех 2значных чисел подряд.
                randomizedDigits(rand2Digits);          //загоняем в рандомилку. см. описание метода
                CreateRandArray(arr, rand2Digits, 0);   //создаём массив
                PrintArray(arr);                        //печатаем

            }
            else { Console.WriteLine("I don't have so many unique 2digit numbers"); }

        }

        public static void CreateArray(int[,,] array, int value)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = value++;
                    }
                }
            }
        }

        public static void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine();
                    Console.Write("  ");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// <c>randomizedDigits</c> принимает на вход одномерный пустой массив длиной 90
        /// заполняет его линейно. Дальше истерично свапает попарно в нём числа по 2 рандомным позициям.
        /// Из-за того, что это попарный свап, все значения уникальны и их максимальное кол-во.
        /// </summary>
        public static void randomizedDigits(int[] rand1D)
        {
            Random rand = new Random();
            int val, ind1, ind2;
            for (int i = 0; i < 90; i++)
            {
                rand1D[i] = i + 10;
            }
            for (int i = 0; i < 8100; i++)
            {
                ind1 = rand.Next(0, 90);
                ind2 = rand.Next(0, 90);

                val = rand1D[ind1];
                rand1D[ind1] = rand1D[ind2];
                rand1D[ind2] = val;
            }
        }

        /// <summary>
        /// <c>CreateRandArray</c> принимает на вход трехмерный массив и
        /// заполняет его последовательно дёргая из измученного рандом-свапом 
        /// одномерного массива значения.
        /// </summary>
        /// <param name = "val"> стартовое значение индекса 1Д-массива. </param> 
        public static void CreateRandArray(int[,,] array, int[] randDig, int val)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = randDig[val++];
                    }
                }
            }
        }

    }
}
