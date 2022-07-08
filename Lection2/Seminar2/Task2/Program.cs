// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

namespace Geekbrains
{
    class Homework
    {
        static void Main(string[] args)
        {
            try
            {
                int max = Int32.MaxValue;
                int min = Int32.MinValue;
                Console.WriteLine("Введите номер четверти: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.WriteLine($"Диапазон 1 четверти: 0 < X < {max} и 0 < Y < {max}");
                }

                else if (num == 2)
                {
                    Console.WriteLine($"Диапазон 2 четверти: {min} < X < 0 и 0 < Y < {max}");
                }

                else if (num == 3)
                {
                    Console.WriteLine($"Диапазон 3 четверти: {min} < X < 0 и {min} < Y < 0");
                }
                else if (num == 4)
                {
                    Console.WriteLine($"Диапазон 4 четверти: 0 < X < {max} и {min} < Y < 0");
                }
                else
                {
                    Console.WriteLine("Диапазона не существует");
                }
                Console.ReadKey();

            }
            catch
            {
                Console.Write("Введите нужное значение");
            }

        }
    }
}
