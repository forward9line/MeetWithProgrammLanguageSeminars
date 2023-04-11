/*Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21
AB = \|(Xb-Xa)^2 + (Yb-Ya)^2
*/

//Console.WriteLine(Math.Sqrt(9)) == 3 "Корень квадратный из 9"
//Math.Pow(5, 2) == 25 "5 возводим в степень 2"


Console.WriteLine("Введите координаты первой точки");
Console.Write(" x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write(" y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write(" x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write(" y2 = ");
int y2 = int.Parse(Console.ReadLine());

double distanse = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2));
Console.WriteLine($"Растояние между точками равно: {distanse}");



