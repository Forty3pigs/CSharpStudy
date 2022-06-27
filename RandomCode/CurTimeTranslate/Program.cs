// Нужно получить системное время и вывести его по-русски

// ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
// {
//   ТелоМетода;
//   return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }
// Если без return, то вместо ВозвращаемыйТипДанных пишется void

string TransTime(int Time, string HorM)
{
    string[] capitalOneToTwenty = {"Ноль", "Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь", "Девять",
    "Десять", "Одинадцать", "Двенадцать", "Тринадцать", "Четырнадцать", "Пятнадцать", "Шестнадцать", "Семнадцать",
    "Восемнадцать", "Девятнадцать", "Двадцать"};
    string[] addForMinutes = { "одна", "две", "двадцать ", "тридцать ", "сорок ", "пятьдесят " };

    string txtTime = "";

    if (HorM == "Hour")
    {
        if (Time > 20)
        {
            Time = Time - 20;
            txtTime = capitalOneToTwenty[20];
        }
        txtTime = txtTime + capitalOneToTwenty[Time];
    }
    if (HorM == "Minute")
    {
        if (Time < 20)
        {
            txtTime = capitalOneToTwenty[Time].ToLower();
        }
        if (Time >= 20)
        {
            int tmp = Time % 10;
            if (tmp != 0)
                txtTime = capitalOneToTwenty[tmp].ToLower();
            Time = Time / 10;
            txtTime = addForMinutes[Time] + txtTime;
        }
    }
    return txtTime;
}

string localHour = DateTime.Now.ToString("HH");
string localMinute = DateTime.Now.ToString("mm");
Console.WriteLine(localHour);
Console.WriteLine(localMinute);
int.TryParse(localHour, out int Hour);
int.TryParse(localMinute, out int Minute);
string h = "Hour";
string m = "Minute";
string endingH = "";
string endingM = "";

if (Hour >= 5)  //часов
    endingH = " часов ";
if (Hour < 5 && Hour != 1)   //часа
    endingH = " часа ";
if (Hour == 1) //час
    endingH = " час ";

if (Minute >= 5)
    endingM = " минут";
if (Minute < 5 && Minute != 1)
    endingM = " минуты";
if (Minute == 1)
    endingM = " минута";

Console.Write(TransTime(Hour, h) + endingH + TransTime(Minute, m) + endingM);


// Один, Два, Три, Четыре, Пять, Шесть, Семь, Восемь, Девять, Десять, 
// Одинадцать, Двенадцать, Тринадцать, Четырнадцать, Пятнадцать, Шестнадцать, 
// Семнадцать, Восемнадцать, Девятнадцать, Двадцать, 
// --Двадцать один, Двадцать два, Двадцать три, Двадцать четыре

// одна, две, 
// три,четыре, 20 и т.д. через ToLower
// тридцать, сорок, пятьдесят