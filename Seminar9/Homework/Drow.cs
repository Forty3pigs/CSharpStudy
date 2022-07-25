namespace Geekbrains
{

    public class Drow
    {
        private int _choise = 0;

        public int? Navigation(int taskCount)
        {
            ConsoleKeyInfo pressed = new ConsoleKeyInfo();
            ChoisePosition(taskCount, _choise);
            //pressed = Console.ReadKey();

            while (pressed.Key != ConsoleKey.Enter)
            {
                pressed = Console.ReadKey();
                if (pressed.Key == ConsoleKey.UpArrow && _choise == 0)
                {
                    _choise = 0;
                }

                else if (pressed.Key == ConsoleKey.DownArrow && _choise < taskCount)
                {
                    _choise++;
                    ChoisePosition(taskCount, _choise);
                }

                else if (pressed.Key == ConsoleKey.DownArrow && _choise == taskCount)
                {
                    _choise = 0;
                    ChoisePosition(taskCount, _choise);
                }

                else if (pressed.Key == ConsoleKey.UpArrow && _choise > 0)
                {
                    _choise--;
                    ChoisePosition(taskCount, _choise);
                }
            }
            Console.Clear();
            Console.WriteLine("Drow choise = " + _choise);
            return _choise;
        }

        private void ChoisePosition(int taskCount, int arrowPosition)
        {
            for (int i = 0; i <= taskCount; i++)
            {
                Console.SetCursorPosition(39, 10 + i);
                Console.Write(" ");
                Console.SetCursorPosition(62, 10 + i);
                Console.Write(" ");
            }
            Console.SetCursorPosition(39, 10 + arrowPosition);
            Console.Write("\x10");
            Console.SetCursorPosition(62, 10 + arrowPosition);
            Console.Write("\x11");
            Console.SetCursorPosition(0, 0);
            //Console.SetCursorPosition(39, 10);
            // Console.Write("\x10");
            // Console.SetCursorPosition(62, 10);
            // Console.Write("\x11");
        }
    }
}