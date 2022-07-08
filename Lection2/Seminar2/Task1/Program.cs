// Задача 1.Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//      2 | 1
//      3 | 4

namespace Geekbrains
{
    class Homework
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("All non numeric simbols will be equal to 0 ");
                Console.Write("Enter first number: ");
                int.TryParse(Console.ReadLine(), out int first);
            }
            catch { Console.Write("Exeption"); }

        }
    }

}
