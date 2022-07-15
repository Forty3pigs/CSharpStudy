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
        public void Solution()
        {

        }
    }
    public class Task52
    {
        public void Solution()
        {

        }
    }
}