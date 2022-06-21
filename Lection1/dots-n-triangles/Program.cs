// Даны 3 точки ака вершины основного треугольника. Соединяем 2 рандомные точки, ставим точку посередине отрезка. 
// Отрезок не нужен. Эту точку соединяем с людой из 3х и снова точку посредине.
// Новую точку соединяем снова с любой из вершин начального треугольника.

//Console.Clear();
Console.WriteLine("Задача про точки и треугольники");

//Console.SetCursorPosition(10,2);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int dot = new Random().Next(0, 3);
    if (dot == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (dot == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (dot == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}