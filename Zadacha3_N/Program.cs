Console.WriteLine("Введите целое положительное число");
int n = int.Parse(Console.ReadLine());

    if(n > 0)
    {
        int n1 = n * -1;
        //Console.WriteLine(n1);
        while( n1 != n )
        {
            Console.Write(n1);
            Console.Write(", ");
            n1++;
        }
        Console.Write(n);
        Console.Write(".");
    }
    else
    {
        Console.Write("Число отрицательное! Введите корректные данные");
    }


