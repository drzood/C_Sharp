// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (99 < a && a < 1000)
{
    Console.Write($"Вторая цифра этого числа: {(a / 10) % 10}");
}
else
{
    Console.Write("Число не соответствует условиям.");
}