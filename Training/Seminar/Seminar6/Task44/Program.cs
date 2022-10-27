// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



int ReadN(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Fib(int number)
{
    int f = 1;
    for (int i = 3; i < number; i++)
    {
        Console.Write($", {f += f}");
    }
    // return f;
}

int num = ReadN("Введите число: ");
Console.Write("0, 1, 1");
Fib(num);
