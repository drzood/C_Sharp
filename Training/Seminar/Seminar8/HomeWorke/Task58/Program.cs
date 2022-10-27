// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
//
// Например, заданы 2 массива:
// 1 4 7 2     и   1 5 8 5
// 5 9 2 3         4 9 4 2
// 8 4 2 4         7 2 2 6
// 5 2 6 7         2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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
 
int[,] ProductOfTwoMatrix(int[,] matrix, int[,] matrix2) // метод произведения двух матриц
{
    int[,] matr = new int[matrix.GetLength(0), matrix.GetLength(1)]; // новая матрица для запии произведения
    for (int row = 0; row < matrix.GetLength(0); row++) 
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matr[row,column] = matrix[row, column] * matrix2[row, column]; // перемножаем две матрицы и записываем в новую
        }
    }
    return matr;
}


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
int[,] matr2 = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine();
int[,] prodMatr = ProductOfTwoMatrix(matr, matr2);
PrintMatrix(prodMatr);
