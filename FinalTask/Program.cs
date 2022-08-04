namespace Geekbrains
{
    ///<include file='info.xml' path='docs/FHW/helps[@name="FHW"]/*'/>
    static public class FHW
    {
        ///<include file='info.xml' path='docs/FHW/helps[@name="Main"]/*'/>
        static public void Main()
        {
            Less4Array(Choise(false));
        }
        ///<include file='info.xml' path='docs/FHW/helps[@name="Less4Array"]/*'/>
        public static void Less4Array(string[] arr1)
        {
            string[] arr2 = new string[arr1.Length];
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].Length < 4)
                {
                    arr2[count] = arr1[i];
                    count++;
                }
            }
            Array.Resize(ref arr2, count);
            Console.WriteLine();
            Console.WriteLine($"В результате получился массив: [ {string.Join(", ", arr2)} ]");
        }
        ///<include file='info.xml' path='docs/FHW/helps[@name="Choise"]/*'/>
        public static string[] Choise(bool presets)

        {
            MyArray arr = new MyArray();
            ConsoleKeyInfo pressed = new ConsoleKeyInfo();

            if (!presets)
            {
                Console.WriteLine("Нажмите 1 для выбора стандартных массивов или 2 для введения собственного");
                pressed = Console.ReadKey();

                switch (pressed.Key)
                {
                    case ConsoleKey.D1:
                        return Choise(true);

                    case ConsoleKey.D2:
                        return arr.InputArray();
                    default:
                        return Choise(true);
                }
            }
            else
            {
                Console.WriteLine("\nНажмите 1 для выбора массива [\"hello\", \"2\", \"world\", \":-)\"]" +
                                    "\n\t2 для выбора массива [\"1234\", \"1567\", \"-2\", \"computer science\"]" +
                                    "\n\t3 для выбора массива [\"Russia\", \"Denmark\", \"Kazan\"]");
                pressed = Console.ReadKey();

                switch (pressed.Key)
                {
                    case ConsoleKey.D1:
                        return arr.Preset0;

                    case ConsoleKey.D2:
                        return arr.Preset1;

                    case ConsoleKey.D3:
                        return arr.Preset2;
                    default:
                        return arr.Preset0;
                }
            }

        }
    }
}
