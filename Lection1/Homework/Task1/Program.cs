//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
while (true)
{
    Console.Write("Enter first number: ");
    string text1 = Console.ReadLine();
    if (int.TryParse(text1, out int first))
    {
        Console.Write("Enter second number: ");
        string text2 = Console.ReadLine();
        if (int.TryParse(text2, out int second))
        {
            if (first == second)
            {
                Console.WriteLine(" ");
                Console.WriteLine(first + " is equal " + second);
                Console.WriteLine(" ");
                break;
            }
            if (first > second)
            {
                Console.WriteLine(" ");
                Console.WriteLine(first + " is greater than " + second);
                Console.WriteLine(" ");
                break;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(second + " is greater than " + first);
                Console.WriteLine(" ");
                break;
            }
        }
        else
        {
            Console.WriteLine("is not a number. ");
        }

    }
    else
    {
        Console.WriteLine("is not number. ");
    }
}
