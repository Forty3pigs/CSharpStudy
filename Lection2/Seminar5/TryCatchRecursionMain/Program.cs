// Делаем рекурсивный вызов Мейна для проверки корректности данных
// При вводе 0 получается деление на 0, ловим эксепшн и завершаем программу

namespace Geekbrains
{
    static public class Seminar
    {
        static public void Main()
        {
            try
            {
                Console.WriteLine("Enter number");
                string? str = Console.ReadLine();
                int num = Convert.ToInt32(str);
                num = 6 / num;

            }
            catch (FormatException ex)
            {
                Console.Write("Wrong input called ", ex);
                Main();

            }
            catch (DivideByZeroException)
            {
                Console.Write("Divide Zero");
            }


        }
    }
}

