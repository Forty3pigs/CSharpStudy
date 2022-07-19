namespace Geekbrains
{
    static public class Homework8
    {
        static public void Main()
        {
            Console.Clear();
            ConsoleKeyInfo choise;
            TextAndMessage tm = new TextAndMessage();
            tm.PrintIntro();
            choise = Console.ReadKey();
            LunchTask(choise, tm);
        }

        public static void LunchTask(ConsoleKeyInfo ch, TextAndMessage tm)
        {
            if (ch.Key == ConsoleKey.D1)
            {
                Console.Clear();
                tm.Text54();
                //tm.TextWait();
                var t = new Task54();
                t.Solution(tm);
            }
            if (ch.Key == ConsoleKey.D2)
            {
                Console.Clear();
                tm.Text56();
                //tm.TextWait();
                var t = new Task56();
                t.Solution(tm);
            }
            // if (ch.Key == ConsoleKey.D3)
            // {
            //     Console.Clear();
            //     tm.Text58();
            //     //tm.TextWait();
            //     var t = new Task58();
            //     t.Solution();
            // }
            if (ch.Key == ConsoleKey.Escape)
            {
                return;
            }
            else Main(); //return;
        }
    }
}
