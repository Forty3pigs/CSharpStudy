// Задача: есть два друга и собака. Расстояние между ними и скорости зададим через вопросы юзеру
// Рядом с одним из друзей находится собака.
// Друзья начинают идти навстречу друг к другу с полученными скоростями.
// Собака с полученной скоростью бежит от первого друга ко второму и обратно.
// Сколько раз собака пробежит туда-сюда, прежде чем друзья встретяться.
// Расстояние встречи принимаем за 10м
// int age = Convert.ToInt32(Console.ReadLine());

//Console.Clear();
Console.Write("Введите расстояние между друзьями: ");
int? distance = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(distance);
Console.Write("Введите скорость первого: ");
int? firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(firstFriendSpeed);
Console.Write("Введите скорость второго: ");
int? secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(secondFriendSpeed);
Console.Write("Введите скорость собаки: ");
int? dogSpeed = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(dogSpeed);

//int dist = Convert.ToInt32(distance);
//int fstSp = Convert.ToInt32(firstFriendSpeed);
//int sndSp = Convert.ToInt32(Console.ReadLine());
//int dogSp = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(distance+firstFriendSpeed+secondFriendSpeed+dogSpeed);

int distanceLimit = 10;
bool dogDirection = true;
int dogCounter = 0;
int? timeToMeet = 0;

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
