// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionAkkerman(int m, int n) // метод Аккермана в действии_)
{
    if (m == 0) return n + 1; // если м = 0, то возвращаем н+1
    if (m != 0 && n == 0) // если м и н не равно 0 то
    {
        return FunctionAkkerman(m - 1, 1); // возвращаем рекурсию м - 1, 1
    }
    if (m > 0 && n > 0) // если м и н больше 0 то 
    {                   // рекурсия (м-1, рекурския м, н - 1)
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
    return FunctionAkkerman(m, n); 
}

Console.WriteLine("Введите два неотрицательных числа.");
int m = ReadNumber("m = ");
int n = ReadNumber("n = ");
int fA = FunctionAkkerman(m, n);
Console.WriteLine($"Ответ: {fA}");