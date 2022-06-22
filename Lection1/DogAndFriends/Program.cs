// Задача: есть два друга и собака. Расстояние между ними и скорости зададим через вопросы юзеру
// Рядом с одним из друзей находится собака.
// Друзья начинают идти навстречу друг к другу с полученными скоростями.
// Собака с полученной скоростью бежит от первого друга ко второму и обратно.
// Сколько раз собака пробежит туда-сюда, прежде чем друзья встретяться.
// Расстояние встречи принимаем за 10м

Console.Clear();
Console.Write("Введите расстояние между друзьями: ");
var distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость первого: ");
var firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость второго: ");
var secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
var dogSpeed = Convert.ToInt32(Console.ReadLine());

int distanceLimit = 10;
bool dogDirection = true;
int dogCounter = 0;
var timeToMeet = 0;

while (distance > distanceLimit)
{
    if (dogDirection == true)
    {
        timeToMeet = distance / (firstFriendSpeed+dogSpeed);
        dogDirection = false;
    }
    else
    {
        timeToMeet = distance / (secondFriendSpeed + dogSpeed);
        dogDirection = true;
    }
    distance = distance - timeToMeet * (firstFriendSpeed+secondFriendSpeed);
    dogCounter++;
    Console.WriteLine(distance);
}

Console.WriteLine(dogCounter);
