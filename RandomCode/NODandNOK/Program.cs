// НОД -наибольший общий делитель (алгоритм Эвклида)
// НОК - наименьшее общее кратное

int n = 140, m = 175;

NOD(n, m);
NOK(n, m);

int NOD(int n, int m)
{
    while (n != m)
    {
        if (n > m)
            n = n - m;
        else
            m = m - n;

        Console.WriteLine(n);
        Console.WriteLine(m);
        Console.WriteLine();
    }
    return n;
}
int NOK(int n, int m)
{
    int result = n * m / NOD(n, m);
    Console.WriteLine(result);
    Console.WriteLine();
    return result;
}