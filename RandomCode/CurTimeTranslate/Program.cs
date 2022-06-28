// Нужно получить системное время и вывести его по-русски

// ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
// {
//   ТелоМетода;
//   return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }
// Если без return, то вместо ВозвращаемыйТипДанных пишется void

string TransTime(int Time, string HorM)
// Метод получает на вход 2-значное значение часов или минут и уточнение часы это или минуты прилетели
{
    string[] capitalOneToTwenty = {"Ноль", "Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь", "Девять",
    "Десять", "Одинадцать", "Двенадцать", "Тринадцать", "Четырнадцать", "Пятнадцать", "Шестнадцать", "Семнадцать",
    "Восемнадцать", "Девятнадцать", "Двадцать"};
    // тут накидываем базовые значения для часов, которые для минут будем переводить ToLower
    string[] addForMinutes = { "одна", "две", "двадцать ", "тридцать ", "сорок ", "пятьдесят " };
    // добавочные значения, необходимые для вывода минут

    string txtTime = ""; // сюда прилетает сконвертированное в буквы время (часы или минуты)

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

string localHour = DateTime.Now.ToString("HH");     //получаем текущее время: только часы 2-значным числом
string localMinute = DateTime.Now.ToString("mm");   //получаем текущее время: только минуты 2-значным числом
Console.WriteLine(localHour);
Console.WriteLine(localMinute);
int.TryParse(localHour, out int Hour);
int.TryParse(localMinute, out int Minute);
string h = "Hour";                                  //параметр, который улетит в метод что будем преобразовывать
string m = "Minute";                                // то же
string endingH = "";                                // переменная для часа/часов/час
string endingM = "";                                // аналогичное для минут


// ниже разбираемся с окончаниями
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

Console.Write(TransTime(Hour, h) + endingH + TransTime(Minute, m) + endingM); //собираем всё в кучу


// Один, Два, Три, Четыре, Пять, Шесть, Семь, Восемь, Девять, Десять, 
// Одинадцать, Двенадцать, Тринадцать, Четырнадцать, Пятнадцать, Шестнадцать, 
// Семнадцать, Восемнадцать, Девятнадцать, Двадцать, 
// --Двадцать один, Двадцать два, Двадцать три, Двадцать четыре

// одна, две, 
// три,четыре, 20 и т.д. через ToLower
// тридцать, сорок, пятьдесят