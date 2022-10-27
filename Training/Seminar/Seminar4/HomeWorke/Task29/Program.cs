// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// Данные вводятся с консоли пользователем.

Console.Clear();
int[] arr = new int[8];
Console.Write("Введите массив из 8 элементов: ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Массив: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}