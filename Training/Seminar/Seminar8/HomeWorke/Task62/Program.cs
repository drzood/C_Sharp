// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SpiralMatrix(int rowsCount, int columnsCount) // метод заполнения матрицы 4х4 спиралью
{
    int[,] matr = new int[rowsCount, columnsCount]; // новая матрица
    int x = 1; // переменная для заполнение ячеек матрицы
    int i = 0; // индекс строк
    int j = 0; // индекс столбцов

    while (j < columnsCount - 1) 
        {
            matr[i,j] = x++; j++; 
        }
    while (i < rowsCount - 1) 
        {
        matr[i,j] = x++; i++;
        }
    while (j > 0) 
        {
        matr[i,j] = x++; j--;
        }
    while (i > 1) 
        {
        matr[i,j] = x++; i--;
        }
    while (j < columnsCount - 2) 
        {
        matr[i,j] = x++; j++;
        }
    while (i < rowsCount - 2) 
        {
        matr[i,j] = x++; i++;
        }
    while (j > 0) 
        {
        matr[i,j] = x++; j--;
        }

    // из семинара, заполнение спиралью любой равносторонней матрицы
// while (temp <= matrix.GetLength(0) * matrix.GetLength(1)) 
// {
// matr[i, j] = x;
// x++;
// if (i <= j + 1 && i + j < matr.GetLength(1) - 1) j++;
// else if (i < j && i + j >= matr.GetLength(0) - 1) i++;
// else if (i >= j && i + j > matr.GetLength(1) - 1) j--;
// else i--;
// }

    return matr;
}

int[,] matr = SpiralMatrix(4, 4);
PrintMatrix(matr);