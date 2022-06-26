// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

try
{
    Console.WriteLine("Enter a three-digit number");
    string str = Console.ReadLine();
    //    if (Char.IsDigit(str, 2))
    if ((int.TryParse(str, out int val) && str.Length == 3))
        Console.WriteLine(str[2]);
    else Console.WriteLine("Wrong input");
}

catch
{
    Console.WriteLine("Huston, we have a trouble");
}

// if ((int.TryParse(str, out int val) && str.Lenght == 3)