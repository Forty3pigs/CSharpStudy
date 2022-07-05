// Задача 29: Напишите программу, которая задаёт случайный массив случайного размера элементов 
// и выводит на экран массив квадратов этих чисел.

// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]

//  ??? Опечатка в 1м примере: 1 * 1 = 2 ???

namespace Geekbrains
{
    class Homework
    {
        static void Main(string[] args)
        {
            Console.Write("Enter max array lenght: ");
            int size = Convert.ToInt32(Console.ReadLine());
            CreateArray(size);

        }
        static int[] CreateArray(int s)
        {
            int size = new Random().Next(1, s);     // рандомим размер массива от 1 до введённого
            int[] array = new int[size];
            int[] arraySqr = new int[size];
            for (int i = 0; i < size; i++)
            {
                // чтобы не вылезти за границы Int во втором массиве, заполняем первый массив
                // от 1 до корня из максимального значения Int
                array[i] = new Random().Next(1, Convert.ToInt32(Math.Sqrt(Int32.MaxValue)));
                arraySqr[i] = Convert.ToInt32(Math.Pow(array[i], 2));

                // Делаем вывод обоих массивов в столбик с помощью табуляции и перевода каретки
                Console.Write($"{array[i]} \t {arraySqr[i]} \n");
            }
            return array; // а вдруг пригодится :)
        }
    }
}
