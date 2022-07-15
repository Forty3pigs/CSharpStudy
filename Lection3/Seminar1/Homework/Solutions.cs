namespace Geekbrains
{
    public class Task47
    {
        private string invitationParam = "size of array";
        private int startArray = -1000;
        private int endArray = 1000;
        public void Solution()
        {
            TaskText.InputInvitation(invitationParam);
            InputProcessing inp = new InputProcessing();
            string? size = Console.ReadLine();
            if (inp.InputCheck(size) != inp.errorMsg)
            {
                int[] arraySize = inp.ConvertToInt(inp.SplitInput(size)); // Как упростить эту запись?
                if (arraySize.Length == 2)
                {
                    Arrays arr = new Arrays();
                    arr.PrintArray(arr.CreateArray(arraySize[0], arraySize[1], startArray, endArray));
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
                    double[,] array = arr.CreateArray(rand.Next(minArraySize, maxArraySize + 1), rand.Next(minArraySize, maxArraySize + 1), startArray, endArray);
                    arr.PrintArray(array);
                    if (elemPos[0] < array.GetLength(0) && elemPos[1] < array.GetLength(1))
                    {
                        Console.WriteLine($"\nElement in {elemPos[0]},{elemPos[1]} position is " + string.Format("{0,5:N2} ", array[elemPos[0], elemPos[1]]));
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
        public void Solution()
        {

        }
    }
}