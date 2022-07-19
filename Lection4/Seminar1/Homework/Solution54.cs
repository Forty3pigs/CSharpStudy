namespace Geekbrains
{
    public class Task54
    {
        private string _invParam = "size of array";
        private int _startArray = -9;
        private int _endArray = 10;
        public void Solution(TextAndMessage tm)
        {
            tm.InputInvitation(_invParam);
            InputProcessing inp = new InputProcessing();
            string? size = Console.ReadLine();
            if (!String.IsNullOrEmpty(size))
            {
                int[] curArraySize = inp.ConvertToInt(inp.SplitInput(size));
                if (curArraySize.Length == 2 && curArraySize[0] > 0 && curArraySize[1] > 0)
                {
                    Arrays arr = new Arrays();
                    int[,] curArray = arr.CreateArrayInt(curArraySize[0], curArraySize[1], _startArray, _endArray);
                    tm.GeneratedArray();
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
                    tm.ResultedArray();
                    arr.PrintArray(curArray);
                    tm.TextWait();
                }
                else
                {
                    tm.ErrorArraySize();
                    tm.TextWait();
                    Solution(tm);
                }
            }
            else
            {
                tm.ErrorEmptyInput();
                tm.TextWait();
                Solution(tm);
            }
        }
    }
}