Console.WriteLine("Введите номер четверти, а программа покажет диапозон чисел X и Y");

int n = int.Parse(Console.ReadLine());

//Console.WriteLine(n);

string result = GetRangeByQuater(n);
Console.WriteLine(result);
if (result == "0")
{
    Console.WriteLine("Введены неверные данные");
}



string GetRangeByQuater(int n)
{
    if (n == 1)
    {
        return "x > 0 и y > 0";
    }
    if (n == 2)
    {
        return "y > 0 и x < 0";
    }

    if (n == 3)
    {
        return "y < 0 и x < 0";
    }

    if (n == 4)
    {
        return "x > 0 и y < 0";
    }

    return "0";
}










