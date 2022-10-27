// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string msg) // метод вывода текста с возможностью ввода целых чисел
{
    Console.Write(msg); // вывод текста
    return Convert.ToInt32(Console.ReadLine()); // ввод
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRang, int rightRange) // метод создания многомерной матрицы случайных чисел в заданном размере и диапазоне
{
    int[,] matr = new int[rowsCount, columnsCount]; // создаем двумерный массив с заданным размером
    Random rand = new Random(); // переменная со слуйчайным числом
    for (int i = 0; i < matr.GetLength(0); i++) // цикл строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл столбцов
        {
            matr[i, j] = rand.Next(leftRang, rightRange + 1);  // заполняем двумерный массив случайными числами
        }
    }
    return matr; // возвращаем заполненный масив
}

void PrintMatrix(int[,] matr) // метод вывода двумерного массива  в виде матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++) // цикл строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл столбцов 
        {
            Console.Write($"{matr[i, j]}    "); // вывод каждого столбца
        }
        Console.WriteLine(); // переход к новой строке
    }
}

void MeanArimethicColumns(int[,] matr) // метод нахождения среднего арифметического столбцов
{
    double mean = 0; // создаем вещественную переменную
    for (int j = 0; j < matr.GetLength(1); j++) // цикл столбцов
    {
        double sum = 0; // создаем вещественную переменную
        for (int i = 0; i < matr.GetLength(0); i++) // цикл строк
        {
            sum += matr[i,j]; // считаем сумму строк столбца
        }
        mean = sum / matr.GetLength(0); // находим среднее арифметическое столбца
        Console.Write($"{j + 1} столбец = {mean:f1}"); // вводим полученный результат
        Console.WriteLine(); // переход на наовую строку
    }
}

Console.Clear(); // чистим консольь для начала работы

int i = ReadNumber("Введите кол-во строк: "); // вводим переменные используя метод ввода
int j = ReadNumber("Введите кол-во столбцов: ");
int[,] matrix = GetMatrix(i, j, 0, 9); // создаем двумерный массив используя созданный метод


if (i <= 0 || j <= 0) // проверяем корректность введеных данных
{
    Console.WriteLine("Пожалуйста, повторите попытку. Для корректой работы " // вывод предупреждение
                    + "программы, введите число больше нуля.");
}
else
{
    PrintMatrix(matrix); // используем метод вывода матрицы
    Console.WriteLine("Среднее арифметическое каждого столбца: "); // вывод текста
    MeanArimethicColumns(matrix); // делаем подсчет из массива исползуя метод нахождения среднего
}