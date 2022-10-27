// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ReadN(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintBin(int n)
{
    if(n == 0) return;
    PrintBin(n / 2);
    Console.Write(n % 2);
}

int num = ReadN("Введите число");
PrintBin(num);
