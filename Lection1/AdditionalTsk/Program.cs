// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

try
{
    Console.WriteLine("Enter a three-digit number");
    string str = Console.ReadLine();
    if (Char.IsDigit(str, 2))
        Console.WriteLine(str[2]);
    else Console.WriteLine("Wrong input");
}

catch
{
    Console.WriteLine("Huston, we have a trouble");
}
// if (string.TryParse(text, out int str))
// string value = Convert.ToString(Console.ReadLine());
// }


// catch (OutOfMemoryException)
// {
//     Console.WriteLine("Huston, we have a trouble");
// }
// catch (ArgumentOutOfRangeException)
// {
//     Console.WriteLine("Huston, we have a trouble");
// }