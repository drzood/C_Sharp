// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки 
// двумерного массива.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 4 8
// 2 4 5 9

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

int[,] SelectionSort(int[,] matrix) // метод сортировки по столбцам от меньшего к большему
{
    int x = 0; // для индекса одномерного массива
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)]; // одномерный массив для заполнения по порядку
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[x++] = matrix[i, j]; // переносим данне из матрицы в одномерный массив
        }
    }
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j]) // если i больше j
            {
                int temp = array[i]; // меняем местами
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    x = 0; // возвращаем 0 для повторнго отсчета
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = array[x++]; // заполняем матрицу сортированным одномерным массиво
        }
    }
    return matrix;
} 

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
Console.WriteLine();
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
int[,] s = SelectionSort(matr);
PrintMatrix(s);
