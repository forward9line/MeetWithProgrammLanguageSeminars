Console.WriteLine("Введите X");

int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y");

int y = int.Parse(Console.ReadLine());

int result = GetNumberOfQuarter(x, y);
Console.WriteLine(result);

if (result == 0)
{
    Console.WriteLine("X или Y равны нулю");
    return;
}






int GetNumberOfQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (y > 0 && x < 0)
    {
        return 2;
    }

    if (y < 0 && x < 0)
    {
        return 3;
    }

    if (x > 0 && y < 0)
    {
        return 4;
    }

    return 0;
}










