// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string msg) //  метод для создания переменной через вывод и ввод
{
    Console.Write(msg); // вывод
    return Convert.ToInt32(Console.ReadLine()); // ввод
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange) // метод создания двумерново массива со случайными числами
{
    int[,] matr = new int[rowsCount, columnsCount]; // создаем двумерный массив
    Random rand = new Random(); // переменная случайных чисел
    for (int i = 0; i < rowsCount; i++) // цикл строки
    {
        for (int j = 0; j < columnsCount; j++) // цикл столбцов
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1); // заполняем двумерный массив случайнми числами
        }
    }
    return matr; // возвращаем заполненный двумерный массив
}

void PrintMatrix(int[,] matr) // метод вывода матрицы используя двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++) // цикл строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл столбцов
        {
            Console.Write($"{matr[i,j]}  "); //  выводим столбцы
        }
        Console.WriteLine(); // новая строка
    }
}

void GetArraySlot(int[,] matr) //метод для вызова нужной ячейки
{
    Console.WriteLine("Для вызова нужной ячейки,"); // вывод
    int rows = ReadNumber("введите номер строки: ") - 1; // создаем переменную для строк
    int column = ReadNumber("введите номер столбца: ") - 1; // создаем переменную для столбцов
    if ((rows < matr.GetLength(0) && rows > 0) && (column < matr.GetLength(1) && column > 0)) // если вводные данные не выходят за рамки массива
    {
        Console.WriteLine(matr[rows, column]); // то выводим ячейку
    }
    else // если нет
    {
        Console.WriteLine("Проверьте введенные данные и повторите попытку."); // выводим предупреждение
    }
}

Console.Clear(); // чистим консоль
int i = ReadNumber("Задайте кол-во строк: "); // вводим кол-во строк
int j = ReadNumber("Задайте кол-во слобцов: "); // вводим кол-во столбцов
int[,] matrix = GetMatrix(i, j, 0, 9); // создаем двумерный массив с заданными характеристиками
PrintMatrix(matrix); // выводим матрицу
GetArraySlot(matrix); // находи нужную ячейку