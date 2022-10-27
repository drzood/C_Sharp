// Задача 24: Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersFrom1ToA(int a)
{
    if (a >= 1)
    {
        int sum = 0;
        for (int i = 1; i<= a; i++)
        {
            sum = sum + i; //sum += i; копим сумму
        }
        return sum;
    }
    else
    {
        Console.WriteLine("А должна быть не меньше 1!");
        return -1;
    }
}

int number = ReadNumber("Введите число: ");
int summa = SumNumbersFrom1ToA(number);
Console.WriteLine($"Сумма элементов от 1 до А = {summa}");
