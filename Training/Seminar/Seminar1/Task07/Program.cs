﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
// 918 -> 8
Console.Write("Введите трех значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (99 < a && a < 1000)
{
    double b = a % 10;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Условие не соблюдено."); 
}