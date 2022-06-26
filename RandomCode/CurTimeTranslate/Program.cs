// Нужно получить системное время и вывести его по-русски

// ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
// {
//   ТелоМетода;
//   return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }
string GetHour(int Hour, int quantity, string ending)

string localHour = DateTime.Now.ToString("HH");
string localMinute = DateTime.Now.ToString("mm");
Console.WriteLine(localHour);
Console.WriteLine(localMinute);
int.TryParse(localHour, out int Hour);
int.TryParse(localHour, out int Minute);

if (Hour >= 5)  //часов

    if (Hour < 5 && Hour != 1)   //часа

else //час