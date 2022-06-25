// ТипДанных[] Имя = { Значение1, Значение2, ...}
// int[] array = { 1, 5, 2, 243, 2 };

// int[] array = { 0, 0, 0, 0, 0 };
// int[] array = new int[5];
// int[] array = new int[] { 0, 0, 0, 0, 0 };
// int[] array = new int[5] { 0, 0, 0, 0, 0 };

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}

int[] array = { 3, 6, 1, 251, 78, 12, 5, 44, 41 };

int max = Max(
        Max(array[0], array[1], array[2]),
        Max(array[3], array[4], array[5]),
        Max(array[6], array[7], array[8])
        );

Console.WriteLine(max);