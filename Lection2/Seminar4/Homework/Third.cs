namespace Geekbrains
{
    public class Task38
    {
        public void solution()
        {
            bool isDouble = true;
            int size = Arrays.AskSize();
            double[] array = new Arrays().CreateArray(size, isDouble);
            MinMaxDiff(array);

        }
        public void MinMaxDiff(double[] array)
        {
            double min = array[0];
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];

            }
            Console.WriteLine($"\nThe difference between Max({max}) and Min({min}) = {(max - min)} \n");
        }

    }
}