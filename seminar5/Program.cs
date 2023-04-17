/*//Задайте массив из 12 элементов, заполненый случайными числами [-9; 9].
//Найдите сумму положительных и отрицательных элементов массива



int[] array = GenerateArray(12);

PrintArray(array);

int sum = CalculateSumPositiveNumbers(array);
Console.WriteLine(sum);


int sum1 = CalculateSumNegativeNumbers(array);
Console.WriteLine(sum1);



int[] GenerateArray(int length)

{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array [i] = random.Next(-9, 10);
    }

    return array;

}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ,", array));
}






int CalculateSumPositiveNumbers(int[] array)
{

int sumPositive = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositive += array[i];

    }
  



}
return sumPositive;

}


int CalculateSumNegativeNumbers(int[] array)
{

int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        sumNegative += array[i];

    }
  
}
return sumNegative;

}
*/

//Задача 32: Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]




Console.WriteLine("Введите длинну массива:");
Console.Write("L = ");
int l = int.Parse(Console.ReadLine());

int[] array = GetArrayIntNunbers(l);


PrintArray(array);

int[] arrayrevers = GetArrayRevers(array);

PrintArray(arrayrevers);




int[] GetArrayIntNunbers(int l)
{
    Random random = new Random();

    int[] array = new int[l];

    for (int i = 0; i < l; i++)
    {
        array[i] = random.Next(-100, 101);
    }

    return array;

}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(" ,", array)}]");
}



int[] GetArrayRevers(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}
















