// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

namespace Geekbrains
{
    class Homework
    {
        static void Power(int A, int B)
        {
            Console.WriteLine($"{A}, {B} -> " + Math.Pow(A, B));

            int result = 1;
            for (int i = 1; i <= B; i++)
            {
                result *= A;
            }
            Console.WriteLine("Если сильно надо цикл, то всё равно " + result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("All non numerics will be 0 ");

            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out int first);
            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out int second);

            Power(first, second);

        }
    }

}