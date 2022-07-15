namespace Geekbrains
{
    public class InputProcessing
    {
        public string errorMsg = "Error.";
        public string InputCheck(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                return str;
            }
            else return errorMsg;
        }
        public int[] ConvertToInt(string[] strToConvert)
        {
            int[] parameters = new int[strToConvert.Length];
            for (int i = 0; i < strToConvert.Length; i++)

            {
                parameters[i] = Convert.ToInt32(strToConvert[i]);
            }
            return parameters;
        }
        public string[] SplitInput(string inputStr)
        {
            // Убираем лишнее, оставляем разделение размеров через ;
            inputStr = inputStr.Trim().Replace(" ; ", ";").Replace(" ;", ";").Replace("; ", ";").Replace(" ", ";");
            //Console.WriteLine(inputStr);             // отладочный вывод
            string[] splitedStr = inputStr.Split(';'); // делим строку по разделителю ;
            return splitedStr;
        }


    }
}
// try
// {


// }
// catch
// {
//     Console.Write("Exeption");
//     return GetArraySize();
// }




// public bool CheckInput(string stringForCheck)
// {
//     if (!String.IsNullOrEmpty(stringForCheck))
//     {
//         return true;
//     }
//     else return false;

//                 if (stringForCheck.Length == 2)
//                 {

//                 }
//                 else Console.Write("Wrong input");
// GetArraySize();
// return null;


//             }
//             GetArraySize();
// return null;


// int.TryParse(inputStr, out int first);
// return true;