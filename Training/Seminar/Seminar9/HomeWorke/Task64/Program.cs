// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumber(int number, int num = 1) // метод вывода всех натуральных чисел
{
    if (number >= num) // N больше или равно 1
    {
        NaturalNumber(number, num + 1); // рекурсия N, 1+1
        Console.Write($"{num} "); // 8 7 6 5 4 3 2 1
    }
}

int n = ReadNumber("Задайте значение N: ");
NaturalNumber(n);