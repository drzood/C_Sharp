// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] inputArr(int size) // метод для создания массива
{
    int[] arr = new int[size]; // пустой массив
    for (int i = 0; i < size; i++) // цикл
    {
        arr[i] = Convert.ToInt32(Console.ReadLine()); // ввод элементов массива
    }
    return arr; // возвращаем
}

int Diff(int[] arr) // метод для нахождения разницы
{    
    int max = arr[0]; // временная переменная макс
    int min = arr[0]; // временная переменная мин
    for (int i = 1; i < arr.Length; i++) //цикл
    { 
        if (arr[i] >= max) // если элемент больше или равно макса 
        {
            max = arr[i]; // да, записываем в макс
        }
        else
        {
            min = arr[i]; // нет, записываем в мин
        }
    }
    int diff = max - min;  // из полученных данных находим разницу
    return diff; // возвращаем
}

int[] arr = inputArr(5); // Создали массив с введеными элементами через метод
Console.WriteLine($"Массив: {string.Join(", ", arr)}"); // выводим массив через запятую
int diff = Diff(arr); // создали переменную используя метод для нахождения разницы
Console.WriteLine($"Разниа между макс и мин элеметов массива = {diff}"); // выводим результат

// int[] arr = {3, 7, 22, 2, 78};
// Console.WriteLine($"Массив: {string.Join(", ", arr)}");
// int min = arr[0];
// int max = arr[0];
// for (int i = 1; i < arr.Length; i++)
// {
//     if (arr[i] >= max)
//     {
//         max = arr[i];
//     }
//     else
//     {
//         min = arr[i];
//     }
// }
// int diff = max - min;
// Console.WriteLine($"Разниа между макс и мин элеметов массива = {diff}");