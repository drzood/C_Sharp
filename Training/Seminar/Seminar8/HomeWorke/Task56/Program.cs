// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintRowsMinSum(int[,] matrix) // метод поиска минимальной суммы строки
{   
    int[] arr = new int[matrix.GetLength(0)]; // создал одномерный массив для записи сумм строк
    int k = 0;  // переменная для работы с ячейками одномерного массива
    // int s = 0;  // переменная для записи строки с минимальным значением
    for(int i = 0; i < matrix.GetLength(0); i++) // цикл строки
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // цикл столбцы
        {
            arr[k] += matrix[i,j];  // считаем сумму столбцов в одной строке
        }
        Console.WriteLine($"{arr[k]} "); // вводим сумму каждой строки
        k++; // переходим к следующей ячейке одномерного массива
    }
    int rows = 0; // переменна для вывода строки с минималной суммой столбцов
    int min = arr[0]; // переменная для нахождения минимального значения в одномерном массиве
    for (int s = 0; s < arr.Length; s++) // цикл для поиска минимального значения
    {
        if (min > arr[s]) // если переменная мин больше ячейк1
        {
            min = arr[s]; // записваем минимальное число
            rows = s; // записваем индекс с минимальным числом в массиве
        }
    }
    Console.WriteLine($"В {rows} строке наименьшая сумма элементов, равная {min}"); // выводим что получилось
}


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
Console.WriteLine();
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
PrintRowsMinSum(matr);
