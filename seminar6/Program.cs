//Задача 39: Напишите программу которая перевернёть одномерный массив.

/*


int[] array = new int[]{1, 2, 3, 4, 5};

PrintArray(array);
Revers(array);
PrintArray(array);

//int[] reversed = ReversArray(array);

//PrintArray(reversed);

int[] ReversArray(int[] arr)
{
    int[] reversed = new int[array.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        reversed[i] = arr[arr.Length - 1 - i];
    }

    return reversed;

}

void Revers(int[] arr)
{
    for (var i = 0; i < arr.Length / 2; i++)
    {
        int tmp = arr[i];
        arr[i] = array[array.Length - 1 - i];
        arr[arr.Length - 1 - i] = tmp;
    }   
}

void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
} 

*/



//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*


Console.WriteLine("ВВедите три стороны треугольника: ");
Console.Write("А = ");
int a = int.Parse(Console.ReadLine());
Console.Write("B = ");
int b = int.Parse(Console.ReadLine());
Console.Write("C = ");
int c = int.Parse(Console.ReadLine());

bool isExistent = CheckTriangle(a, b, c);
Console.WriteLine(isExistent);

bool CheckTriangle(int a, int b, int c)
{
    if (a + b < c)
    {
         return false;
    }

    if (a + c < b)
    {
        return false;
    }
    
    if (b + c < a)
    {
        return false;
    }

    return true;
}

*/


//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10



/*
Console.WriteLine("Введите число, необходимое для перевода в двоичную систему:");
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());

string doublesystem = GetDoubeNumbers(n);

Console.WriteLine(doublesystem);

string GetDoubeNumbers(int n)
{
    string result = "";
    while (n!=0)
    {
        result = n%2 + result;
        n = n / 2;
    }

    return result;

}
*/

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

/*
Console.Write("Введите число: N = ");
int n = int.Parse(Console.ReadLine());
int[] array = Fibonachi(n);
PrintArray(array, n);

int[] Fibonachi(int n)
{
    int[] array = new int[n];
    if (array.Length > 0)
    {
    array[0] = 0;
    }
    if (array.Length > 1 )
    {
        array[1] = 1;
    }
    


    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array, int n)
{
    Console.WriteLine($"{n} -> {string.Join(", ", array)}");
}

*/

//Задача 45: Напишите программу, которая будет создавать копию заданного массива
//с помощью поэлементного копирования.

Console.Write("Введите длинну массива: L = ");
bool isParsed = int.TryParse(Console.ReadLine(), out int l);

if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;

}



int[] array = GetArrayIntNunbers(l);

int[] copyarray = GetCopyArray(array);

PrintArray(copyarray);


int[] GetArrayIntNunbers(int l)
{
    Random random = new Random();

    int[] array = new int[l];

    for (int i = 0; i < l; i++)
    {
        array[i] = random.Next(1, 154);
    }

    return array;

}

int[] GetCopyArray(int[] array)
{

    int[] copyarray = new int[array.Length];


    for (int i = 0; i < array.Length; i++)
    {
        copyarray[i] = array[i];
    }

    return copyarray;



} 




void PrintArray(int[] array)
{
    Console.WriteLine($"{string.Join(", ", array)} -> {string.Join(", ", copyarray)}");
}

