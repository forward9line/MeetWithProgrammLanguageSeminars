/*int a = 5;

int b = 6;



int g = 8;

int c = 7;

int result1 = Calculate(a, b);

int result2 = Calculate(c, g);

void Calculate (int a, int b)
    {
    return a * (a * b)-5;
    }

void Show(int a, int b)
    {
            Console.WriteLine($"{a} , {b}");
    }
Console.WriteLine(result);*/




Random random = new Random();

int randomValue= random.Next(10, 100);

int lastDigit = randomValue  % 10;

int firstDigit = randomValue / 10;

Console.Write($"{randomValue} -> ");

if (lastDigit > firstDigit)
{
    Console.Write(lastDigit);
}
else
{
    Console.Write(firstDigit);
    
}










