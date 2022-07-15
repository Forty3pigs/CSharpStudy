namespace Geekbrains
{
    class Arrays
    {
        public double[,] CreateArray(int columns, int rows, int start, int end)
        {
            double[,] arr = new double[columns, rows];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Random rand = new Random();
                    arr[i, j] = rand.Next(start, end) + rand.NextDouble(); //Math.Round(, 2)
                }
            }
            return arr;
        }
        public void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //Console.Write($"{array[i, j],-8}");
                    Console.Write(string.Format("{0,8:N2} ", array[i, j])); // Выравнивание по 8 символам
                }
                Console.WriteLine();
            }
        }
    }
}