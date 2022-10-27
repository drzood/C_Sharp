// Задача 9. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int a = rand.Next(10, 100);
Console.WriteLine(a);
if (a / 10 > a % 10) Console.Write(a / 10);
else Console.WriteLine(a % 10);