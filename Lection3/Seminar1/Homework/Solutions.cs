namespace Geekbrains
{
    public class Task47
    {
        private string invitationParam = "size of curArray";
        private int startArray = -1000;
        private int endArray = 1000;
        public void Solution()
        {
            TaskText.InputInvitation(invitationParam);
            InputProcessing inp = new InputProcessing();
            string? size = Console.ReadLine();
            if (inp.InputCheck(size) != inp.errorMsg)
            {
                int[] curArraySize = inp.ConvertToInt(inp.SplitInput(size)); // Как упростить эту запись?
                if (curArraySize.Length == 2)
                {
                    Arrays arr = new Arrays();
                    arr.PrintArray(arr.CreateArray(curArraySize[0], curArraySize[1], startArray, endArray));
                    TaskText.TextWait();
                }
                else
                {
                    Console.WriteLine(inp.errorMsg);
                    return;
                }
            }
            else
            {
                Console.WriteLine(inp.errorMsg);
                return;
            }

        }

    }
    public class Task50
    {
        private string invitationParam = "element position";
        private int startArray = -1000;
        private int endArray = 1000;
        private int minArraySize = 4;
        private int maxArraySize = 12;

        public void Solution()
        {
            TaskText.InputInvitation(invitationParam);
            InputProcessing inp = new InputProcessing();
            string? position = Console.ReadLine();
            if (inp.InputCheck(position) != inp.errorMsg)
            {
                int[] elemPos = inp.ConvertToInt(inp.SplitInput(position)); // Как упростить эту запись?
                if (elemPos.Length == 2)
                {
                    Arrays arr = new Arrays();
                    Random rand = new Random();
                    double[,] curArray = arr.CreateArray(rand.Next(minArraySize, maxArraySize + 1), rand.Next(minArraySize, maxArraySize + 1), startArray, endArray);
                    arr.PrintArray(curArray);
                    if (elemPos[0] < curArray.GetLength(0) && elemPos[1] < curArray.GetLength(1))
                    {
                        Console.WriteLine($"\nElement in {elemPos[0]},{elemPos[1]} position is " + string.Format("{0,5:N2} ", curArray[elemPos[0], elemPos[1]]));
                    }
                    else
                    {
                        Console.WriteLine($"\nElement in {elemPos[0]},{elemPos[1]} position is absent");
                    }
                    TaskText.TextWait();
                }
                else
                {
                    Console.WriteLine(inp.errorMsg);
                    return;
                }
            }
            else
            {
                Console.WriteLine(inp.errorMsg);
                return;
            }

        }
    }
    public class Task52
    {
        private int startArray = 0;
        private int endArray = 1000;
        private int minArraySize = 4;
        private int maxArraySize = 12;
        public void Solution()
        {
            Arrays arr = new Arrays();
            Random rand = new Random();
            int[,] curArray = arr.CreateArrayInt(rand.Next(minArraySize, maxArraySize), rand.Next(minArraySize, maxArraySize), startArray, endArray);
            arr.PrintArray(curArray);
            Console.WriteLine(new string('=', curArray.GetLength(1) * 9));
            Console.Write("\nAverage:");
            double result = 0.0;
            // Console.Write("\t");
            for (int j = 0; j < curArray.GetLength(1); j++)
            {

                for (int i = 0; i < curArray.GetLength(0); i++)
                {
                    result += curArray[i, j];

                }
                Console.Write(string.Format("{0,7:N2} ", result / curArray.GetLength(0)));
                result = 0.0;     //"{0,8:N2} ", array[i, j])
            }
            Console.WriteLine();
            TaskText.TextWait();


        }

    }
}
