namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //            Math.Pow(number, 2); // number в степени 2
            //             
            int square = number * number;
            number *= number;
            Console.WriteLine("Квадрат " + square);
            Console.WriteLine($"Квадрат числа: {number}");
        }
    }
}
