﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear(); // чистим консоль

Console.WriteLine($"Для остановки ввода, напишите ключевое слово: "); // вывод
string b = Console.ReadLine()??""; // ввод переменной
Console.WriteLine("Введите интересующиее кол-во чисел: "); // вывод
int s = 0; // переменная

while (true) // ?цикл тру, насколько понял бесконечный цикл пока не дойдет до брика
{
    string a = Console.ReadLine()??""; // вводим временную перменную
    if (a == b) // если слово = слово
    {
        Console.WriteLine($"Чисел больше нуля = {s}"); // вывод результата
        break; // завершение цикла
    }
    else  // слово не равно слово
    {
        int c = Convert.ToInt32(a); // конвертируем стринг в переменную инт
        if (c > 0) s++; // считаем числа больше 0
    }
}
