namespace Geekbrains
{
    public class InputProcessing
    {
        public bool InputValidation(string? strForValidation, int[] sizes, TextAndMessage tm)
        {
            if (!String.IsNullOrEmpty(strForValidation))
            {

                if (sizes.Length == 2 && sizes[0] > 0 && sizes[1] > 0)
                {
                    return true;
                }
                else
                {
                    tm.ErrorArraySize();
                    tm.TextWait();
                    return false;
                }
            }
            else
            {
                tm.ErrorEmptyInput();
                tm.TextWait();
                return false;
            }
        }
        public bool InputValidation(string? strForValidation, TextAndMessage tm)
        {
            if (!String.IsNullOrEmpty(strForValidation)
                && Convert.ToInt32(strForValidation) > 0)
            {
                return true;
            }
            else
            {
                tm.ErrorArraySize();
                tm.TextWait();
                return false;
            }
        }
        public int[] GetSizes(string inputString)
        {
            int[] sizes = this.ConvertToInt(this.SplitInput(inputString));
            return sizes;
        }
        public int[] ConvertToInt(string[] strToConvert)
        {
            int[] parameters = new int[strToConvert.Length];
            for (int i = 0; i < strToConvert.Length; i++)
            {
                int.TryParse(strToConvert[i], out int p);
                parameters[i] = Math.Abs(p);
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
