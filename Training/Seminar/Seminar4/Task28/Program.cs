// Задача 28: Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersFrom1ToA(int a)
{
    if (a >= 1)
    {
        int mult = 1;
        for (int i = 1; i<= a; i++)
        {
            mult = mult * i;
        }
        return mult;
    }
    else
    {
        Console.WriteLine("А должна быть не меньше 1!");
        return -1;
    }
}

int number = ReadNumber("Введите число: ");
int summa = SumNumbersFrom1ToA(number);
Console.WriteLine($"Произведение чисел от 1 до N = {summa}");