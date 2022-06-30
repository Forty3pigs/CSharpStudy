// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("All non numeric simbols will be equal to 0 ");
Console.Write("Enter your number: ");
int.TryParse(Console.ReadLine(), out int numberN);
int i = 2;
if (numberN > 0)
{
    while (i < numberN)
    {
        Console.Write($"{i}, ");
        i = i + 2;
    }
}
else Console.Write("Too small");