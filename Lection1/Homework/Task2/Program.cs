// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("All non numeric simbols will be equal to 0 ");
Console.Write("Enter first number: ");
int.TryParse(Console.ReadLine(), out int first);

Console.Write("Enter second number: ");
int.TryParse(Console.ReadLine(), out int second);

Console.Write("Enter third number: ");
int.TryParse(Console.ReadLine(), out int third);


if (first >= second)
{
    if (first >= third)
    {
        Console.WriteLine(" ");
        Console.WriteLine("The biggest number is: " + first);
        Console.WriteLine(" ");
    }
}
else
{
    if (second >= third)
    {
        Console.WriteLine(" ");
        Console.WriteLine("The biggest number is: " + second);
        Console.WriteLine(" ");
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("The biggest number is: " + third);
        Console.WriteLine(" ");
    }
}
