// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNaturalNum(int a, int b) // метод для нахождения суммы натуральных элементов в промежутке
{
    int sum = a; // переменная для счета с значением а
    if (a < b) // если а меньше б
    {
        sum = b + SumNaturalNum(a, b - 1); //sum = б + а, б - 1
    }
    return sum; // возвращаем подсчет
}

int m = ReadNumber("M = ");
int n = ReadNumber("N = ");
int sum = SumNaturalNum(m, n);
Console.Write($"Сумма натуральных элементов в "
+ $"промежутке от M = {m} до N = {n} равна {sum}");
