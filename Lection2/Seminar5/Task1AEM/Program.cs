// 1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

namespace Geekbrains
{
    static public class Task1
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
            Arrays arr1 = new Arrays();
            int[] arr112 = arr1.GenerateRandomArray(min, max, Length);
            if (min <= max && Length > 0)
            {
                arr1.PrintArray(arr112);
                arr112 = arr1.ReverseArray(arr112);
                Console.WriteLine();
                arr1.PrintArray(arr112);
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