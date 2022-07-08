namespace Geekbrains
{
    public class Task36
    {
        public void solution36()
        {
            int size = Arrays.AskSize();
            int[] array = new Arrays().CreateArray(size);
            InOddsSum(array);

        }
        static public void InOddsSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) sum += array[i];
            }
            Console.WriteLine($"\nSum of the odds positions = {sum} \n");
        }
    }
}