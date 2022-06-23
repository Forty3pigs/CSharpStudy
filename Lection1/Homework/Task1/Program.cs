//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Enter first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second)
{
    Console.WriteLine(first + " is greater than " + second);
}
else
{
    Console.WriteLine(second + " is greater than " + first);
}