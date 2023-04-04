Console.WriteLine("Введите трёхзначное число");
int v = int.Parse(Console.ReadLine());
if (v > 99 & v < 1000)
{
    int a = v % 10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Введено не трёхзначное число");
}





/*
int a = v % 10;
Console.WriteLine(a);
*/