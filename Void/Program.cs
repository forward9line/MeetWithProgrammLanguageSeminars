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




/*Random random = new Random();

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
    
}*/


/*Random random = new Random();

int randomValue= random.Next(100, 1000);

int d1 = randomValue % 10;
int d2 = randomValue / 100;
Console.Write($"{randomValue} -> {d2}{d1}");*/

Console.WriteLine("Введите два числа:");

int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
Console.Write($"{first}, {second}");
int ostat = first % second;
if (first % second == 0)
{
    Console.Write("кратно");
}
else
{
    Console.Write($" -> не кратно, остаток {ostat}");
}










