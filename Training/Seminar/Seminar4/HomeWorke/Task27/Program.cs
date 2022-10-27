// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int ReadNum(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadNum("Введите число: ");
int num = Math.Abs(number);
int a = 0; 
while (num > 0)
{       
    a = a + num % 10;
    num /= 10;
}
Console.Write($"Сумма цифр в числе {number} = {a}");