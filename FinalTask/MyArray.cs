namespace Geekbrains
{
    ///<include file='info.xml' path='docs/MyArray/helps[@name="MyArray"]/*'/>
    public class MyArray
    {
        public string[] Preset0 { get; } = { "hello", "2", "world", ":-)" };
        public string[] Preset1 { get; } = { "1234", "1567", "-2", "computer science" };
        public string[] Preset2 { get; } = { "Russia", "Denmark", "Kazan" };

        ///<include file='info.xml' path='docs/MyArray/helps[@name="InputArray"]/*'/>
        public string[] InputArray()
        {
            Console.WriteLine("\nВводите элементы построчно. Для завершения ввода, нажмите Enter при пустом поле ввода");
            string[] a = new string[0];
            int count = 0;
            while (true)
            {
                string? input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    return a;

                else
                {
                    Array.Resize(ref a, count + 1);
                    a[count] = input;
                    count++;
                }
            }
        }
    }
}