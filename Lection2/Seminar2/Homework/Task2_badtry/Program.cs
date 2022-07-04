// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
// {
//   ТелоМетода;
//   return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }
// Если без return, то вместо ВозвращаемыйТипДанных пишется void

namespace Geekbrains
{
    class InputConverter
    {
        public double[] InputSplit(string str, char separator)
        {
            if (str != null)
            {
                // Убираем лишнее, оставляем разделение координат через ;
                str = str.Trim().Replace(" " + separator + " ", ",").Replace(" " + separator + "", "" + separator + "").Replace("" + separator + " ", "" + separator + "").Replace(" ", ";");

                // Разбираем строку на части и переводим в массив double[]
                string[] strCoord = str.Split(';');
                double[] dCoord = new double[strCoord.Length];

                for (int i = 0; i < strCoord.Length; i++)
                {
                    if (double.TryParse(strCoord[i], out double dig))
                        dCoord[i] = dig;
                }
                return dCoord;

            }
            else return null;
        }
    }
    class Homework
    {
        static void Main(string[] args)
        {
            Console.Clear();
            char separator = ';';  // Указываем используемый разделитель.

            Console.WriteLine("All non numeric simbols will be equal to 0 ");
            Console.Write("Enter first point coordinates separated by a space or semicolon: ");
            string? CoordinatesA = Console.ReadLine();
            var s = new InputConverter();
            double[] pointA = s.InputSplit(CoordinatesA, separator);

            Console.Write("Enter second point coordinates separated by a space or semicolon: ");
            string? CoordinatesB = Console.ReadLine();
            double[] pointB = s.InputSplit(CoordinatesB, separator);

            //AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
            double? distance = Math.Sqrt(Math.Pow((pointB[0] - pointA[0]), 2) + Math.Pow((pointB[1] - pointA[1]), 2) + Math.Pow((pointB[2] - pointA[2]), 2));
            Console.Write("Distance is " + distance);
        }


    }
}