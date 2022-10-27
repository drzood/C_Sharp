// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное число {number}");
int digit1 = number % 10;
int digit2 = number / 100;
Console.WriteLine($"{digit2}{digit1}");