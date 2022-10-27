// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = √(xb - xa)2 + (yb - ya)2

Console.Clear();
Console.WriteLine("Введите координаты первой точкиm A: ");
double xa = Convert.ToInt32(Console.ReadLine());
double ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки B: ");
double xb = Convert.ToInt32(Console.ReadLine());
double yb = Convert.ToInt32(Console.ReadLine());
double x = Math.Pow(xb - xa, 2);
double y = Math.Pow(yb - ya, 2);
double ab = Math.Sqrt(x + y);
Console.Write(ab);