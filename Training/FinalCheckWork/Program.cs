// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string ReadChar(string msg) // метод для ввода и вывода текста
{
    Console.Write(msg); // выводим текст
    return Console.ReadLine() ?? ""; // вводим текст)
}

string[] FilingTheArray(int num) // метод заполнения массива
{
    string[] arr = new string[num]; // новый массив
    for (int i = 0; i < num; i++)
    {
        arr[i] = ReadChar($"Строка {i + 1} - "); // заоплняем массив используя метод ввода/вывода
    }
    return arr;
}

string[] ShortArrayStrings(string[] arr, int len) // метод для создания массива в котором будут меньше либо равно 3 символа
{
    string[] array = new string[arr.Length]; // создаем новый массив для сохранеия нужных строк
    int x = 0; // индекс для новой переменной
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= len) array[x++] = arr[i]; // записываем строки подходящие под условия
    }

    Array.Resize(ref array, x); // уменшаем массив до нужного кол-ва ячеек

    if (array.Length == 0) 
    {
        Console.WriteLine("Искомых строк не найдено.");
    }

    return array;
}

Console.Clear(); // Чистим консоль перед началом работы
int num = Convert.ToInt32(ReadChar("Введите необхоимое колличество строк: ")); // задаем кол-во строк в массиве
string[] arr = FilingTheArray(num); // создаем и заполняем массив
int len = Convert.ToInt32(ReadChar("Введите длину строки, которая меньше либо равна: ")); // задаем искомое
string[] array = ShortArrayStrings(arr, len);  // используя метод создаем массив согласно условиям задачи
Console.Write(string.Join(", ", array)); // выводим массив в консоль