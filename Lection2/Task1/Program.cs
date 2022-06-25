// Имеется одномерный массив  array из n элементов, тебуется найти элемент массива, равный find
// 1. Установить счётчик index в позицию 0;
// 2. Если array[index] = find, алгоритм завершил работу успешно;
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2,иначе алгоритм завершил работу безуспешно.

int[] array = { 1, 4, 12, 6, 9, 55, 11 };

int n = array.Length;
int find = 2;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}