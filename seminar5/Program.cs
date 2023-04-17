//Задайте массив из 12 элементов, заполненый случайными числами [-9; 9].
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







