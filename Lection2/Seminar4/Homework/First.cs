namespace Geekbrains
{
    public class Task34
    {
        public void solution34()
        {
            int size = Arrays.AskSize();
            Console.Write("Enter digit capacity: ");
            int digitCapacity = Convert.ToInt32(Console.ReadLine());
            int[] array = new Arrays().CreateArray(size, digitCapacity);
            EvenCount(array);

        }
        static public void EvenCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            Console.WriteLine($"\nEvens quantity in this array = {count} \n");
        }
    }

}

