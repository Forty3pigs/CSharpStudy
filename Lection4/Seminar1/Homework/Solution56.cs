namespace Geekbrains
{
    public class Task56
    {
        private string _invParam = "size of array";
        private int _startArray = -9;
        private int _endArray = 10;
        public void Solution(TextAndMessage tm)
        {
            tm.InputInvitation(_invParam);
            string? strArraySize = Console.ReadLine();
            InputProcessing inp = new InputProcessing();
            if (inp.InputValidation(strArraySize, tm))
            {
                int curArraySize = Convert.ToInt32(strArraySize);
                Arrays arr = new Arrays();
                int[,] curArray = arr.CreateArrayInt(curArraySize, curArraySize, _startArray, _endArray);
                arr.PrintArray(curArray);
                Console.WriteLine();
                //tm.TextWait();
                for (int i = 0; i < curArray.GetLength(0); i++)
                {
                    int[] tmp = new int[curArray.GetLength(1)];
                    for (int j = 0; j < curArray.GetLength(1); j++)
                    {
                        tmp[j] = curArray[i, j];
                    }
                    Array.Sort(tmp);
                    for (int j = 0; j < curArray.GetLength(1); j++)
                    {
                        curArray[i, j] = tmp[j];
                    }
                }
                arr.PrintArray(curArray);
                tm.TextWait();
            }

            else
            {
                Solution(tm);
            }
        }
    }
}

