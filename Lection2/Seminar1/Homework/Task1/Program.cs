// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

namespace Geekbrains
{
    class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three-digit number");
            string? str = Console.ReadLine();

            if ((int.TryParse(str, out int val) && str.Length == 3))
            {
                Console.WriteLine($"Second digit of {str} is {str[1]}");                                // первый способ
                Console.WriteLine("Second digit of {0} is {1}", str, (val % 100) / 10);                 // второй способ
                Console.WriteLine("Second digit of " + str + " is " + (str.Remove(0, 1)).Remove(1, 1)); // ышо способ
            }
            else Console.WriteLine("Wrong input");

        }
    }

}