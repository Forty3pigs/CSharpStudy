// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("All non numeric simbols will be equal to 0 ");
Console.Write("Enter the number: ");
int.TryParse(Console.ReadLine(), out int number);

if (number % 2 == 0) { Console.Write("Y"); }
else { Console.Write("N"); }