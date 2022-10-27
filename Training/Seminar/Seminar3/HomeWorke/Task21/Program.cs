// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты первой точкиm A: ");
double xa = Convert.ToInt32(Console.ReadLine());
double ya = Convert.ToInt32(Console.ReadLine());
double za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки B: ");
double xb = Convert.ToInt32(Console.ReadLine());
double yb = Convert.ToInt32(Console.ReadLine());
double zb = Convert.ToInt32(Console.ReadLine());
double x = Math.Pow(xb - xa, 2);
double y = Math.Pow(yb - ya, 2);
double z = Math.Pow(zb - za, 2);
double ab = Math.Sqrt(x + y + z);
// double ab = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.Write($"{ab:f2}");