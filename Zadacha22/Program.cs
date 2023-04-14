/*Задача No22. Работа в группах
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4*/

Console.WriteLine("Введите число N: ");
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());

GetArrayPow2(n);

void GetArrayPow2(int n)
{
  for (int i = 1; i <= n; i++)
{
    if (i == n)
    { 
       Console.Write(i*i); 
       break ;
    }
    else
    {
        Console.Write($"{i*i}, ");
    }
    
    
}  
}



    






/*int index = 0;
int[] stepen2 = new int[n];

//int[] array = GetArrayPow2(n);

Console.WriteLine(stepen2);

int[] GetArrayPow2(int n)
{
   
    Console.WriteLine(array);
    return ;
}
*/









