// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 1 && a <= 4)
{
    if (a == 1)
    Console.WriteLine("x > 0 && 0 > y");
    if (a == 2)
    Console.WriteLine("x < 0 && 0 > y");
    if (a == 3)
    Console.WriteLine("x < 0 && 0 < y");
    if (a == 4)
    Console.WriteLine("x > 0 && 0 < y");
}
else
{
    Console.WriteLine("Существует только 4 координатные четверти");
}