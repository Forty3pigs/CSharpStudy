//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

namespace Geekbrains
{
    class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string? str = Console.ReadLine();

            if (int.TryParse(str, out int val))
            {
                if (str.Length > 2)
                {
                    Console.WriteLine($"Third digit of {str} is {str.Remove(3).LastOrDefault()}");  // 1st
                    Console.WriteLine($"Third digit of {str} is {str[2]}");                         // 2nd

                }
                else Console.WriteLine("There is no spoon");
            }
            else Console.WriteLine("Wrong input");

        }
    }

}