// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int ReadNum(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadNum("Введите первое значение: ");
int b = ReadNum("Введите второе значение: ");
int c = ReadNum("Введите третье значение: ");

int max = a;
if (b > a) max = b;
if (c > max) max = c;

Console.WriteLine($"max = {max}");