// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

namespace Geekbrains
{
    class Homework
    {
        static void Main(string[] args)
        {
            void Distance(double xa, double ya, double za, double xb, double yb, double zb)
            {
                Console.WriteLine("Distance is " + Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2)));
            }
            Console.Write("Enter xa number: ");
            double xa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter ya number: ");
            double ya = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter za number: ");
            double za = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter xb number: ");
            double xb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter yb number: ");
            double yb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter zb number: ");
            double zb = Convert.ToDouble(Console.ReadLine());
            Distance(xa, ya, za, xb, yb, zb);
        }
    }

}
