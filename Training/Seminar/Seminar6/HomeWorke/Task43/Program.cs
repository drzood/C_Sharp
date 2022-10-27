// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y = 5x + 2
// y = 9x + 4
Console.Clear(); // чистим консоль

int ReadN(string msg) // метод вывода ввода
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void intersectionPoint(double k1, double k2, double b1, double b2) // метод проверки пересечения двух прямх
{
    double x = (b2 - b1) / (k1 - k2); // поиск х (насколько понял)
    double y = k1 * x + b1; // поиск y по заданной формуле
    if (k1 == k2) Console.WriteLine("Графики паралельны."); // если к1 равно к2 то графики паралельны
    else if (k1 == -1 / k2) // если к1 равен -1/к2 то графики перпендикулярны
    {
        Console.WriteLine("Граифки перпендикулярны"); // вывод
        Console.WriteLine($"x = {x}, y = {y}"); // вывод
    }
    else if (k1 != k2) // если к1 не равен к2 то графики пересекаются
    {
        Console.WriteLine("Графики пресекаются."); // вывод
        Console.WriteLine($"x = {x}, y = {y}"); // вывод
    }
}
 
Console.WriteLine("Поиск пересечения двух прямых через уравнения: "); // вывод
Console.WriteLine("y = k1 * x + b1; y = k2 * x + b2"); // вывод

int b1 = ReadN("b1 = "); // 2
int k1 = ReadN("k1 = "); // 5
int b2 = ReadN("b2 = "); // 4
int k2 = ReadN("k2 = "); // 9

intersectionPoint(k1, k2, b1, b2);  // вывод по методу
