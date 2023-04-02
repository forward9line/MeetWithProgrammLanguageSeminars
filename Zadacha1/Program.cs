Console.WriteLine("Вас приветствует программа проверки чисел №1");

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if(b == a / b)
{
    Console.Write("Второе число - ");
    Console.Write(b);
    Console.Write(" является квадратом первого - ");
    Console.WriteLine(a);
}
else
{
    Console.Write("Второе число - ");
    Console.Write(b);
    Console.Write(" не является квадратом первого - ");
    Console.WriteLine(a);
}
Console.WriteLine("Благодарим за внимание!");