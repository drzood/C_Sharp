// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string msg) // метод создания переменной при помощи ввода и ввода
{
    Console.Write(msg); // вывод
    return Convert.ToInt32(Console.ReadLine()); // ввод
}

double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange) // метод создания матрицы вещественных чисел
{
    double[,] matr = new double[rowsCount, columnsCount]; //  создаем матрицу с вещественными числами использую вводные данные
    Random rand = new Random(); // переменная случайных чисел
    for (int i = 0; i < rowsCount; i++)  // цикл строк
    {
        for(int j = 0; j < columnsCount; j++) // цикл столбцов
        {
            matr[i,j] = rand.Next(leftRange, rightRange) + rand.NextDouble(); // заполняем масси складывая целое и вещественное число
        }
    }
    return matr; // возвращаем
}

void PrintMatrix(double[,] matr) // метод по вводу матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++) // цикл строк
    {
        for(int j = 0; j < matr.GetLength(1); j++) //цикл столбцов
        {
            Console.Write("{0,4:f1} ", matr[i, j]); // незнаю
        }
        Console.WriteLine(); // новая строка
    }
}

int i = ReadNumber("Введите нужное кол-во строк: "); // переменная для строк
int j = ReadNumber("Введите нужное кол-во столбцов: "); // переменная для стольцов
double[,] matrix = GetMatrix(i, j, -9, 9); // создаем массив исползуя метод с условиями
PrintMatrix(matrix); // вводим в консоль

// double[,] matrix = new double[rows, columns];
 
// Random rand = new Random();
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         matrix[i, j] = rand.Next(-9, 10) + rand.NextDouble();
//         Console.Write("{0,5:f1} ", matrix[i, j]);
//     }
//     Console.WriteLine();
// }
