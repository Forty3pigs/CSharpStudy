// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

namespace Geekbrains
{
    static public class Cubes
    {
        static public void nCube(double n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(Math.Pow(i, 3) + " ");
            }
        }
    }
    class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All non numerics will be ignored ");
            Console.Write("Enter N number: ");
            double.TryParse(Console.ReadLine(), out double N);
            Cubes.nCube(N);
        }
    }

}