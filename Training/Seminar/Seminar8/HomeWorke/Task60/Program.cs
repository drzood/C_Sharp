// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
//
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.WriteLine($"{matr[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

int[,,] GetMatrixNoRep(int rowsCount, int columnsCount, int depthCount, int leftRange = 10, int rightRange = 100)
{
    int[,,] matr = new int[rowsCount, columnsCount, depthCount]; // новая 3м матрица
    int[] arr = new int[rowsCount * columnsCount * depthCount]; // новый массив размеро 3м матрицы
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++) // цикл из последнего семинара
    {
        int num = random.Next(leftRange, rightRange); // создаем переменную со случайным числом
        if (arr.Contains(num)) i--; // если переменная нам равна другому новосозданному числу то повторяем цикл
        else arr[i] = num; // тогда записываем новое число в массив
    }
    int x = 0; // индекс для массива в новом цикле
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++)
        {
            for (int k = 0; k < depthCount; k++)
            {
                matr[i, j, k] = arr[x]; // записваем в матрицу значение из массива
                x++; // индекс массива +1
            }
        }
    }
    return matr;
}

int[,,] matrix = GetMatrixNoRep(2, 2, 2);
PrintMatrix(matrix);