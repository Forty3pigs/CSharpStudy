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
                break;
            }
            else if (first > second)
            {
                Console.WriteLine(" ");
                Console.WriteLine(first + " is greater than " + second);
                break;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(second + " is greater than " + first);
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
        Console.WriteLine(" is not number. ");
    }
}


// int first = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int second = Convert.ToInt32(Console.ReadLine());
// if (first > second)
// {
//     Console.WriteLine(first + " is greater than " + second);
// }
// else
// {
//     Console.WriteLine(second + " is greater than " + first);
// }

// while (true)
// {
//     Console.Write("Введите число: ");
//    string text = Console.ReadLine();
//    if (int.TryParse(text, out int number))
//     {
//         Console.WriteLine("Вы ввели число {0}", number);
//         break;
//     }
//     Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
// }