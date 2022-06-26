// Напишите программу вывода модуля числа
try
{
    Console.WriteLine("Enter a number");
    if (int.TryParse(Console.ReadLine(), out int abs))
        Console.WriteLine($"Absolut of {abs} = {Math.Abs(abs)}");
}
catch
{
    Console.WriteLine("Huston, we have a trouble");
}
