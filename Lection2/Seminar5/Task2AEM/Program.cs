//2. Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

namespace Geekbrains
{
    static public class Task2
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("All non numerics will be ignored ");
            Console.Write("Enter min number: ");
            int.TryParse(Console.ReadLine(), out int min);
            Console.Write("Enter max number: ");
            int.TryParse(Console.ReadLine(), out int max);
            Console.Write("Enter length number: ");
            int.TryParse(Console.ReadLine(), out int Length);
            Arrays arr = new Arrays();
            if (min <= max && Length > 0)
            {
                int[] newArr1 = arr.GenerateRandomArray(min, max, Length);
                arr.PrintArray(newArr1);
                Console.WriteLine();

                int[] newArr2 = arr.CopyNumByNum(newArr1);
                arr.PrintArray(newArr2);
            }

        }
    }
    public class Arrays
    {
        public int[] GenerateRandomArray(int minValue, int maxValue, int arrLength)
        {
            int[] arr = new int[arrLength];
            Random rand = new Random();
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = rand.Next(minValue, maxValue + 1);
            }
            return arr;
        }
        public int[] ReverseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            return arr;
        }
        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
        public int[] CopyNumByNum(int[] arr)
        {
            int[] resultArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                resultArray[i] = arr[i];
            }
            return resultArray;
        }
    }

}