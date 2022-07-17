using System.Linq;

string text = "(0,1) (2,3) (4,5) (6,7"
              .Replace("(", "")
              .Replace(")", "");

Console.WriteLine(text);
var data = text.Split(" ")
               .Select(item => item.Split(","))
               .Select(arr => (x: int.Parse(arr[0]), y: int.Parse(arr[1])))
               .Where(e => e.x % 2 == 0)
               .Select(point => (point.x * 10, point.y))
               .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]); // now it int32 here
}