// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

namespace Geekbrains
{
    class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All non numerics will be ignored ");
            Console.Write("Enter number: ");
            Sum(Console.ReadLine());
        }
        static void Sum(string n)
        {

            double.TryParse(n, out double result);
            result = 0;
            foreach (char i in n)
            {
                result = result + Char.GetNumericValue(i);
            }
            Console.WriteLine(result);

        }
    }

}