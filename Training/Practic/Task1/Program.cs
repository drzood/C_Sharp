// Задача 1 Напишите программу, которая на вход 
// принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

int ReadNum(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int x = ReadNum("Введите число: ");
Console.WriteLine($"Квадрат числа {x} = {x * x}");