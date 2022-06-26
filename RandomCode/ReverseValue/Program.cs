// Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.
// Например:
// 2 -> 0,5 или 0,25 -> 4

Console.WriteLine("Enter a number");
if (double.TryParse(Console.ReadLine(), out double abs) && abs != 0)
    Console.WriteLine($"Reverse value of {abs} = {1 / abs}");
else Console.WriteLine("Wrong input");

