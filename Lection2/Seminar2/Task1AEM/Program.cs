// Задача 1.Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//      2 | 1
//      3 | 4


namespace Geekbrains
{
    class Seminar2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Caution: \n All non numeric simbols will be equal to 0 \n ");
            Console.Write("Enter the coordinates separated by a space or semicolon: ");
            string? str = Console.ReadLine();
            try
            {
                if (str != null)
                {
                    // Убираем лишнее, оставляем разделение координат через ;
                    str = str.Trim().Replace(" ; ", ";").Replace(" ;", ";").Replace("; ", ";").Replace(" ", ";");
                    Console.WriteLine(str);             // отладочный вывод
                    string[] strCoord = str.Split(';'); // делим строку по разделителю ;
                    if (strCoord.Length == 2)           // так как у нас система координат XY, то подходящий ввод
                                                        // - только 2 координаты.
                    {
                        // переводим координаты в double и проверяем в какой части сетки будет точка
                        if (double.Parse(strCoord[0]) > 0 && double.Parse(strCoord[1]) > 0)
                            Console.Write("First quarter");
                        else if (double.Parse(strCoord[0]) < 0 && double.Parse(strCoord[1]) > 0)
                            Console.Write("Second quarter");
                        else if (double.Parse(strCoord[0]) < 0 && double.Parse(strCoord[1]) < 0)
                            Console.Write("Third quarter");
                        else if (double.Parse(strCoord[0]) > 0 && double.Parse(strCoord[1]) < 0)
                            Console.Write("Fourth quarter");
                        else Console.Write("Something goes wrong");

                    }
                    else Console.Write("Wrong input");
                }
            }
            catch
            {
                Console.Write("Exeption");
            }
        }
    }

}

// " ", " ;", " ; ", "; ", ""