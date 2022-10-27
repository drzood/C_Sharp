// Задача 55: Задайте двумерный массив. Напишите 
// программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна 
// вывести сообщение для пользователя.


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Revers(int[,] matrix)
{
    int[,] matr = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matrix[j, i];
        }
    }
    return matr;
}

int i = ReadNumber("Введите количество строк");
int j = ReadNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(i, j, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(Revers(matrix));