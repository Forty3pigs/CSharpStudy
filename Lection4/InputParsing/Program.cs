using System.Linq;

string text = "(0,1) (2,3) (4,5) (6,7"
              .Replace("(", "")
              .Replace(")", "");

Console.WriteLine(text);
var data = text.Split(" ")
               .Select(item => item.Split(","))
               .ToArray();

for (int i = 0; i < data.Length; i++)
{
    for (int j = 0; j < data[i].Length; j++)
    {
        Console.WriteLine(data[i][j]);
    }
}