/*Задача 24: напишите программу которая принимает на вход число(А) и выдаёт сумму
чисел от 1 до (А)*/


/*

int a = int.Parse(Console.ReadLine());

int sum = GetSumToNamber(a);
Console.WriteLine(sum);

int GetSumToNamber(int number)
{

    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;  //то же самое, что "sum = sum + i"
    }
    return sum;
}

*/

//Задача 28: Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.
//4 -> 24 5 -> 120

int a = int.Parse(Console.ReadLine());

int proiz = GetProizToNumber(a);
Console.WriteLine(proiz);

int GetProizToNumber(int number)
{
    int proiz = 1;

    for (int i = 1; i <= number; i++)
    {
        proiz *= i;
    }
    return proiz;
}


//Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]









