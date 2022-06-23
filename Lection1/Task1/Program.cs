// Выводит название дня недели по полученному из консоли номеру

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер дня недели: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            if (number < 8)
            {
                if (number == 1)
                {
                    Console.WriteLine("Понедельник");
                }
                if (number == 2)
                {
                    Console.WriteLine("Вторник");
                }
                if (number == 3)
                {
                    Console.WriteLine("Среда");
                }
                if (number == 4)
                {
                    Console.WriteLine("Четверг");
                }
                if (number == 5)
                {
                    Console.WriteLine("Пятница");
                }
                if (number == 6)
                {
                    Console.WriteLine("Суббота");
                }
                if (number == 7)
                {
                    Console.WriteLine("Воскресенье");
                }
            }
            else { Console.WriteLine("Номер больше 7"); }
        }
        else { Console.WriteLine("Номер меньше 1"); }
    }
}