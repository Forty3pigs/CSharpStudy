// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

namespace Geekbrains
{
    class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day number: ");
            string? str = Console.ReadLine();

            if (int.TryParse(str, out int val))
            {
                if (val > 0 && val < 8)
                {
                    if (val == 6 || val == 7)
                        Console.WriteLine("It's holyday!!");
                    else
                        Console.WriteLine(":'(");

                }
                else Console.WriteLine("There is no spoon");
            }
            else Console.WriteLine("Wrong input");

        }
    }

}