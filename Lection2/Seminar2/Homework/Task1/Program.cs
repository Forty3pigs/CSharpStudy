// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// В данном частном случае можно просто:
// string str = Console.ReadLine();
// if (str[0] == str[4] && str[1] == str[3])
// { Console.Write("Yes"); }
// else Console.Write("No");


namespace Geekbrains
{
    class Homework
    {
        static void PalindromeCheck(string? input)
        {
            bool answer = true;
            for (int i = 0; i < (input.Length / 2); i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    answer = true;
                    // Console.WriteLine($"{input[i]}, {input[input.Length - 1 - i]}, {answer}");
                }
                else
                {
                    answer = false;
                }

                answer = answer && true;
                // Console.WriteLine(answer);
            }
            if (answer == true)
            {
                Console.Write($"{input} is polindrome");
            }
            else
            {
                Console.Write($"{input} is not polindrome");
            }

        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 5-digit number: ");
                string input = Console.ReadLine();

                if (input.Length == 5) PalindromeCheck(input);

                else Console.Write($"{input} is not 5-digit number!");
            }
            catch
            {
                Console.Write("Exeption");
            }
        }

    }

}