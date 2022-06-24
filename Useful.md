
### Проверка ввода консоли на то, что ввели число
---
```
while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.WriteLine("Вы ввели число {0}", number);
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
```
### Проверка строки посимвольно, что все символы цифровые
---
```
bool StringIsDigits(string s)
{
   foreach(var item in s)
   {
      if(!char.IsDigit(item))
         return false; //если хоть один символ не число, то выкидываешь "ложь"
   }
   return true; //если ни разу не выбило в цикле, значит, все символы - это цифры
}
```