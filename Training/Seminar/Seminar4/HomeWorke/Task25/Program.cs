// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int ReadNum(string msg) // функция вывода текста с возможностью ввода целового числа
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int A = ReadNum("Введите целое чиcлo: ");
int B = ReadNum("Введите степень: ");

if (B > 1) // Не представляю как из этого сделать функцию
{
    int sum = A;
    for (int i = 1; i < B; i++) 
    {
        sum *= A;
    }
    Console.WriteLine($"{A} в {B} степени = {sum}");
}   
else if (B == 0) 
{
    Console.WriteLine($"{A} в {B} степени = 1");
} 
else if (B == 1)
{
    Console.WriteLine($"{A} в {B} степени = {A}");
}
else
{
    int sum = A;
    for (int i = -1; i > B; i--)
    {
        sum *= A;
    }
    double num = 1.0 / sum;
    Console.WriteLine($"{A} в {B} степени = {num}");
}


